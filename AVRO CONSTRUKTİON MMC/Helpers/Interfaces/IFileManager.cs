namespace AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces
{
    public  interface IFileManager
    {
         string Save(IFormFile file, string rootPath, string folder, int maxSize);
        void Delete(string rootPath, string folder, string fileName);
    }
}
