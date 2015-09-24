using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AOACollections.Models
{
    public class Customer
    {
        
            [DisplayName("User Name")]
            public int ID { get; set; }

            [DisplayName("First Name")]
            public string FirstName { get; set; }

            [DisplayName("Last Name")]
            public string LastName { get; set; }

            [DisplayName("City")]
            public string City { get; set; }

            [DisplayName("Address")]
            public string Address { get; set; }

            [DisplayName("Gender")]
            public Gender Gender { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime RegistrationDate { get; set; }

            [DisplayName("Password")]
            public PasswordPropertyTextAttribute Password { get; set; }

            public Customer()
            {
                RegistrationDate = DateTime.Now;
            }

    }

    public enum Gender
    {
        Male,
        Female
    }
}