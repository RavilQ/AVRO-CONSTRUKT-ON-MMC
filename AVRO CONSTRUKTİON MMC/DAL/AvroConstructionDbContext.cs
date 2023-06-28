using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.EntityFrameworkCore;

namespace AVRO_CONSTRUKTİON_MMC.DAL
{
    public class AvroConstructionDbContext:DbContext
    {
        public AvroConstructionDbContext(DbContextOptions<AvroConstructionDbContext> opt): base(opt)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
