using P1M1.BusinessServices.Interfaces;
using System;

namespace P1M1.Library
{
    public class JSONConverter : IConverter
    {
        public void Delete(string fileName)
        {
            throw new NotImplementedException();
        }

        public T Find<T>(string fileName) where T : class
        {
            throw new NotImplementedException();
        }

        public void Save<T>(string fileName, object Obj)
        {
            throw new NotImplementedException();
        }
    }
}
