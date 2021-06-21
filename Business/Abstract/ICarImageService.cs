using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IResult DeleteByCarId(int carId);
        IDataResult<CarImage> Get(int carImageid);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesById(int id);

    }
}
