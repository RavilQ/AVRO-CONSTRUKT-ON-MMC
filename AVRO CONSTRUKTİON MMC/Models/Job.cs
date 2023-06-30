using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Job:BaseEntity
    {
        [MaxLength(70)]
        public string Name { get; set; }
    }
}
