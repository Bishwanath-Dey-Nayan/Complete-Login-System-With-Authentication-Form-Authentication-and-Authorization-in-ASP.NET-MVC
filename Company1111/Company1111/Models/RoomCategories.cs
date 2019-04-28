using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Company1111.Models
{
    public class RoomCategories
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="Name Required",AllowEmptyStrings =false)]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }




        public ICollection<Room> Rooms { get; set; }
    }
}