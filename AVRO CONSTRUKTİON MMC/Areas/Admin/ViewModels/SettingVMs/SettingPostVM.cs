using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.SettingVMs
{
    public class SettingPostVM
    {
        [MaxLength(300)]
        public string Value { get; set; }
    }
}
