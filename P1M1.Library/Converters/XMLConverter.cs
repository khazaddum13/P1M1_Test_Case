using P1M1.BusinessServices.DAL;
using P1M1.BusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1M1.Library
{
    public class XMLConverter : IConverter
    {
        #region Property

        XMLConverterDao m_Dao = new XMLConverterDao();

        public XMLConverterDao Dao { get => m_Dao; set => m_Dao = value; }

        #endregion Property

        public void Delete(string fileName)
        {
            Dao.Delete(fileName);
        }

        public T Find<T>(string fileName) where T : class
        {
            return Dao.Find<T>(fileName);
        }

        public void Save<T>(string fileName, object obj)
        {
            Dao.Save<T>(fileName, obj);
        }
    }
}
