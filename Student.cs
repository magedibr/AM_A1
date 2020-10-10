using System;
using System.Security.Cryptography.X509Certificates;

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
            base.ToString(); 
            return $"Student | Name = {Name}| Residence = {Residence}| Email ={Email}";
        }

        public static void StuFunc()
        {

             Console.WriteLine("Student Menu\n" +
                 "Press 1 to list aa students\n" +
                 "Press 2 to add a new student\n" +
                 "Press 3 to update an existing student\n" +
                 "Press 4 to delete a student"+
                 "Press 5 to return to main menu"
                );
/*
            string stChoice = null;
                
                
                while (stChoice != "5") {
                stChoice = Console.ReadLine();
                switch (stChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                }



            }

*/




































        }











    }


}
