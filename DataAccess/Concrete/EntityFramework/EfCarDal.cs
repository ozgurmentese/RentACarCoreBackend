using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join clr in context.Colors on c.ColorId equals clr.Id

                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 GearType = c.GearType,
                                 EnginePower = c.EnginePower,
                                 FuelType = c.FuelType,
                                 Description = c.Description,
                                 CarImage = (from i in context.CarImages
                                             where (c.Id == i.CarId)
                                             select new CarImage
                                             {
                                                 Id = i.Id,
                                                 CarId = c.Id,
                                                 Date = i.Date,
                                                 ImagePath = i.ImagePath
                                             }).ToList()

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
