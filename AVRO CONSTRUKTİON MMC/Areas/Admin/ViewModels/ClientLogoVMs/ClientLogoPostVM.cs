
using AVRO_CONSTRUKTİON_MMC.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ClientLogoVMs
{
    public class ClientLogoPostVM
    {
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        [AllowedFileTypes("image/jpeg", "image/png")]
        [MaxFileSize(2)]
        public IFormFile ImageFile { get; set; }
    }
}
