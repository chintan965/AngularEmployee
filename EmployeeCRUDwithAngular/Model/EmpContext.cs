using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDwithAngular.Model
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
