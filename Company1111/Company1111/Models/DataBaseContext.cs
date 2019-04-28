using Company.Models;
using NayanTraders.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Company1111.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext() {
            Database.SetInitializer<DataBaseContext>(null);
        }
        public DbSet<RoomCategories> RoomCategories { get; set; }
       
        public DbSet<UserType> userTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StaffHotel> StaffHotels { get; set; }
        public DbSet<OwnerHotel> OwnerHotels { get; set; }
        //public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<Company1111.Models.StaffRegistrationVM> StaffRegistrationVMs { get; set; }

        //public System.Data.Entity.DbSet<Company1111.Models.Room> Rooms { get; set; }
    }
}