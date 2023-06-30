using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Employee:BaseEntity
    {
        [MaxLength(30)]
        public string Fullname { get; set; }
        public int JobId { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }

        public Job Job { get; set; }
    }
}
