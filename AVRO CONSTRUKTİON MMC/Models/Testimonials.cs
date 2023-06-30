using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Testimonials:BaseEntity
    {
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(25)]
        public string Fullname { get; set; }
        [MaxLength(50)]
        public string Job { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
    }
}
