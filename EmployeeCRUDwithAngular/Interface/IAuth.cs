using EmployeeCRUDwithAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Interface
{
    public interface IAuth
    {
        void Register(Employee Emp);
        Employee GetById(string EmpUserName);
    }
}
