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

            staffList.Add(new Staff("St1", new Address("B1", "B12", "BCt1"), "staf1@eg.com", 3000, new DateTime(2018, 10, 08).Date, Staff.designation.Proffessor));
            staffList.Add(new Staff("St2", new Address("B2", "B22", "BCt2"), "staf2@eg.com", 5000, new DateTime(2018, 11, 05).Date, Staff.designation.Maintainance));
            staffList.Add(new Staff("St3", new Address("B3", "B32", "BCt3"), "staf3@eg.com", 6500, new DateTime(2016, 09, 02).Date, Staff.designation.Office_Assistance));
            staffList.Add(new Staff("St4", new Address("B4", "B42", "BCt4"), "staf4@eg.com", 6500, new DateTime(2017, 03, 09).Date, Staff.designation.Secretary));


            List<Professor> profList = new List<Professor>();

            profList.Add(new Professor("Pr1", new Address("C1", "C12", "Pct1"), "Pr1@eg.com", 7800, new DateTime(2018, 10, 09).Date, "Fri:  5pm - 6pm", Professor.rank.Associate));
            profList.Add(new Professor("Pr2", new Address("C2", "C22", "Pct2"), "Pr2@eg.com", 7600, new DateTime(2018, 10, 09).Date, "Thus: 3pm - 7pm", Professor.rank.Assis_Prof));
            profList.Add(new Professor("Pr3", new Address("C3", "C32", "Pct3"), "Pr3@eg.com", 6600, new DateTime(2018, 10, 09).Date, "Tue:  5pm - 7pm", Professor.rank.Assis_Prof));
            profList.Add(new Professor("Pr4", new Address("C4", "C42", "Pct4"), "Pr4@eg.com", 8000, new DateTime(2018, 10, 09).Date, "Mon:  1pm-4pm ", Professor.rank.Professor));
            string menuMsg = "Welcome, please choose a command:\n" +
                         "Press 1 to modify Student\n" +
                         "Press 2 to modify Staff\n" +
                         "Press 3 to modify Professor\n" +
                         "Press 0 to exit";
            Console.WriteLine(menuMsg);
            string modifyChoice = Console.ReadLine();

             //While loop used to ensure program keeps running till exited
            while (modifyChoice != "0")
            {
             //Switch statment to direct the user to the correct class
                switch (modifyChoice)
                {
                    case "1":
                    //StuFun to process student logic and user input
                        if (Student.StuFunc(studList))
                            Console.WriteLine(menuMsg);
                        modifyChoice = Console.ReadLine();
                        break;

                    case "2":
                    //StaFunc used to process Staff logic and user input
                        if (Staff.StaFunc(staffList))
                            Console.WriteLine(menuMsg);
                        modifyChoice = Console.ReadLine();
                        break;

                    case "3":
                    //ProfFunc to process Professor logic and user input
                        if (Professor.ProfFunc(profList))
                            Console.WriteLine(menuMsg);
                        modifyChoice = Console.ReadLine();

                        break;
                    case "0": return;

                }
            }
        }

    }

}
