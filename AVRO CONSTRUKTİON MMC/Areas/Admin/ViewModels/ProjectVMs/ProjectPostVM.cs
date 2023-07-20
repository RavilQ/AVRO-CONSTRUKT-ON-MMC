using AVRO_CONSTRUKTİON_MMC.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ProjectVMs
{
    public class ProjectPostVM
    {
        [Required(ErrorMessage = "Boş buraxıla bilməz")]

        [MaxLength(100, ErrorMessage = "100 hərfdən ibarət olmalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(5000, ErrorMessage ="Çox böyük mətin daxil edildi.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxFileSize(2)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        public bool IsFeatured { get; set; }
    }
}
