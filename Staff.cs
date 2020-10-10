
using System;
using System.Collections.Generic;
using System.Linq;

namespace AM_A1
{
    public class Staff : Employee
    {
        public Staff()
        {
        }


        public Staff(string name, Address residence, string email, float salary, DateTime hireDate, Enum designation) : base(salary, hireDate)
        {


            this.Name = name;
            this.Residence = residence;
            this.Email = email;
            this.Salary = salary;
            this.HireDate = hireDate;
            this.Designation = designation;
        }


        public enum designation
        {
            Clerk=0,
            Office_Assistance=1,
            Secretary=2,
            Maintainance=3
        }

        public Enum Designation { get; set; }


        public static void UpdateStaff(String name, String email, List<Staff> list)
        {
            var Stalist = from sta in list
                        where sta.Name == name && sta.Email == email
                        select sta;

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

            
            Console.WriteLine("Enter number to chose Designation\n 0 = Clerk \n 1 =Office_Assistance\n 2= Secretary \n 3= Maintainance");

            Console.WriteLine("Rank");
            string rankk = Console.ReadLine();
            int tr = Convert.ToInt32(rankk);


            Console.WriteLine("Salary");
            string sall = Console.ReadLine();
            Double newSal = Convert.ToDouble(sall);

            Stalist.ToList();

            foreach(Staff staff in Stalist)
            {

                staff.Email = newEmail;
                staff.Residence.Address1 = Address1;
                staff.Residence.Address2 = Address2;
                staff.Residence.City = City;
                staff.Name = newName;
                staff.HireDate = UpdatedDate.Date;
                staff.Designation = (designation)tr;
                staff.Salary = newSal;

            }

        }



        public override string ToString()
        {
            return base.ToString() + $"Name = {Name}| Residence = {Residence} | Email ={Email} | Hire Date = {HireDate.Date} | Salary = {Salary}| Designation= {Designation}";
        }
    }
}
