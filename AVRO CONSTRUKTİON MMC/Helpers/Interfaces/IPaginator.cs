using X.PagedList;

namespace AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces
{
    public interface IPaginator
    {
        public IPagedList<T> GetPagedList<T>(ICollection<T> listUnpaged, int currentPage = 1, int pageSize = 1);
    }
}
