using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company1111.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Facilities { get; set; }
        public int Rating { get; set; }
        public int TotalStaff { get; set; }
        public int TotalRoom { get; set; }
        public int TotalFloor { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<StaffHotel> staffHotels { get; set; }
        public ICollection<OwnerHotel> OwnerHotels { get; set; }
        //public ICollection<Reservation> Reservations { get; set; }
    }
}