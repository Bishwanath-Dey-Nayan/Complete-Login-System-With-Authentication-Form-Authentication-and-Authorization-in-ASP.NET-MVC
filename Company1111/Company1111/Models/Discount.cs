using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company1111.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public string DiscountCode { get; set; }
        public String Status { get; set; }
    }
}