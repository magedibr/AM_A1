using System;
namespace AM_A1
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, Address residence, string email){
            this.Name = name;
            this.Residence = residence;
            this.Email = email;
        }

        public string Name { get; set; }
        public Address Residence { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {

            return $"Class: Person | Name = {Name}| Residence = {Residence}| Email ={Email} ";
        }























    }
}


