using System;
using System.Collections.Generic;

namespace AM_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studList = new List<Student>();

            studList.Add(new Student("stu1", new Address("A1", "A12", "C1"), "stu1@eg.com"));
            studList.Add(new Student("stu2", new Address("A2", "A22", "C2"), "stu1@eg.com"));
            studList.Add(new Student("stu3", new Address("A3", "A32", "C3"), "stu3@eg.com"));
            studList.Add(new Student("stu4", new Address("A4", "A42", "C4"), "stu4@eg.com"));

            List<Staff> staffList = new List<Staff>();

            staffList.Add(new Staff("St1", new Address("B1", "B12", "BC1"), "staf1@eg.com", 3000, new DateTime(2018, 10, 08), Staff.designation.Clerk));
            staffList.Add(new Staff("St2", new Address("B2", "B22", "BC2"), "staf2@eg.com", 5000, new DateTime(2018, 11, 05), Staff.designation.Maintainance));
            staffList.Add(new Staff("St3", new Address("B3", "B32", "BC3"), "staf3@eg.com", 6500, new DateTime(2016, 09, 02), Staff.designation.Office_Assistance));
            staffList.Add(new Staff("St4", new Address("B4", "B42", "BC4"), "staf4@eg.com", 6500, new DateTime(2017, 03, 09), Staff.designation.Secretary));




            List<Professor> profList = new List<Professor>();

            profList.Add(new Professor("Prof1", new Address("P1", "P12", "PC1"), "prof1@eg.com", 7000, new DateTime(2016, 09, 10), Professor.rank.Assis_Prof));
          





        }
    }
}
