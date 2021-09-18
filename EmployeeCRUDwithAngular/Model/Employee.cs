using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Empname { get; set; }
        public string Empdesig { get; set; }
        public string Empmobile { get; set; }
        public string Empage { get; set; }
        public string Empaddress { get; set; }
        public string EmpUserName { get; set; }
        public string Emppassword { get; set; }
    }
}
