using System;

namespace AM_A1
{
    public class Employee : Person
    {
        public Employee()
        {
        }

        public Employee(float salary, DateTime hireDate)
        {
            Salary = salary;
            this.HireDate = hireDate;
        }

        public Employee(string name, Address residence, string email, int salary, DateTime hireDate) : base(name, residence, email)
        {
            if (salary > 2000 && salary < 8000)
            {
                this.Name = name;
                this.Residence = residence;
                this.Email = email;
                this.Salary = salary;
                this.HireDate = hireDate;
            }
            else Console.WriteLine("Salaray must be between 2k and 8k");

        }

        
        public float Salary { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {

            return base.ToString() + $"Class: Employee | Name = {Name}| Residence = {Residence}| Email ={Email} | Hire Date = {HireDate} | Salary = {Salary}";

        }
    }
}
