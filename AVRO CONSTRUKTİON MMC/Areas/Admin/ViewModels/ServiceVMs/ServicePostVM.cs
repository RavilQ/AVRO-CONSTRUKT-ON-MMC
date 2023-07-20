using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ServiceVMs
{
    public class ServicePostVM
    {
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(50, ErrorMessage = "100 hərfdən ibarət olmalıdır")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(500, ErrorMessage = "100 hərfdən ibarət olmalıdır")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(100, ErrorMessage = "100 hərfdən ibarət olmalıdır")]
        public string Icon { get; set; }
    }
}
