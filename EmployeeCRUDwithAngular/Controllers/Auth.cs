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
    }
}
