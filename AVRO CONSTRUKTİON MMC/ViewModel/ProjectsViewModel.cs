using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class ProjectsViewModel
    {
        public List<Project > Projects { get; set; }
        public IDictionary<string, string?> Settings { get; set; }
    }
}
