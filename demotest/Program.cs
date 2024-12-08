


// //grading system

// using System;
// namespace grading{
//     class Program{
//         static void Main(string[] args)
//         {
//             int grade;
//             Console.Write("Enter your marks: ");
//             grade = Convert.ToInt32(Console.ReadLine()); //converts the string to integer

//             if(grade <= 100 && grade >= 70)
//             {
//                 Console.WriteLine("A");
//             }
//             else if(grade < 70 && grade >= 60) {
//                 Console.WriteLine("B");
//             }
//             else if(grade < 60 && grade >= 50) {
//                 Console.WriteLine("C");
//             }
//             else if(grade < 50 && grade >= 40) {
//                 Console.WriteLine("D");
//             }
//             else
//             {
//                 Console.WriteLine("you failed!!!");
//             }
//         }
//     }
// }


// create a right angel triangle
// using System;
// namespace rightangle{
//     class Program{
//         static void Main(string[] args)
//         {
//             int i, j, n; //declaring the variables
//             // Console.Write("Enter the number of rows: ");
//             // n = Convert.ToInt32(Console.ReadLine());
//             n = 4;
//             for(i = 1; i <= n; i++) //loop for the rows
//             {
//                 for(j = 1; j <= i; j++) //loop for the columns
//                 {
//                     Console.Write("*");//prints the star
//                 }
//                 Console.WriteLine();//moves to the next line
//             }
//         }
//     }
// }

// switch case for days

// int days = 12;

//  switch(days)
//  {
//     case 1: 
//     Console.Write("Monday");
//     break;
//     case 2: 
//     Console.Write("Tue");
//     break;
//     case 3:  
//     Console.Write("Wed");
//     break;
//     case 4:
//     Console.Write("Thur");
//     break;
//     case 5: 
//     Console.Write("Fri");
//     break;
    
//     default:
//     Console.WriteLine("Error");
//     break;
//  }

 // switch statement grading system
 using System;

class GradingSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score (0-100): ");
        int score = int.Parse(Console.ReadLine());

        string grade;
        
        switch (score / 10) // Divide the score by 10 to group it into ranges (0-10, 10-20, etc.)
        {
            case 10: // Perfect score (100)
            case 9:  // 90-99
                grade = "A";
                break;
            case 8:  // 80-89
                grade = "B";
                break;
            case 7:  // 70-79
                grade = "C";
                break;
            case 6:  // 60-69
                grade = "D";
                break;
            default: // Scores below 60
                grade = "F";
                break;
        }

        Console.WriteLine("Your grade is: ${grade}");
    }
}
