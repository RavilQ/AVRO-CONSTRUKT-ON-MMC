using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Setting : BaseEntity
    {
        [MaxLength(30)]
        public string Key { get; set; }
        [MaxLength(300)]
        public string? Value { get; set; }
    }
}
