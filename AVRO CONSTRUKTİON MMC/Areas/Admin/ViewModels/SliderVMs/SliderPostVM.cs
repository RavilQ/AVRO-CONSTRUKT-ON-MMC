using AVRO_CONSTRUKTİON_MMC.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels
{
    public class SliderPostVM
    {
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Title2 { get; set; }
        [MaxLength(150)]
        public string? Text { get; set; }
        [MaxLength(20)]
        public string ButtonText { get; set; }
        [MaxLength(200)]
        public string? ButtonLink { get; set; }
        
        public int Queue { get; set; }
        [AllowedFileTypes("image/jpeg", "image/png")]
        [MaxFileSize(2)]
        public IFormFile Image { get; set; }
        
    }
}
