
//-user input(read / write)

//3 -


//using System;

//namespace Test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter Name: ");
//            string text = Console.ReadLine();
//            Console.WriteLine("You Name: " + text);
//        }
//    }
//}


//1-C# variables 



//using System;

//namespace InputProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//int age = 25;
//string name = "Alice";


//int age;
//age = 25; // Initialization happens later


//int x;
//int y;
//int z;

//int x = 1, y = 2, z = 3;
//int a, s, d;


//int number = 100;          // Integer
//float rate = 10.5f;       // Floating-point number
//char code = 'A';      // Character
//bool isValid = true;      // Boolean value
//string name = "Steve";    // String

//Console.WriteLine(name);

//        }
//    }
//}











//array 
//2-


//using System;

//namespace InputProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] intArray;

//            // Declare an array of strings
//            string[] stringArray;


//            ////////////////////


//            // Initialize with values
//            int[] intArray = { 1, 2, 3, 4, 5 };

//            // Alternatively, you can use shorthand
//            string[] stringArray = { "apple", "banana", "cherry" };

//            ////////////////////


//            // Accessing elements in a single-dimensional array

//            int firstElement = intArray[0]; // Gets the first element (1)
//            string secondElement = stringArray[1]; // Gets the second element ("banana")

//            // Change the first element of intArray
//            intArray[0] = 10; // Now intArray is {10, 2, 3, 4, 5}

//            Console.WriteLine(secondElement);


//            int[] numbers = { 1, 2, 3 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i]);
//}

//Console.WriteLine("  ");
//int first = numbers[0];
//Console.WriteLine(first);




//numbers[0] = 5;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i]);
//}

//        }
//    }
//}



using System;

namespace InputProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           
            Console.WriteLine(name);

            ////
            ///

            int a = 4;
            string b = "aaaa";
            float c = 4.4f;
            double d = 4.4533;
            char j = 'f';
            bool aa = true;

            /////
            ///

            string[] car = { "audi", "bmw", "toyota" };
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            ///////
            ///

            string fname=Console.ReadLine();
            string lname = Console.ReadLine();
            string age = Console.ReadLine();

            Console.Write(fname, lname, age);
            /////
            ///
            int[] random = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var i in random)
            {
                Console.Write(i);
            }
            /////////






        }
    }
}