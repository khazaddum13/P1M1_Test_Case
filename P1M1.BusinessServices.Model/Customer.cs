using P1M1.BusinessServices.ALL;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1M1.BusinessServices.Model
{
    [Serializable]
    public class Customer : BaseClass<Customer>
    {
        #region Property

        public Address Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion Property

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
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
