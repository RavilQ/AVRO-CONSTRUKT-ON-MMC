using X.PagedList;

namespace AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces
{
    public class Paginator : IPaginator
    {
        public IPagedList<T>? GetPagedList<T>(ICollection<T> listUnpaged, int page = 1, int pageSize = 1)
        {
            var listPaged = listUnpaged.ToPagedList(page, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (listPaged.PageNumber != 1 && page > listPaged.PageCount)
                return null;

            return listPaged;
        }
    }
}
