using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NayanTraders.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }

        public string Image { get; set; }
        public string Address { get; set; }
        public string NID { get; set; }
        public string DrivingLicense { get; set; }
        public string Passport { get; set; }



        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Password { get; set; }
        public bool IsEmailVerified { get; set; }
        public System.Guid ActivationCode { get; set; }
        public string ResetPasswordCode { get; set; }


        public int UserTypeID { get; set; }
        public virtual UserType UserType { get; set; }


    }
}