# C# Data Types and Variables

## Basic Data Types in C#
- **int**: Stores integers (whole numbers), without decimals, such as `123` or `-123`.
- **double**: Stores floating-point numbers, with decimals, such as `19.99` or `-19.99`.
- **char**: Stores single characters, such as `'a'` or `'B'`. Char values are surrounded by single quotes.
- **string**: Stores text, such as `"Hello World"`. String values are surrounded by double quotes.
- **bool**: Stores values with two states: `true` or `false`.
- **long**: can store whole numbers from -9223372036854775808 to 9223372036854775807. This is used when int is not large enough to store the value. Note that you should end the value with an "L":
example
```csharp 
long myNum = 15000000000L;
Console.WriteLine(myNum);
```

-**Floating Point Types**: You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.
The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles:
#### Float Example
```csharp 
float myNum = 5.75F;
Console.WriteLine(myNum);
```
```csharp 
Double Example
double myNum = 19.99D;
Console.WriteLine(myNum);
```


-**Scientific Numbers**:
A floating point number can also be a scientific number with an "e" to indicate the power of 10:
```csharp 
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);
```

## Syntax for Variable Declaration
```csharp
type variableName = value;
```

### Example
```csharp 
int myNum = 5;
Console.WriteLine(myNum); // Outputs 5
```
### Declaring Variables Without Assigning a Value:
You can also declare a variable without assigning the value immediately, and assign the value later:
```csharp  
int myNum;
myNum = 15;
Console.WriteLine(myNum); // Outputs 15
```
### Case-Sensitivity in C#
C# is case-sensitive, meaning that the variables MyNum, mynum, and myNUM are all different variables.

## Overwriting Variable Values
When you assign a new value to an existing variable, it overwrites the previous value:
```csharp 
int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum); // Outputs 20
```
##              Other Data Types and Examples
Here are more examples of other data types:
```csharp 
int myNum = 5;             // Integer
double myDoubleNum = 5.99D; // Double
char myLetter = 'D';       // Character
bool myBool = true;        // Boolean
string myText = "Hello";   // String
```
##                                                          Constants
If you want to prevent a variable from being changed, use the const keyword:

```csharp 
const int myNum = 15;
myNum = 20; // Error: Cannot assign to 'myNum' because it is a constant
Displaying Variables
You can display variables in a string using concatenation:
```
```csharp 
string name = "John";
Console.WriteLine("Hi " + name); // Outputs "Hi John"
```
##                                                      C# Type Casting
Type casting is when you assign a value of one data type to another type.

#### Implicit Casting (automatically) - 
converting a smaller type to a larger type size
char -> int -> long -> float -> double

#### Example
```csharp 
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double
Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9
```

### Explicit Casting (manually) - 
converting a larger type to a smaller size type
double -> float -> long -> int -> char

#### Example
```csharp 
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
```
##                                          Get User Input
#### Example
```csharp 
// Type your username and press enter
Console.WriteLine("Enter username:");
// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();
// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);
```
##                                     User Input and Numbers
```csharp 
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
```

## C# Conditions and If Statements
##### The if Statement
Use the if statement to specify a block of C# code to be executed if a condition is True.
```csharp
if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}
```
##### The else Statement
Use the else statement to specify a block of code to be executed if the condition is False.
```csharp
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
```
#### The else if Statement
Use the else if statement to specify a new condition if the first condition is False.
```csharp
int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
```
#### If...Else (Ternary Operator)
```csharp
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
```
#### C# Switch Statements
Use the switch statement to select one of many code blocks to be executed.
```csharp
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)
```
###### The break Keyword
When C# reaches a break keyword, it breaks out of the switch block.

This will stop the execution of more code and case testing inside the block.
###### The default Keyword
The default keyword is optional and specifies some code to run if there is no case match:

## C# While Loop
### Loops
Loops can execute a block of code as long as a specified condition is reached.
Loops are handy because they save time, reduce errors, and they make code more readable.

### C# While Loop
The while loop loops through a block of code as long as a specified condition is True:
```csharp
int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}
```
## C# For Loop
When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:

