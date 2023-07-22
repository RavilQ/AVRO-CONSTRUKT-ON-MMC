using AVRO_CONSTRUKTİON_MMC.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.HomeInfoVMs
{
    public class HomeInfoVM
    {
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        [MaxLength(50)]
        public string Title { get; set; }
        [AllowedFileTypes("image/jpeg", "image/png")]
        [MaxFileSize(2)]
        public IFormFile? RightImage { get; set; }
        [AllowedFileTypes("image/jpeg", "image/png")]
        [MaxFileSize(2)]
        public IFormFile? LeftImage { get; set; }
        [MaxLength(500)]
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public string BtnText { get; set; }
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public string BtnLink { get; set; }

        public IDictionary<string, string?>? Settings { get; set; }
    }
}
