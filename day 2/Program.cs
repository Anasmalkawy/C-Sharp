using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting type , use conversion method ");

            int num = 10;
            double result2 = num; // Implicit conversion from int to double
            Console.WriteLine(result2); // Output: 10.0

            double num1 = 9.78;
            int result3 = (int)num; // Explicit conversion from double to int
            Console.WriteLine(result2); // Output: 9 (decimal part is lost)

            string str = "123";
            int num4 = Convert.ToInt32(str); // Converts string to int
            Console.WriteLine(num); // Output: 123

            string str3 = "45.67";
            double num0 = double.Parse(str); // Converts string to double
            Console.WriteLine(num); // Output: 45.67



            Console.WriteLine("string , concatenation , TOUpper , ToLower, Adding number and string");


            string firstName = "John";
            string lastName = "Doe";
            string fullName0 = firstName + " " + lastName; // "John Doe"


            string fullName1 = string.Concat(firstName, " ", lastName); // "John Doe"


            string original0 = "hello";
            string upperCase = original0.ToUpper(); // "HELLO"

            string original1 = "HELLO";
            string lowerCase = original1.ToLower(); // "hello"


            string numberAsString = "10";
            string result = numberAsString + "20"; // result is "1020"

            

            Console.WriteLine("String interpotation , access string , special character ");

            string author = "Mahesh Chand";
            string message = $"Hello, {author}!";
            Console.WriteLine(message); // Outputs: Hello, Mahesh Chand!

            decimal price = 45.95m;
            string formattedMessage = $"The price is {price:C}."; // Formats as currency
            Console.WriteLine(formattedMessage); // Outputs: The price is $45.95


            string productName = "Widget";
            string message1 = $"The product is called \"{productName}\".";
            Console.WriteLine(message); // Outputs: The product is called "Widget".


            string example = $"This will display a brace: {{ }}";
            Console.WriteLine(example); // Outputs: This will display a brace: { }


            string path = @"C:\Users\Jane\Documents";
            string message2 = $@"The file is located at {path}.";
            Console.WriteLine(message); // Outputs: The file is located at C:\Users\Jane\Documents.


            Console.WriteLine("Arithematic , logical , comparison operations ");

            bool condition1 = true;
            bool condition2 = false;

            // AND operator
            Console.WriteLine(condition1 && condition2); // Outputs: False

            // OR operator
            Console.WriteLine(condition1 || condition2); // Outputs: True

            // NOT operator
            Console.WriteLine(!condition1); // Outputs: False


            int x = 15;
            int y = 10;

            Console.WriteLine(x > y);   // Outputs: True
            Console.WriteLine(x < y);   // Outputs: False
            Console.WriteLine(x == y);  // Outputs: False

        }
    }
}
