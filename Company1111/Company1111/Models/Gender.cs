using Company1111.Models;
using NayanTraders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        
        public ICollection<User> User { get; set; }

    }
}