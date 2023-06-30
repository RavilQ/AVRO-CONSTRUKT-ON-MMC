using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Slider:BaseEntity
    {
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Title2 { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
        [MaxLength(30)]
        public string ButtonText { get; set; }
        public int queue { get; set; }
        [MaxLength(200)]
        public string BtnLink { get; set; }
    }
}
