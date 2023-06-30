using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Service:BaseEntity
    {
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
        [MaxLength(100)]
        public string Icon { get; set; }
    }
}
