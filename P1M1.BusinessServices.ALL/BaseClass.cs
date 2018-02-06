using P1M1.BusinessServices.Interfaces;
using P1M1.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1M1.BusinessServices.ALL
{
    [Serializable]
    public abstract class BaseClass<T> : ICloneable, IDisposable where T : class
    {
        #region Property

        public string Id { get; set; }
        private static IConverter m_Converter { get; set; }

        #endregion

        public BaseClass()
        {
            m_Converter = Converter.GetConverter("XMLConverter");
        }
        public static T Find(string Id)
        {
            if (string.IsNullOrEmpty(Id)) return null;
            return m_Converter.Find<T>(Id);
        }

        public void Save()
        {
            if (String.IsNullOrEmpty(Id))
            {
                Id = Guid.NewGuid().ToString("n");
            }
            m_Converter.Save<T>(Id, this);
        }

        public void Delete()
        {
            if (string.IsNullOrEmpty(Id)) return;
            m_Converter.Delete(Id);
            Id = null;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
