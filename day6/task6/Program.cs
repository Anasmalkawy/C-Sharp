using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        class Calculator
        {
            public void ss(int i, int s)
            {
                Console.WriteLine(i+s);
            }
            public void ss(int i, int s, int a)
            {
                Console.WriteLine(i + s + a);
            }
            public void ss(double i, double s)
            {
                Console.WriteLine(i + s );
            }

        }


        ////------------------------------


        public class Shape
        {
            public virtual void aa()
            {
                Console.WriteLine("hi");
            }
        }
        public class circle:Shape
            {
                public override void aa()
                {
                    Console.WriteLine("hi 1");
                }
            }
        public class Rectangle : Shape
            {
                public override void aa()
                {
                    Console.WriteLine("hi 2");
                }
            }
        




        ////-----------------------
        public abstract class Animal
        {
             public abstract void sound();
            public void sleep()
            {
                Console.WriteLine("Animal is sleeping");
            }

        }


        public  class cat : Animal
        {
            public  override void sound()
            {
                Console.WriteLine("cat sound ");
            }

        }



        public class dog : Animal
        {
            public override void sound()
            {
                Console.WriteLine("dog sound ");
            }

        }



        ////--------------------------
        ///

        interface Playable
        {
             void play();
        }
        public class Guitar: Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the guitar");
            }
        }
        public class Piano :Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the Piano");
            }
        }


        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.ss(3,4);
            calculator.ss(3, 4);
            calculator.ss(3, 4);
            //=---------------
            Shape ob = new Shape();
            circle ob1 = new circle();
            Rectangle ob2 = new Rectangle();
            ob.aa();
            ob1.aa();
            ob2.aa();
            //----------------
            Animal cat = new cat();
            Animal dog = new dog();
            cat.sound();
            dog.sound();
            cat.sleep();
            //-------------------
            Guitar guitar = new Guitar();   
            guitar.play();
            Piano piano = new Piano();
            piano.play();



        }
    }
}
