using AVRO_CONSTRUKTİON_MMC.Models;
using X.PagedList;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.JobVMs
{
    public class JobIndexVM
    {
        public IPagedList<Job> Jobs { get; set; }
    }
}
