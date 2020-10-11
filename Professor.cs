
using System;
using System.Collections.Generic;
using System.Linq;

namespace AM_A1
{
    public class Professor : Employee
    {

        public Professor() { }


        public Professor(string name, Address residence, string email, double salary, DateTime hireDate, string Hours , Enum rank) : base(salary, hireDate)
        {
            this.Name = name;
            this.Residence = residence;
            this.Email = email;
            this.Salary = salary;
            this.HireDate = hireDate;
            this.Hours = Hours;            
            this.Rank = rank;

        }
        public enum rank
        {
            Associate = 0,
            Proffessor = 1,
            Assis_Prof = 2,
        }

                public String Hours { get; set; }
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

            Console.WriteLine("Hours (Day:from-to):");
            string stringHours = Console.ReadLine();
            


            Console.WriteLine("Enter number to chose rank\n 0 = Associate \n 1 = Professor \n 2 for Assistant Professor:");

            Console.WriteLine("Rank");
            string rankk = Console.ReadLine();
            int tr = Convert.ToInt32(rankk);


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
                prof.Hours = stringHours;

            }




        }


        public static bool ProfFunc(List<Professor> prList)
        {


            {
                string profMnu = "Professor Menu\n" +
                    "Press 1 to list all Professors\n" +
                    "Press 2 to add a new Professors\n" +
                    "Press 3 to update an existing Professors\n" +
                    "Press 4 to delete a Professor\n" +
                    "Press 5 to return to main menu";

                Console.WriteLine(profMnu);
                string StuChoice = null;


                while (StuChoice != "5")
                {
                    StuChoice = Console.ReadLine();

                    switch (StuChoice)
                    {
                        case "1":
                       Modify.showAll<Professor>(prList);
                            break;

                        case "2":
                            Console.WriteLine("Please enter in new details in the following order: Name,Residence and email.\n");

                            Console.WriteLine("Name");
                            string Name = Console.ReadLine();

                            Console.WriteLine("Address one,two and City");
                            string Address1 = Console.ReadLine();
                            string Address2 = Console.ReadLine();
                            string City = Console.ReadLine();

                            Console.WriteLine("Email:");
                            string newEmail = Console.ReadLine();

                            Console.WriteLine("Hire Date:(MM-DD-YYYY)");
                            string newDate = Console.ReadLine();
                            DateTime UpdatedDate = Convert.ToDateTime(newDate);


                            Console.WriteLine("Enter number to chose Designation\n 0 = Clerk \n 1 =Office_Assistance\n 2= Secretary \n 3= Maintainance");

                            Console.WriteLine("Rank");
                            string DesigS = Console.ReadLine();
                            int tr = Convert.ToInt32(DesigS);



                            Console.WriteLine("Salary");
                            string sall = Console.ReadLine();
                            Double newSal = Convert.ToDouble(sall);

                            rank nRank = (rank)tr;


                            Console.WriteLine(" from:");
                            string newH = Console.ReadLine();

                            Modify.Add<Professor>(prList, new Professor(Name, new Address(Address1, Address2, City), newEmail, newSal, UpdatedDate, newH, nRank));
                            Console.WriteLine("New List\n");
                            Modify.showAll<Professor>(prList);
                            Console.WriteLine(profMnu);
                            break;


                        case "3":

                            Console.WriteLine("Enter the name and email of the student youd like to update\n");

                            Console.WriteLine("Name");
                            string findName = Console.ReadLine();
                            Console.WriteLine("Email:");
                            string findEmail = Console.ReadLine();

                            UpdateProf(findName, findEmail, prList);
                            Console.WriteLine("New List");
                            Modify.showAll<Professor>(prList);
                            Console.WriteLine(profMnu);
                            break;


                        case "4":
                            Modify.showAll<Professor>(prList);
                            Console.WriteLine("Please enter the number that corrosponds to the students position on the list:(Ascending)\n");
                            string delChoice = Console.ReadLine();
                            Convert.ToInt16(delChoice);
                            Modify.Del<Professor>(prList, Int32.Parse(delChoice));

                            Console.WriteLine("New List");
                            Modify.showAll<Professor>(prList);
                            Console.WriteLine(profMnu);

                            break;


                        case "5":

                            break;
                    }

                }return true;
            }
        }
    }    
    
    }


