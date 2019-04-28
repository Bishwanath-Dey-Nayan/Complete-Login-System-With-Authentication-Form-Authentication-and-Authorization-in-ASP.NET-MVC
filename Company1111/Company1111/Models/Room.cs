using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company1111.Models
{
    public class Room
    {
        public int Id { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public int CategoryId { get; set; }
        public virtual RoomCategories RoomCategories { get; set; }

        public string Image { get; set; }
        public string Facilities { get; set; }
        public string Description { get; set; }
        public string View { get; set; }
        public string Status { get; set; }
        public int BedNumber { get; set; }
        public string BedType { get; set; }

       // public ICollection<Reservation> Reservations { get; set; }
    }
}