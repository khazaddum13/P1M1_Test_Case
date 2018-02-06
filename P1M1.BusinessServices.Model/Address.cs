using P1M1.BusinessServices.ALL;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1M1.BusinessServices.Model
{
    [Serializable]
    public class Address : BaseClass<Address>
    {
        #region Property

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }


        #endregion Property

        public Address()
        {

        }

        public Address(string street, string city, string state, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
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
