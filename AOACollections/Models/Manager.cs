using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AOACollections.Models
{
    public class Manager
    {
        [DisplayName("User Name")]
        public int ID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        
        [DisplayName("Last Name")]
        public string LastName { get; set; }
            
        [DisplayName("Password")]
        public PasswordPropertyTextAttribute Password { get; set; }
    }
}