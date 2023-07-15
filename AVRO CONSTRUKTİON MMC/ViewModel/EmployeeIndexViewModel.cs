using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class EmployeeIndexViewModel
    {
        public ICollection<Employee> Employees { get; set; }
        public IDictionary<string, string?> Setting { get; set; }
    }
}
