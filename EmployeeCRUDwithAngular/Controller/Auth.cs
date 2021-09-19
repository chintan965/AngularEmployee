using AutoMapper.Configuration;
using EmployeeCRUDwithAngular.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly UserManager<Employee> _userManager;
        

        public Auth(UserManager<Employee> userManager)
        {
            _userManager = userManager;


        }
        [HttpPost("Register")]
        public async Task<IActionResult>Register([FromBody] Employee emp)
        {
           
            var userExist = await _userManager.FindByEmailAsync(emp.Email);
            if (userExist == null)
            {
                Employee user = new Employee()
                {
                     name= emp.name,
                    desig = emp.desig,
                    mobile = emp.mobile,
                    age = emp.age,
                    Email = emp.Email,
                    address = emp.address,
                    UserName=emp.name,
                    password = emp.password
                };
                var result = await _userManager.CreateAsync(user, emp.password);
                if (!result.Succeeded)
                {
                    return Conflict("registration does not successfully");
                }
                else
                {
                    return NoContent();
                }
            }
            return NoContent();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(Employee emp)
        {
            var user = await _userManager.FindByEmailAsync(emp.Email);
            if (user.Email == emp.Email)
            {
                return Ok("Login Successfully");
            }
            return Conflict("Invalid credentials");
        }
    }
}
