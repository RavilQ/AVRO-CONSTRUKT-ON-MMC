using AVRO_CONSTRUKTİON_MMC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AVRO_CONSTRUKTİON_MMC.DAL
{
    public class AvroConstructionDbContext : IdentityDbContext<AppUser>
    {
        public AvroConstructionDbContext(DbContextOptions<AvroConstructionDbContext> opt) : base(opt)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<ContactMessageReply> contactMessageReplies { get; set; }
    }
}
