using System;
namespace AM_A1
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string address1, string address2, string city)
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
        }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"Class: Address | Address1 = {Address1} | Address2 = {Address2} | City = {City}";
        }


    }
}


