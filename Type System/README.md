# General Structure of a C# Program
A namespace contains types such as classes, structs, interfaces, enumerations, and delegates, or other namespaces.

Classes - The class is a template for objects. A class defines object properties including a valid range of values, and a default value. A class also describes object behavior.

Structs - A struct type is a value type that is typically used to encapsulate small groups of related variables.

Namespaces - The namespace keyword is used to declare a scope. This namespace scope lets you organize code and gives you a way to create globally unique types.

Interfaces - An interface contains only the signatures of methods, properties, events, or indexers. A class or struct that implements the interface must implement the members of the interface that are specified in the interface definition.

Enums - An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type.

Delegates - A delegate is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to function pointers in C and C++.

## Main() and command-line arguments
The Main method is the entry point of a C# application. When the application is started, the Main method is the first method that is invoked.
```csharp
class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
    }
}
```

The following list shows the most common Main declarations:
```csharp
static void Main() { }
static int Main() { }
static void Main(string[] args) { }
static int Main(string[] args) { }
static async Task Main() { }
static async Task<int> Main() { }
static async Task Main(string[] args) { }
static async Task<int> Main(string[] args) { }
```
### Top-level statements - programs without Main methods
Top-level statements allows you to write executable code directly at the root of a file, eliminating the need for wrapping your code in a class or method. This means you can create programs without the ceremony of a Program class and a Main method.

Traditional Main Method
```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```
Top-Level Statements
```csharp
using System;
Console.WriteLine("Hello, World!");
```
## Type system
is a foundational aspect of the language, ensuring type safety, consistency, and interoperability. It defines how data is classified and manipulated, enforcing rules on how values of various types interact. C# uses a strongly typed, statically typed, and unified type system.
### Specifying types in variable declarations
```csharp
// Declaration only:
float temperature;
string name;
MyClass myClass;

// Declaration with initializers (four examples):
char firstLetter = 'C';
var limit = 3;
int[] source = [0, 1, 2, 3, 4, 5];
var query = from item in source
            where item <= limit
            select item;
```
## Namespaces
A namespace is a collection of classes, interfaces, structs, enums, and delegates. It is a way to organize your code and prevent name collisions with other types. The .NET class library is a collection of namespaces, each designed for a specific purpose. For example, the System namespace contains classes that define commonly used value and reference data types, events, and event handlers.
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
```
### Common Namespaces in C#
System: Provides basic functionality like console input/output, data types, etc.
System.Collections.Generic: Contains generic collections like List<T> and Dictionary<TKey, TValue>.
System.IO: Handles file and stream input/output.
System.Net: Deals with network operations.
System.Linq: Supports querying data using LINQ.

# Introduction to classes
A class is a blueprint for creating objects (a particular data structure), providing initial values for state (member variables or fields), and implementations of behavior (member functions or methods). The class is a template for creating objects. A class defines object properties including a valid range of values, and a default value. A class also describes object behavior.
```csharp
class MyClass
{
    // Class members
    string color = "red";        // field
    int maxSpeed = 200;          // field
    public void fullThrottle()   // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
}
```
# Introduction to record types in C#
A record is a reference type that provides built-in functionality for encapsulating data. It is a type that groups fields of data, similar to a struct type, but with added capabilities. Records are immutable by default, meaning that the data they contain cannot be changed after the record is created. Records are ideal for representing data that is read-only or that is changed infrequently.
```csharp
public record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
}
```
# Interfaces - define behavior for multiple types
An interface in C# is a contract that defines a set of methods, properties, events, or indexers without implementing them. Classes or structs that implement the interface must provide a concrete implementation for all its members. This ensures a consistent behavior across multiple types.
```csharp
interface IAnimal
{
    void AnimalSound(); // interface method (does not have a body)
}
```
# Generic classes and methods
Generics allow you to define classes, interfaces, and methods that operate on data types without specifying the data type until the class, interface, or method is instantiated or called. Generics provide flexibility by allowing you to design classes, interfaces, and methods that defer the specification of one or more types until the class, interface, or method is declared and instantiated by client code.
```csharp
public class GenericList<T>
{
    void Add(T input) { }
}
```
# Anonymous types
An anonymous type is a simple way to create an object with read-only properties. The type name is generated by the compiler and is not available at the source code level. Anonymous types are useful when you want to encapsulate a set of read-only properties into a single object without having to define a type explicitly.
```csharp
var v = new { Amount = 108, Message = "Hello" };

// Rest the mouse pointer over v.Amount and v.Message in the following
// statement to verify that their inferred types are int and string.
Console.WriteLine(v.Amount + v.Message);
```
