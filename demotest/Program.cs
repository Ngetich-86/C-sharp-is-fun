


//grading system

using System;
namespace grading{
    class Program{
        static void Main(string[] args)
        {
            int grade;
            Console.Write("Enter your marks: ");
            grade = Convert.ToInt32(Console.ReadLine()); //converts the string to integer

            if(grade <= 100 && grade >= 70)
            {
                Console.WriteLine("A");
            }
            else if(grade < 70 && grade >= 60) {
                Console.WriteLine("B");
            }
            else if(grade < 60 && grade >= 50) {
                Console.WriteLine("C");
            }
            else if(grade < 50 && grade >= 40) {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("you failed!!!");
            }
        }
    }
}
