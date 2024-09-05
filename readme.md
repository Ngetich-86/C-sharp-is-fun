# C# Data Types and Variables

## Basic Data Types in C#
- **int**: Stores integers (whole numbers), without decimals, such as `123` or `-123`.
- **double**: Stores floating-point numbers, with decimals, such as `19.99` or `-19.99`.
- **char**: Stores single characters, such as `'a'` or `'B'`. Char values are surrounded by single quotes.
- **string**: Stores text, such as `"Hello World"`. String values are surrounded by double quotes.
- **bool**: Stores values with two states: `true` or `false`.
- **long**: can store whole numbers from -9223372036854775808 to 9223372036854775807. This is used when int is not large enough to store the value. Note that you should end the value with an "L":
example

long myNum = 15000000000L;
Console.WriteLine(myNum);

-**Floating Point Types**: You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.
# The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles:
================Float Example
float myNum = 5.75F;
Console.WriteLine(myNum);
===================
Double Example
double myNum = 19.99D;
Console.WriteLine(myNum);


-**Scientific Numbers**:
A floating point number can also be a scientific number with an "e" to indicate the power of 10:
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);


## Syntax for Variable Declaration
```csharp
type variableName = value;


Example
int myNum = 5;
Console.WriteLine(myNum); // Outputs 5

Declaring Variables Without Assigning a Value:
You can also declare a variable without assigning the value immediately, and assign the value later:
int myNum;
myNum = 15;
Console.WriteLine(myNum); // Outputs 15

Case-Sensitivity in C#
C# is case-sensitive, meaning that the variables MyNum, mynum, and myNUM are all different variables.

Overwriting Variable Values
When you assign a new value to an existing variable, it overwrites the previous value:

int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum); // Outputs 20

Other Data Types and Examples
Here are more examples of other data types:

int myNum = 5;             // Integer
double myDoubleNum = 5.99D; // Double
char myLetter = 'D';       // Character
bool myBool = true;        // Boolean
string myText = "Hello";   // String

Constants
If you want to prevent a variable from being changed, use the const keyword:


const int myNum = 15;
myNum = 20; // Error: Cannot assign to 'myNum' because it is a constant
Displaying Variables
You can display variables in a string using concatenation:

string name = "John";
Console.WriteLine("Hi " + name); // Outputs "Hi John"


















