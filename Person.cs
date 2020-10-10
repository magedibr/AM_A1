using System;
using System.Collections.Generic;
using System.Linq;
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
            base.ToString();
            return $"LName = {Name}| Residence = {Residence}| Email ={Email}";
        }


        public static void
            showAll<T>(List<T> GenList)
        {
            var Per = from Show in GenList select Show;

            Per.ToList();
            foreach (T s in Per)
                Console.WriteLine(s);

        }

        public static void
           Add<T>(List<T> GenList,T inp)
        {
            GenList.Add(inp);
                   }


















    }
}


