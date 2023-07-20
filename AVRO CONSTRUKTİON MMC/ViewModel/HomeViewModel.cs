using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class HomeViewModel
    {
        public ICollection<Slider> Sliders { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Testimonials> Testimonials { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Project> Projects { get; set; }
        public IDictionary<string, string?> Settings { get; set; }
        public ICollection<ClientLogo> ClientLogos { get; set; }

    }
}
