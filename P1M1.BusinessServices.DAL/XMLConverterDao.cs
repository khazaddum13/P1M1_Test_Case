using System.IO;
using System.Xml.Serialization;

namespace P1M1.BusinessServices.DAL
{
    public class XMLConverterDao
    {
        #region Property

        private XmlSerializer m_Serializer = null;

        #endregion
        
        public void Delete(string fileName)
        {
            var fName = fileName + ".xml";
            File.Delete(fName);
        }

        public T Find<T>(string fileName) where T : class
        {
            m_Serializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(fileName + ".xml", FileMode.Open))
            {
                return m_Serializer.Deserialize(stream) as T;
            }
        }

        public void Save<T>(string fileName, object Obj)
        {
            m_Serializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(fileName + ".xml", FileMode.Create))
            {
                m_Serializer.Serialize(stream, Obj);
            }
        }
    }
}
