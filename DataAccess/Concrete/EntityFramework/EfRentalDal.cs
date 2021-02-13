using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,reCapProjectContext>,IRentalDal
    {
        public List<RentDetailDto> GetRentDetails()
        {
            using (reCapProjectContext context = new reCapProjectContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cs in context.Customers
                             on r.CustomerId equals cs.Id
                             select new RentDetailDto
                             {
                                 RentalId=r.Id,
                                 CarDescription=c.Description,
                                 CampanyName=cs.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                             };
                return result.ToList();
            }

        }
    }
}
