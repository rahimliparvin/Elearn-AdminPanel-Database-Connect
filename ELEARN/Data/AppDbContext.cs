using ELEARN.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ELEARN.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Author>  Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }



    }
}
