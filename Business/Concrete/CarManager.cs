using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Entities.DTOs;
using Core.Aspects.Autofac.Caching;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(
                    CheckIfCarNameExists(car.CarName)
                );
            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.DataAdded);
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.DataUpdated);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DataDeleted);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId)
        {
            if (colorId < 1)
            {
                return new ErrorDataResult<List<CarDetailDto>>("Veri yok");
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == colorId));
        }

        public IDataResult<Car> GetByCarId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Count;
            if (result > 0)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
