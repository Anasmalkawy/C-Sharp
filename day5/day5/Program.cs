
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prepare
{
    internal class Program
    {
       sealed public class carName 
        {
           protected string name2;
        }

        public class carcolor : carName
        {
            protected string name = "toyota";
             public void Vehicle()
            {
                Console.WriteLine(name2= "BMW");
            }

        }



        public class modelcar:carName
        {
            public int model = 1999;
        }


        static void Main(string[] args)
        {
            carcolor car = new carcolor();
            car.Vehicle();
          

        }
    }
}
