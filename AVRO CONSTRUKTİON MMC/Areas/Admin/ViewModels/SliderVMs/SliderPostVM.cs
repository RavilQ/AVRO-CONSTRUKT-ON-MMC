using AVRO_CONSTRUKTİON_MMC.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels
{
    public class SliderPostVM
    {
        [MaxLength(50, ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public string Title { get; set; }
        [MaxLength(50, ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public string Title2 { get; set; }
        [MaxLength(150, ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        public string? Text { get; set; }
        [MaxLength(20, ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public string ButtonText { get; set; }
        [MaxLength(200, ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        public string? ButtonLink { get; set; }

        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public int Queue { get; set; }
        [AllowedFileTypes("image/jpeg", "image/png")]
        [MaxFileSize(2)]
        [Required(ErrorMessage ="Boş buraxıla bilməz")]
        public IFormFile Image { get; set; }

    }
}
