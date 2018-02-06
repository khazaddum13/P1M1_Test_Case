namespace P1M1.BusinessServices.Interfaces
{
    public interface IConverter
    {
        T Find<T>(string fileName) where T : class;
        void Save<T>(string fileName, object Obj);
        void Delete(string fileName);
    }
}
