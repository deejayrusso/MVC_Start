using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.DataAccess
{
  public class ApplicationDbContext : DbContext
  {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
    }
}