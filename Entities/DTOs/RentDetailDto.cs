using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentDetailDto:IDto
    {
        public int RentalId { get; set; }
        public string CarDescription { get; set; }
        public string CampanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
