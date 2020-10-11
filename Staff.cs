
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


        public Staff(string name, Address residence, string email, double salary, DateTime hireDate, Enum designation) : base(salary, hireDate)
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


        public static bool StaFunc(List<Staff> stfLi)
        {
            Console.WriteLine("Staff Menu\n" +
                "Press 1 to list all staff\n" +
                "Press 2 to add a new staff member\n" +
                "Press 3 to update an existing staff member\n" +
                "Press 4 to delete a staff member" +
                "Press 5 to return to main menu"
               );

            string StuChoice = null;


            while (StuChoice != "5")
            {
                StuChoice = Console.ReadLine();

                switch (StuChoice)
                {
                    case "1":
                        showAll<Staff>(stfLi);
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

                        Console.WriteLine("Hire Date:");
                        string newDate = Console.ReadLine();
                        DateTime UpdatedDate = Convert.ToDateTime(newDate);

                      
                        Console.WriteLine("Enter number to chose Designation\n 0 = Clerk \n 1 =Office_Assistance\n 2= Secretary \n 3= Maintainance");

                        Console.WriteLine("Rank");
                        string DesigS = Console.ReadLine();
                        int tr = Convert.ToInt32(DesigS);



                        Console.WriteLine("Salary");
                        string sall = Console.ReadLine();
                        Double newSal = Convert.ToDouble(sall);

                        designation Deisg = (designation)tr;


                        Add<Staff>(stfLi, new Staff(Name, new Address(Address1, Address2, City), newEmail, newSal, UpdatedDate, Deisg));
                        Console.WriteLine("New List\n");
                        showAll<Staff>(stfLi);

                        break;


                    case "3":

                        Console.WriteLine("Enter the name and email of the student youd like to update\n");

                        Console.WriteLine("Name");
                        string findName = Console.ReadLine();
                        Console.WriteLine("Email:");
                        string findEmail = Console.ReadLine();

                        UpdateStaff(findName, findEmail, stfLi);
                        Console.WriteLine("New List");
                        showAll<Staff>(stfLi);

                        break;


                    case "4":
                        showAll<Staff>(stfLi);
                        Console.WriteLine("Please enter the number that corrosponds to the students position on the list:(Ascending)\n");
                        string delChoice = Console.ReadLine();
                        Convert.ToInt16(delChoice);
                        Modify.Del<Staff>(stfLi, Int32.Parse(delChoice));


                        Console.WriteLine("New List");
                        showAll<Staff>(stfLi);


                        break;


                    case "5":

                        break;
                }
                return true;

            }
        }




    }
}
