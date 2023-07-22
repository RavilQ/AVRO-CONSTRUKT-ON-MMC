using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class AboutUsViewModel
    {
        public ICollection<Employee> Employees { get; set; }
        public IDictionary<string, string?> Settings { get; set; }
    }
}
