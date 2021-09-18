using EmployeeCRUDwithAngular.Interface;
using EmployeeCRUDwithAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Repository
{
    public class AuthRepo : IAuth
    {
        private readonly EmpContext _Context;

        public AuthRepo(EmpContext context)
        {
            _Context = context;
        }

        public void Register(Employee Emp)
        {
            try
            {
                _Context.Add(Emp);
                _Context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
}
