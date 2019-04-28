using NayanTraders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company1111.Models
{
    public class OwnerHotel
    {
        public int Id { get; set; }


        public int userId { get; set; }
        public virtual User User { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}