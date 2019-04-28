using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NayanTraders;

namespace Company1111.Models
{

    public class StaffRegistrationVM
    {

        public int Id { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="Name Required.",AllowEmptyStrings =false)]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        [Required(ErrorMessage = "Name Required.", AllowEmptyStrings = false)]
        public string LastName { get; set; }


        [Display(Name="E-mail Address")]
        [EmailAddress]
        [Required(ErrorMessage ="E-mail Address Required",AllowEmptyStrings =false)]
        public string EmailID { get; set; }


        public string Image { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name ="National ID No.")]
        public string NID { get; set; }

        [Display(Name ="Driving License")]
        public string DrivingLicense { get; set; }

        
        public string Passport { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name ="Birth Date")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }


        [Required(ErrorMessage ="Please Input the Password",AllowEmptyStrings =false)]
        [DataType(DataType.Password)]
        //[RegularExpression("^ (?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="PassWord Does not match.")]
        public String ConfirmPassword { get; set; } 

        [Required]
        [Display(Name ="User Type")]
        public int UserTypeID { get; set; }



    }
}