```csharp
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}
```
## Nested Loops
It is also possible to place a loop inside another loop. This is called a nested loop.
The "inner loop" will be executed one time for each iteration of the "outer loop":
```csharp
// Outer loop
for (int i = 1; i <= 2; ++i) 
{
  Console.WriteLine("Outer: " + i);  // Executes 2 times

  // Inner loop
  for (int j = 1; j <= 3; j++) 
  {
    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
  }
}
```
## C# Foreach Loop
There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data sets):
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
```
## C# Break and Continue
The break statement can also be used to jump out of a loop.
```csharp
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break;
  }
  Console.WriteLine(i);
}
```
## C# Arrays
Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs Volvo
```
### Array Length
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4
```
### Other Ways to Create an Array
```csharp
// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```
### Loop Through an Array
```csharp 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}
```
### The foreach Loop
```csharp 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
```

### Sort an Array
There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
```csharp 
// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
```
### System.Linq Namespace
Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
```csharp
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}
```
## Multidimensional Arrays
A multidimensional array is basically an array of arrays.

#### Two-Dimensional Arrays
To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the square brackets:
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
```
#### Access Elements of a 2D Array
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine(numbers[0, 2]);  // Outputs 2
```
### Change Elements of a 2D Array
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
numbers[0, 0] = 5;  // Change value to 5
Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1
```
### Loop Through a 2D Array
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
```
## C# Methods
A method is a block of code which only runs when it is called.
You can pass data, known as parameters, into a method.

### Create a method inside the Program class:
```csharp
class Program
{
  static void MyMethod() 
  {
    // code to be executed
  }
}
```

**MyMethod()** is the name of the method
**static** means that the method belongs to the Program class and not an object of the Program class. 
**void** means that this method does not have a return value. You will learn more about return values later in this chapter

### Call a Method
Inside Main(), call the myMethod() method:
```csharp
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
}

// Outputs "I just got executed!"
```

### other example
```csharp
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
  MyMethod();
  MyMethod();
}

// I just got executed!
// I just got executed!
// I just got executed!
```
## C# Method Parameters and Arguments
```csharp
static void MyMethod(string fname) 
{
  Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
  MyMethod("Liam");
  MyMethod("Jenny");
  MyMethod("Anja");
}

// Liam Refsnes
// Jenny Refsnes
// Anja Refsnes
```

### Multiple params
```csharp
static void MyMethod(string fname, int age) 
{
  Console.WriteLine(fname + " is " + age);
}

static void Main(string[] args)
{
  MyMethod("Liam", 5);
  MyMethod("Jenny", 8);
  MyMethod("Anja", 31);
}

// Liam is 5
// Jenny is 8
// Anja is 31
```

### Default Parameter Value
You can also use a default parameter value, by using the equals sign (=).
If we call the method without an argument, it uses the default value ("Norway"):

```csharp
static void MyMethod(string country = "Norway") 
{
  Console.WriteLine(country);
}

static void Main(string[] args)
{
  MyMethod("Sweden");
  MyMethod("India");
  MyMethod();
  MyMethod("USA");
}

// Sweden
// India
// Norway
// USA
```

### Return Values
```csharp
static int MyMethod(int x) 
{
  return 5 + x;
}

static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));
}

// Outputs 8 (5 + 3)
```
### another example
```csharp
static int MyMethod(int x, int y) 
{
  return x + y;
}

static void Main(string[] args)
{
  Console.WriteLine(MyMethod(5, 3));
}

// Outputs 8 (5 + 3)
```
### Named Arguments
It is also possible to send arguments with the key: value syntax.
That way, the order of the arguments does not matter:

```csharp
static void MyMethod(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}

static void Main(string[] args)
{
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}

// The youngest child is: John
```

### Method Overloading
With method overloading, multiple methods can have the same name with different parameters:
```csharp
static int PlusMethodInt(int x, int y)
{
  return x + y;
}

static double PlusMethodDouble(double x, double y)
{
  return x + y;
}

static void Main(string[] args)
{
  int myNum1 = PlusMethodInt(8, 5);
  double myNum2 = PlusMethodDouble(4.3, 6.26);
  Console.WriteLine("Int: " + myNum1);
  Console.WriteLine("Double: " + myNum2);
}
```
### C# - What is OOP?














