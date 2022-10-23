using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IS_Student_Employees2.Models;

namespace IS_Student_Employees2.Data
{
    public class IS_Student_Employees2Context : DbContext
    {
        public IS_Student_Employees2Context (DbContextOptions<IS_Student_Employees2Context> options)
            : base(options)
        {
        }

        public DbSet<IS_Student_Employees2.Models.Employee> Employee { get; set; } = default!;
    }
}
