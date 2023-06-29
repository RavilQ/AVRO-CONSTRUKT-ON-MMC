using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.JobVMs
{
    public class JobPostVM
    {
        public int? Id { get; set; }
        [MaxLength(20,ErrorMessage = "Maksimum uzunluq 20 olmalıdır")]
        public string Name { get; set; }
    }
}
