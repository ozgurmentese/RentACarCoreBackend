using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {

                var result = from rentals in context.Rentals
                             join cars in context.Cars
                             on rentals.CarId equals cars.Id
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             join users in context.Users
                             on rentals.UserId equals users.Id
                             join colors in context.Colors
                             on cars.ColorId equals colors.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rentals.Id,
                                 UserId = users.Id,
                                 CarName = cars.CarName,
                                 BrandName = brands.BrandName,
                                 ColorName = colors.ColorName,
                                 UserName = users.FirstName + " " + users.LastName,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate,
                                 DailyPrice = cars.DailyPrice,
                                 CarId = cars.Id,

                                 TotalRentDay = (rentals.ReturnDate.Value.Day - rentals.RentDate.Day +
                                 (rentals.ReturnDate.Value.Month - rentals.RentDate.Month) * 30 +
                                 (rentals.ReturnDate.Value.Year - rentals.RentDate.Year) * 365),

                                 TotalPrice = Convert.ToDecimal(rentals.ReturnDate.Value.Day - rentals.RentDate.Day
                                 + (rentals.ReturnDate.Value.Month - rentals.RentDate.Month) * 30 +
                                 (rentals.ReturnDate.Value.Year - rentals.RentDate.Year) * 365) * cars.DailyPrice

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
