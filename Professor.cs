
using System;
using System.Collections.Generic;
using System.Linq;

namespace AM_A1
{
    public class Professor : Employee
    {

        public Professor() { }


        public Professor(string name, Address residence, string email, int salary, DateTime hireDate, double hours, Enum rank) : base(salary, hireDate)
        {
            this.Name = name;
            this.Residence = residence;
            this.Email = email;
            this.Salary = salary;
            this.HireDate = hireDate;
            this.Hours = hours;
            this.Rank = rank;

        }
        public enum rank
        {
            Associate=0,
            Proffessor=1,
            Assis_Prof=2,
        }


        public double Hours { get; set; }
        public Enum Rank { get; set; }

        public static void UpdateProf(String name, String email, List<Professor> list)
        {
            var Plist = from p in list
                        where p.Name == name && p.Email == email
                        select p;

            Console.WriteLine("Please enter in new details in the following order: Name,Residence and email.\n");
          
            Console.WriteLine("Name:");
            string newName = Console.ReadLine();
            
            Console.WriteLine("Address one,two and City");
            string Address1 = Console.ReadLine();
            string Address2 = Console.ReadLine();
            string City = Console.ReadLine();
            
            Console.WriteLine("Email:");
            string newEmail = Console.ReadLine();
            
            Console.WriteLine("Hire Date:");
            string newDate = Console.ReadLine();
            DateTime UpdatedDate = Convert.ToDateTime(newDate);
            
            Console.WriteLine("Hours:");
            string stringHours = Console.ReadLine();
            int newHours = Convert.ToInt32(stringHours);

           

            Console.WriteLine("Enter number to chose rank\n 0 = Associate \n 1 = Professor \n 2 for Assistant Professor:");

            Console.WriteLine("Rank");
            string rankk = Console.ReadLine();
            int tr=  Convert.ToInt32(rankk);


            Console.WriteLine("Salary");
            string sall = Console.ReadLine();
            Double newSal = Convert.ToDouble(sall);

            Plist.ToList();

            foreach (Professor prof in Plist)
            {

                prof.Email = newEmail;
                prof.Residence.Address1 = Address1;
                prof.Residence.Address2 = Address2;
                prof.Residence.City = City;
                prof.Name = newName;
                prof.HireDate = UpdatedDate.Date;
                prof.Rank = (rank)tr;
                prof.Salary = newSal;

            }




        }
    }
}
