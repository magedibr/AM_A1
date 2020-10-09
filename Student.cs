using System;
namespace AM_A1
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(string name, Address residence, string email) : base(name, residence, email)
        {
            this.Name = name;
            this.Residence = residence;
            this.Email = email;

        }

        public override string ToString()
        {


            return base.ToString() + $"Class: Student | Name = {Name}| Residence = {Residence}| Email ={Email} ";
        }



    }


}
