using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;


//Class used to contain methods to improve readibilty 
namespace AM_A1
{
    class Modify
    {


        public static void
        
            //Generic Method to show all the list
            showAll<T>(List<T> GenList)
        {
            var Per = from Show in GenList select Show;

            Per.ToList();
            foreach (T s in Per)
                Console.WriteLine(s);
        }

        //Generic Method to Add Objects to List
        public static void
         Add<T>(List<T> GenList, T inp)
        {
            GenList.Add(inp);
        }

        }




    }

