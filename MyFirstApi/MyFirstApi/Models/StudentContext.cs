using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Models
{
    public class StudentContext:DbContext
    {
        StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> students { get; }


    }
}
