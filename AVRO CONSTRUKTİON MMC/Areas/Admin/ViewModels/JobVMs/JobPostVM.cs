using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.JobVMs
{
    public class JobPostVM
    {
        public int? Id { get; set; }
        [MaxLength(20,ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        public string Name { get; set; }
    }
}
