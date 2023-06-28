using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class HomeViewModel
    {
       public List<Slider> Sliders { get; set; } = new List<Slider>();
       public List<Employee> Employees { get; set; } = new List<Employee>();
       public List<Testimonials> Testimonials { get; set; } = new List<Testimonials>();
       public List<Service> Services { get; set; } = new List<Service>(); 
    }
}
