//Add two numeric values
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//Mix data types to force implicit type conversions
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//Attempt a more advanced case of adding numbers and concatenating strings
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

//Add parentheses to clarify your intention to the compiler
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

//-------------------------------Perform basic math operations-----------------------------------------
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//Add code to perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

//Add code to perform division using literal decimal data
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

//Write code to determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Write code to exercise C#'s order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//-------------------------------------Increment and decrement-----------------------------------------
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

//Write code to increment and decrement a value
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

//Use the increment operator before and after the value
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

//========================convert Fahrenheit to Celsius challenge=================
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

//================================C# Booleans===================================
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

//Boolean Expression
int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns True, because 10 is higher than 9

//Real Life Example of boolean expression - voting system
int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge) 
{
  Console.WriteLine("Old enough to vote!");
} 
else 
{
  Console.WriteLine("Not old enough to vote.");
}

//==================================Math methods ==================================
//Math.Max(x,y) =>  find the highest value of x and y
Math.Max(5, 10);

//Math.Min(x,y)
Math.Min(x,y)

//Math.Sqrt(x) => method returns the square root of x
Math.Sqrt(64);

//Math.Abs(x) => method returns the absolute (positive) value of x
Math.Abs(-4.7);

//Math.Round() => rounds a number to the nearest whole number
Math.Round(9.99);



using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Math.Max(5, 10));  
     }
  }
}

























