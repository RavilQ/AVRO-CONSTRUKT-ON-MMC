using AVRO_CONSTRUKTİON_MMC.Models;

namespace AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces
{
    public interface ILayoutService
    {
        IDictionary<string, string?> GetSettingsDictionary();
        ICollection<Project> GetProjects();
    }
}
