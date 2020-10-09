
using System;
namespace AM_A1
{
    public class Professor : Employee
    {

        public Professor() { }
        

    public Professor(string name, Address residence, string email, int salary, DateTime hireDate,double hours,Enum rank) : base (salary, hireDate)
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
            Associate,
            Proffessor,
            Assis_Prof,
        }


        public double Hours { get; set; }
        public Enum Rank { get; set; }






    }
}
