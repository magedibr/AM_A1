using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace AM_A1
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(string name, Address residence, string email) : base(name, residence, email)
        {
            this.Name = name;
            this.Residence = residence;
            this.Email = email;
        }

        public override string ToString()
        {
            base.ToString();
            return $"Student | Name = {Name}| Residence = {Residence}| Email ={Email}";
        }

        public static void StuFunc(List<Student> stLi)
        {
            Console.WriteLine("Student Menu\n" +
                "Press 1 to list aa students\n" +
                "Press 2 to add a new student\n" +
                "Press 3 to update an existing student\n" +
                "Press 4 to delete a student" +
                "Press 5 to return to main menu"
               );

            string StuChoice = Console.ReadLine();


            while (StuChoice != "0")
            {

                switch (StuChoice)
                {
                    case "1":
                        showAll<Student>(stLi);
                            break;
                   
                    case "2":
                        Console.WriteLine("Please enter in new details in the following order: Name,Residence and email.\n");
                        Console.WriteLine("Name:");
                        string addName = Console.ReadLine();
                        Console.WriteLine("Address one,two and City");
                        string addAddress1 = Console.ReadLine();
                        string addAddress2 = Console.ReadLine();
                        string addCity = Console.ReadLine();
                        Console.WriteLine("Email:");
                        string addEmail = Console.ReadLine();
                        Add<Student>(stLi,new Student(addName,new Address(addAddress1,addAddress2,addCity),addEmail));
                        Console.WriteLine("New List\n");
                        showAll<Student>(stLi);
                           
                        break;


                    case "3":
                                       
                Console.WriteLine("Enter the name and email of the student youd like to update\n")
                Console.WriteLine("Name");
                     string upName = Console.ReadLine();
                Console.WriteLine("")
                
                }





 Console.WriteLine("Please enter a number that corsponds to Students position on the list:");









            }
        }

    

    public static void Update(String name, String email, List<Student> list)
    {

        var stu = from s in list
                  where s.Name == name && s.Email == email
                  select s;
        Console.WriteLine("Please enter in new details in the following order: Name,Residence and email.\n");
        Console.WriteLine("Name:");
        string newName = Console.ReadLine();
        Console.WriteLine("Address one,two and City");
        string Address1 = Console.ReadLine();
        string Address2 = Console.ReadLine();
        string City = Console.ReadLine();
        Console.WriteLine("Email:");
        string newEmail = Console.ReadLine();
        stu.ToList();
        foreach (Student st in stu) {

            st.Email = newEmail;
            st.Residence.Address1 = Address1;
            st.Residence.Address2 = Address2;
            st.Residence.City = City;
            st.Name = newName;

        }
        // Student student = new Student(name, new Address(Address1, Address2, City), email);
        //list.Add(student);


        Console.WriteLine("New Student information:");












    }

}



































        }














    



