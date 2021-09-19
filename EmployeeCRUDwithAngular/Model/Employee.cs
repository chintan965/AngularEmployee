using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Model
{
    public class Employee:IdentityUser
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string desig { get; set; }
        public string mobile { get; set; }
        public string age { get; set; }

        public string Email { get; set; }
        public string address { get; set; }
        
        public string password { get; set; }
    }

}
