
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
            Clerk,
            Office_Assistance,
            Secretary,
            Maintainance
        }

        public Enum Designation { get; set; }



        public static String showAll(List<Staff> Showlist) {

            var Per = from Show in Showlist select Show;
            Per.ToArray();
            return Per.ToString();
        
        }












        public override string ToString()
        {
            return base.ToString() + $"Class: Staff | Name = {Name}| Residence = {Residence}| Email ={Email} | Hire Date = {HireDate} | Salary = {Salary}| Designation= {Designation}";
        }
    }
}
