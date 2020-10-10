using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//Class used to contain methods to improve readibilty
namespace AM_A1
{
    class Modify
    {


        public static void
        showAll<T>(List<T> GenList)
        {
            var Per = from Show in GenList select Show;

            Per.ToList();
            foreach (T s in Per)
                Console.WriteLine(s);

        }



        public static void
         Add<T>(List<T> GenList, T inp)
        {
            GenList.Add(inp);
        }




    public static void Del<T>(List<T> GenList, int inp ){

            GenList.RemoveAt(inp+1);
        
        
        }



















    }
}
