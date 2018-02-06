using P1M1.BusinessServices.ALL;
using System;

namespace P1M1.BusinessServices.Model
{
    [Serializable]
    public class Company : BaseClass<Company>
    {
        #region Property

        public Address Address { get; set; }
        public string Name { get; set; }

        #endregion Property

        public Company()
        {

        }

        public Company(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this)) return true;

            if ((obj == null) || (this == null)) return false;

            if (obj.GetType() != this.GetType()) return false;

            var result = true;
            foreach (var property in obj.GetType().GetProperties())
            {
                var objValue = property.GetValue(obj);
                var anotherValue = property.GetValue(this);
                if ((objValue != null && anotherValue != null) && !objValue.Equals(anotherValue)) result = false;
            }

            return result;
        }
    }
}
