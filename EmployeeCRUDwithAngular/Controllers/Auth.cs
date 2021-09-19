using EmployeeCRUDwithAngular.Interface;
using EmployeeCRUDwithAngular.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly IAuth _Auth;

        public Auth(IAuth auth)
        {
            _Auth = auth;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(Employee Emp)
        {
            try
            {
                _Auth.Register(Emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(Employee Emp)
        {
            try
            {
                var emp= _Auth.GetById(Emp.EmpUserName);
                if(emp.EmpUserName== Emp.EmpUserName && emp.Emppassword== Emp.Emppassword)
                {
                    return Ok("Login Successfully");
                }
                else
                {
                    return Ok("Invalid Successfully");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }
    }
}
