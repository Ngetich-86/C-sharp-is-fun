//============================data types in C#
int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false

// Syntax
type variableName = value;
// Example
int myNum = 5;
Console.WriteLine(myNum); // Outputs 5

// You can also declare a variable without assigning the value, and assign the value later:
int myNum;
myNum = 15;
Console.WriteLine(myNum);

// The C# language is case-sensitive: The variables MyNum, mynum, and myNUM are all different variables.
// #======> Note that if you assign a new value to an existing variable, it will overwrite the previous value:
int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);

// Other Types
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

// Constants =>If you don't want others to overwrite existing values, you can add the const keyword in front of the variable type.
const int myNum = 15;
myNum = 20; // error

// Display Variables
string name = "john"
Console.WriteLine("hi" + name)

//==================================================================================
Declare Many Variables
To declare more than one variable of the same type, use a comma-separated list:

int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

// C# Identifiers
All C# variables must be identified with unique names.

// Good
int minutesPerHour = 60;

// OK, but not so easy to understand what m actually is
int m = 60;