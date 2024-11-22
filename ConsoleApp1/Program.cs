// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
 /*
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Hello World!");
            // Console.Write("test ");
        }
    }
}*/
// // data types
// using System;
// namespace myApp
// {
//     class dataTypes
//     {
//         static void Main(string[]args)
//         {
//             int myNum = 5;               // Integer (whole number)
//             double myDoubleNum = 5.99D;  // Floating point number
//             char myLetter = 'D';         // Character
//             bool myBool = true;          // Boolean
//             string myText = "Hello";     // String
//             Console.WriteLine(myNum);
//             Console.WriteLine(myDoubleNum);
//             Console.WriteLine(myLetter);
//             Console.WriteLine(myBool);
//             Console.WriteLine(myText);
//         }
//     }
// }
//constants
using System;
namespace myConstant{
    class Constant{
        static void  Main(string[]args){
            // const string myName = "John";
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            int x,y,z;
            x = 5;
            y = 6;
            z = x + y;
            Console.WriteLine(z);
            // Console.WriteLine(myName);
            // myName = "Doe"; // error
            string promptUser = "Enter your name: ";
            Console.WriteLine(promptUser);
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
        }
    }
}
