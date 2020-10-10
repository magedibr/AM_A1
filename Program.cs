using System;
using System.Collections.Generic;
using System.Linq;

namespace AM_A1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studList = new List<Student>();

            studList.Add(new Student("stu1", new Address("A1", "A12", "Ct1"), "stu1@eg.com"));
            studList.Add(new Student("stu2", new Address("A2", "A22", "C2"), "stu1@eg.com"));
            studList.Add(new Student("stu3", new Address("A3", "A32", "C3"), "stu3@eg.com"));
            studList.Add(new Student("stu4", new Address("A4", "A42", "C4"), "stu4@eg.com"));

            List<Staff> staffList = new List<Staff>();

            staffList.Add(new Staff("St1", new Address("B1", "B12", "BCt1"), "staf1@eg.com", 3000, new DateTime(2018, 10, 08), Staff.designation.Clerk));
            staffList.Add(new Staff("St2", new Address("B2", "B22", "BCt2"), "staf2@eg.com", 5000, new DateTime(2018, 11, 05), Staff.designation.Maintainance));
            staffList.Add(new Staff("St3", new Address("B3", "B32", "BCt3"), "staf3@eg.com", 6500, new DateTime(2016, 09, 02), Staff.designation.Office_Assistance));
            staffList.Add(new Staff("St4", new Address("B4", "B42", "BCt4"), "staf4@eg.com", 6500, new DateTime(2017, 03, 09), Staff.designation.Secretary));


            List<Professor> profList = new List<Professor>();

            profList.Add(new Professor("Pr1", new Address("C1", "C12", "Pct1"), "Pr1@eg.com", 7800, new DateTime(2018, 10, 09), 3.0, Professor.rank.Associate));
            profList.Add(new Professor("Pr2", new Address("C2", "C22", "Pct2"), "Pr2@eg.com", 7600, new DateTime(2018, 10, 09), 3.0, Professor.rank.Assis_Prof));
            profList.Add(new Professor("Pr3", new Address("C3", "C32", "Pct3"), "Pr3@eg.com", 6600, new DateTime(2018, 10, 09), 3.0, Professor.rank.Assis_Prof));
            profList.Add(new Professor("Pr4", new Address("C4", "C42", "Pct4"), "Pr4@eg.com", 8000, new DateTime(2018, 10, 09), 3.0, Professor.rank.Proffessor));






            Console.WriteLine("Welcome, please choose a command:\n" +
                              "Press 1 to modify Student\n" +
                              "Press 2 to modify Staff\n" +
                              "Press 3 to modify Professor\n" +
                              "Press 0 to exit");

            //   Student.showAll<Student>(studList);
         //   Modify.Add(studList, new Student("AAABBB", new Address("heh", "heh", "heh"), "asasd"));
            Console.WriteLine("Please pick which student you would like to delete(pick what number they are in the list)");

            Modify.showAll<Student>(studList);
            //Console.WriteLine("Number:");
            // string num = Console.ReadLine();
            //   Modify.Del<Student>(studList, int.Parse(num));
            //  Modify.showAll<Student>(studList);
            string name = Console.ReadLine();
            string email = Console.ReadLine();

            Student.Update(name, email, studList);
            Modify.showAll<Student>(studList);



        }
    }



}
/*
            while (choice != "0" )
            {
              choice =Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Exited Programm");
                        break;

                    case "1":
                        Staff.showAll(staffList);
                           ;
                       
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                }
            }


           





















        }
    }
}*/
