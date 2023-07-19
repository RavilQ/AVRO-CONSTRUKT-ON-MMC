using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class ServiceViewModel
    {
        public List<Service> Service = new List<Service>();
        public IDictionary<string, string?> Setting { get; set; }
    }
}
