// class Student
// {
//     public string Name = "Victory Ojo";
//     public int Age = 20;

//     public bool married = false;

//     static void Main(string[] args) // Main method - the entry point of the program
//     {
//         // Create an object of the Cars class
//         Cars myCar = new Cars();
//         Console.WriteLine("Car color: " + myCar.color);
//         Console.WriteLine("Car model: " + myCar.model);
//         Console.WriteLine("Car year: " + myCar.year);
//         Console.WriteLine("Car owner: " + myCar.owner);
//         myCar.Start(); // Call the Start method

//         // Create an object of the Student class
//     {
//         Student myStudent = new Student();// Create an object of the Student class
//         Student myStudent2 = new Student();// Create another object of the Student class
//         Console.WriteLine("Name: " + myStudent.Name + ", Age: " + myStudent.Age);
//         Console.WriteLine("Married: " + myStudent2.married);
//     }
// }

//     //class members - class members are the variables and methods that belong to a class
// public class Cars
// {
//     //class members
//     public string color = "red";
//     public string model = "Toyota";
//     public int year = 2020;
//     public string owner = "Victory Ojo";
//     //  public void Start() // method - a method is a function that belongs to a class

//     static void Main(string[] args)
//     {
//     Cars myNewCar = new Cars();
//     myNewCar.Start(); // Call the Start method
//         // Console.WriteLine("The car has started");
//     }
// }


// using System;

// public class Schools
// {
//     string name;
//     int numberOfStudents;
//     string location;
//     string principal;
//     int numberOfTeachers;

//     static void Main(string[] args)
//     {
//         Schools mySchool = new Schools();
//         mySchool.name = "Victory High School";
//         mySchool.numberOfStudents = 500;
//         mySchool.location = "Lagos, Nigeria";
//         mySchool.principal = "Mr. Smith";
//         mySchool.numberOfTeachers = 50;

//         Schools secondarySchool = new Schools();
//         secondarySchool.name = "Keisha Secondary School";

//         Schools primarySchool = new Schools();
//         primarySchool.name = "Bravo  Primary School";
//         // Console.WriteLine("School Name: " + mySchool.name);
//         // Console.WriteLine("Number of Students: " + mySchool.numberOfStudents);
//         // Console.WriteLine("Location: " + mySchool.location);
//         // Console.WriteLine("Principal: " + mySchool.principal);
//         // Console.WriteLine("Number of Teachers: " + mySchool.numberOfTeachers);
//         // Console.WriteLine("Welcome to the school management system");

//         // Console.WriteLine(secondarySchool.name + " is a secondary school.");
//         // Console.WriteLine(primarySchool.name + " is a primary school.");
//     }
// }

//=================================Constructors are special methods that are called when an object is created. They are used to initialize the object's properties or fields.

// class Planets
// {
//     public string Name { get; set; } // Property for the planet's name
//     public double Mass { get; set; } // Property for the planet's mass in kg
//     public double Radius { get; set; } // Property for the planet's radius in km
//     public Planets(string name, double mass, double radius)// Constructor with parameters
//     {
//         Name = name;
//         Mass = mass;
//         Radius = radius;
//     }
//     static void Main(string[] args)
//     {
//         Planets saturn = new Planets("Saturn", 5.683e26, 58232);
//         // Console.WriteLine("Planet Name: " + saturn.Name + ", Mass: " + saturn.Mass + " kg, Radius: " + saturn.Radius + " km");
//         Planets earth = new Planets("Earth", 5.972e24, 6371);
//         // Console.WriteLine("Planet Name: " + earth.Name + ", Mass: " + earth.Mass + " kg, Radius: " + earth.Radius + " km");
//     }
// }

//Access Modifiers: Access modifiers are keywords that define the visibility of a class, method, or variable. The most common access modifiers are public, private, protected, and internal.
// Public: The member is accessible from any other code in the same assembly or another assembly that references it.
// Private: The member is accessible only within the body of the class or struct in which it is declared.
// Protected: The member is accessible within its class and by derived class instances.
// Internal: The member is accessible within the same assembly, but not from another assembly.
// Static Members: Static members belong to the class itself rather than to any specific instance of the class. They can be accessed without creating an instance of the class.
// Static methods and properties are shared across all instances of the class.
// Static methods can be called without creating an instance of the class, and they can only access static members of the class.
// Constructors: Constructors are special methods that are called when an object is created. They are used to initialize the object's properties or fields

// class PrivateClass
// {
//     private string secret = "This is a private variable";

//     static void Main(string[] args)
//     {
//         PrivateClass myPrivateClass = new PrivateClass();
//         // Console.WriteLine(myPrivateClass.secret); // This line will cause an error because 'secret' is private and cannot be accessed outside the class.
//     }
// }
// lets now try accessing the private variable from outside the class
// class Program
// {
//     static void Main(string[] args)
//     {
//         PrivateClass myPrivateClass = new PrivateClass();
//         Console.WriteLine(myPrivateClass.secret); // This line will cause an error because 'secret' is private and cannot be accessed outside the class.
//         // To access the private variable, we can create a public method within the PrivateClass that returns the value of the private variable.
//     }
// }

//C# Properties (Get and Set) - Properties are a way to encapsulate fields in a class. They allow you to control how fields are accessed and modified. A property can have a getter (to retrieve the value) and a setter (to modify the value).

class School
{
    private string name;
    private int numberOfStudents;

    // Property for the name field
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for the numberOfStudents field
    public int NumberOfStudents
    {
        get { return numberOfStudents; }
        set { numberOfStudents = value; }
    }

    static void Main(string[] args)
    {
        School mySchool = new School();
        mySchool.Name = "Victory High School";
        mySchool.NumberOfStudents = 500;

        Console.WriteLine("School Name: " + mySchool.Name);
        Console.WriteLine("Number of Students: " + mySchool.NumberOfStudents);
    }
}

// inheritance - Inheritance is a fundamental concept in object-oriented programming that allows a class (called the derived class or child class) to inherit properties and methods from another class (called the base class or parent class). This promotes code reuse and establishes a hierarchical relationship between classes.

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal // Dog class inherits from Animal class
{
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Age = 3;
        myDog.Breed = "Golden Retriever";

        Console.WriteLine("Dog Name: " + myDog.Name);
        Console.WriteLine("Dog Age: " + myDog.Age);
        Console.WriteLine("Dog Breed: " + myDog.Breed);
        myDog.Speak(); // Calling the inherited method from Animal class
        myDog.Bark(); // Calling the method from Dog class
    }
}

// Polymorphism - Polymorphism is another fundamental concept in object-oriented programming that allows objects of different classes to be treated as objects of a common base class. It enables a single interface to represent different underlying forms (data types). In C#, polymorphism can be achieved through method overriding and interfaces.
//overriding - Method overriding is a feature that allows a derived class to provide a specific implementation of a method that is already defined in its base class. When a method in the base class is marked as virtual, it can be overridden in the derived class using the override keyword. This allows the derived class to change the behavior of the method while still maintaining the same method signature.
//interfaces - An interface in C# is a contract that defines a set of methods and properties that a class must implement. It allows for polymorphism by enabling different classes to implement the same interface, thus providing a common way to interact with those classes. Interfaces do not contain any implementation; they only define the signatures of methods and properties.
class Shape
{
    public virtual void Draw() // Virtual method that can be overridden
    {
        Console.WriteLine("Drawing a shape");
    }
}
class Circle : Shape // Circle class inherits from Shape class
{
    public override void Draw() // Overriding the Draw method
    {
        Console.WriteLine("Drawing a circle");
    }
}
class Square : Shape // Square class inherits from Shape class
{
    public override void Draw() // Overriding the Draw method
    {
        Console.WriteLine("Drawing a square");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Shape();
        myShape.Draw(); // Calls the base class method

        Shape myCircle = new Circle();
        myCircle.Draw(); // Calls the overridden method in Circle class

        Shape mySquare = new Square();
        mySquare.Draw(); // Calls the overridden method in Square class
    }
}

// abstraction - Abstraction is a fundamental concept in object-oriented programming that allows you to hide the complex implementation details of a class and expose only the essential features. It helps in reducing complexity and increasing the efficiency of code by focusing on what an object does rather than how it does it. In C#, abstraction can be achieved using abstract classes and interfaces.
abstract class Animal // Abstract class
{
    public abstract void Speak(); // Abstract method (does not have a body)
}
class Dog : Animal // Dog class inherits from Animal class
{
    public override void Speak() // Implementing the abstract method
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal // Cat class inherits from Animal class
{
    public override void Speak() // Implementing the abstract method
    {
        Console.WriteLine("Cat meows");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        myDog.Speak(); // Calls the Speak method in Dog class

        Animal myCat = new Cat();
        myCat.Speak(); // Calls the Speak method in Cat class
    }
}

// encapsulation - Encapsulation is a fundamental concept in object-oriented programming that refers to the bundling of data (attributes) and methods (functions) that operate on that data into a single unit called a class. It restricts direct access to some of an object's components, which can prevent the accidental modification of data. In C#, encapsulation is achieved using access modifiers (public, private, protected, internal) to control the visibility of class members.
class BankAccount
{
    private string accountNumber; // Private field
    private decimal balance; // Private field

    public BankAccount(string accountNumber, decimal initialBalance) // Constructor
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount) // Public method to deposit money
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive");
        }
    }

    public void Withdraw(decimal amount) // Public method to withdraw money
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrew: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid withdrawal amount");
        }
    }

    public decimal GetBalance() // Public method to get the current balance
    {
        return balance;
    }
}

// interfaces - An interface in C# is a contract that defines a set of methods and properties that a class must implement. It allows for polymorphism by enabling different classes to implement the same interface, thus providing a common way to interact with those classes. Interfaces do not contain any implementation; they only define the signatures of methods and properties.
interface IShape // Interface defining a contract for shapes
{
    void Draw(); // Method signature for drawing a shape
}
class Circle : IShape // Circle class implements IShape interface
{
    public void Draw() // Implementing the Draw method
    {
        Console.WriteLine("Drawing a circle");
    }
}
class Square : IShape // Square class implements IShape interface
{
    public void Draw() // Implementing the Draw method
    {
        Console.WriteLine("Drawing a square");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IShape myCircle = new Circle();
        myCircle.Draw(); // Calls the Draw method in Circle class

        IShape mySquare = new Square();
        mySquare.Draw(); // Calls the Draw method in Square class
    }
}

// Generics - Generics in C# allow you to define classes, methods, and interfaces with a placeholder for the data type. This enables you to create reusable code that can work with any data type while maintaining type safety. Generics are particularly useful for collections, where you want to store and manipulate objects of various types without losing type information.
using System;
using System.Collections.Generic;
class GenericList<T> // Generic class with a type parameter T
{
    private List<T> items = new List<T>(); // List to store items of type T

    public void Add(T item) // Method to add an item
    {
        items.Add(item);
    }

    public void Display() // Method to display items
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        GenericList<int> intList = new GenericList<int>(); // Creating a generic list for integers
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        Console.WriteLine("Integer List:");
        intList.Display(); // Displaying integer list

        GenericList<string> stringList = new GenericList<string>(); // Creating a generic list for strings
        stringList.Add("Hello");
        stringList.Add("World");
        Console.WriteLine("String List:");
        stringList.Display(); // Displaying string list
    }
}

// Exception Handling - Exception handling in C# is a mechanism that allows you to handle runtime errors gracefully without crashing the program. It involves using try, catch, and finally blocks to catch exceptions and take appropriate actions. This helps in maintaining the stability of the application and providing meaningful error messages to users.
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException ex) // Catching format exceptions
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception ex) // Catching any other exceptions
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally // Finally block executes regardless of whether an exception occurred or not
        {
            Console.WriteLine("Thank you for using the program.");
        }
    }
}
// Enums - Enums (enumerations) in C# are a special data type that allows you to define a set of named constants. They provide a way to group related values together, making your code more readable and maintainable. Enums can be used to represent a collection of related values, such as days of the week, months of the year, or status codes.
using System;
// Enum declaration
public enum DaysOfWeek // Enum for days of the week
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
class Program
{
    static void Main(string[] args)
    {
        DaysOfWeek today = DaysOfWeek.Wednesday; // Assigning an enum value

        Console.WriteLine("Today is: " + today); // Output: Today is: Wednesday

        // Using enum in a switch statement
        switch (today)
        {
            case DaysOfWeek.Sunday:
                Console.WriteLine("It's Sunday, time to relax!");
                break;
            case DaysOfWeek.Monday:
                Console.WriteLine("It's Monday, back to work!");
                break;
            case DaysOfWeek.Wednesday:
                Console.WriteLine("It's Wednesday, we're halfway through the week!");
                break;
            default:
                Console.WriteLine("It's just another day.");
                break;
        }
    }
}

// Collections - Collections in C# are data structures that allow you to store and manage groups of related objects. They provide various functionalities for adding, removing, and accessing elements. Common collection types include arrays, lists, dictionaries, and queues. Collections are essential for managing data efficiently in applications.
using System;
using System.Collections.Generic; // Importing the System.Collections.Generic namespace for using collections
class Program
{
    static void Main(string[] args)
    {
        // Creating a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Adding an element to the list
        numbers.Add(6);

        // Removing an element from the list
        numbers.Remove(3);

        // Displaying the elements in the list
        Console.WriteLine("Numbers in the list:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Creating a dictionary to store key-value pairs
        Dictionary<string, string> capitals = new Dictionary<string, string>
        {
            { "USA", "Washington, D.C." },
            { "UK", "London" },
            { "France", "Paris" }
        };

        // Accessing a value by its key
        Console.WriteLine("Capital of France: " + capitals["France"]);
    }
}

// Files and Streams - Files and streams in C# are used for reading from and writing to files. The System.IO namespace provides classes for file handling, such as File, StreamReader, and StreamWriter. You can perform operations like creating, reading, writing, and deleting files using these classes. Streams provide a way to read and write data in a continuous flow.
using System;
using System.IO; // Importing the System.IO namespace for file handling
class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt"; // Path to the file

        // Writing to a file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, World!");
            writer.WriteLine("This is a sample text file.");
        }

        // Reading from a file
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            Console.WriteLine("Contents of the file:");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // Deleting the file
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine("File deleted successfully.");
        }
    }
}


// Delegates - Delegates in C# are type-safe function pointers that allow you to encapsulate a method with a specific signature. They enable you to pass methods as parameters, define callback methods, and implement event handling. Delegates are particularly useful for implementing event-driven programming and callbacks.
using System;
// Delegate declaration
public delegate void Notify(string message); // Delegate type that takes a string parameter
class Program
{
    // Method that matches the delegate signature
    public static void NotifyUser(string message)
    {
        Console.WriteLine("Notification: " + message);
    }

    static void Main(string[] args)
    {
        // Creating an instance of the delegate and pointing it to the NotifyUser method
        Notify notify = new Notify(NotifyUser);

        // Invoking the delegate
        notify("You have a new message!");
    }
}
// Events - Events in C# are a way to provide notifications to subscribers when something happens in the application. They are built on top of delegates and allow you to define a publisher-subscriber relationship. When an event is raised, all subscribed methods (event handlers) are invoked, allowing for decoupled communication between different parts of the application.
using System;
// Event declaration
public delegate void EventHandler(string message); // Delegate type for the event
public class Publisher
{
    // Event declaration
    public event EventHandler Notify;

    // Method to raise the event
    public void RaiseEvent(string message)
    {
        Notify?.Invoke(message); // Invoke the event if there are subscribers
    }
}
public class Subscriber
{
    // Method that will handle the event
    public void OnNotify(string message)
    {
        Console.WriteLine("Received notification: " + message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Subscribing to the event
        publisher.Notify += subscriber.OnNotify;

        // Raising the event
        publisher.RaiseEvent("Hello, this is an event notification!");
    }
}
// LINQ (Language Integrated Query) - LINQ is a powerful feature in C# that allows you to query collections (like arrays, lists, and databases) using a SQL-like syntax. It provides a concise and readable way to filter, sort, and manipulate data. LINQ can be used with various data sources, including in-memory collections and external data sources like databases.
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using LINQ to filter even numbers
        var evenNumbers = from n in numbers
                          where n % 2 == 0
                          select n;

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Using LINQ to find the sum of all numbers
        int sum = numbers.Sum();
        Console.WriteLine("Sum of all numbers: " + sum);
    }
}
// Asynchronous Programming - Asynchronous programming in C# allows you to perform tasks without blocking the main thread, enabling better responsiveness in applications. It is particularly useful for I/O-bound operations like file reading/writing, network requests, and database queries. The async and await keywords are used to define asynchronous methods and handle their results.
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting asynchronous operation...");

        // Calling the asynchronous method
        await PerformAsyncOperation();

        Console.WriteLine("Asynchronous operation completed.");
    }

    static async Task PerformAsyncOperation()
    {
        // Simulating a delay to mimic an asynchronous operation
        await Task.Delay(2000); // Wait for 2 seconds
        Console.WriteLine("Asynchronous operation is in progress...");
    }
}   
// Dependency Injection - Dependency Injection (DI) is a design pattern that allows you to inject dependencies into a class rather than creating them within the class. It promotes loose coupling and makes your code more testable and maintainable. In C#, DI can be implemented using constructor injection, property injection, or method injection.
using System;
using Microsoft.Extensions.DependencyInjection;
// Interface for a service
public interface IMessageService
{
    void SendMessage(string message);
}
// Implementation of the service
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}
// Class that depends on the service
public class Notification
{
    private readonly IMessageService _messageService;

    // Constructor injection
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Setting up Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IMessageService, EmailService>() // Registering the service
            .BuildServiceProvider();

        // Resolving the service
        var messageService = serviceProvider.GetService<IMessageService>();
        var notification = new Notification(messageService);

        // Using the service
        notification.Notify("Hello, this is a dependency injection example!");
    }
}
// Unit Testing - Unit testing in C# involves writing tests to verify the functionality of individual components (units) of your code. It helps ensure that your code behaves as expected and allows you to catch bugs early in the development process. Popular frameworks for unit testing in C# include NUnit, MSTest, and xUnit.
using System;
using NUnit.Framework;
// Class to be tested
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
// Unit tests for the Calculator class
[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp] // This method runs before each test
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test] // Test method for addition
    public void Add_ShouldReturnSum_WhenGivenTwoIntegers()
    {
        int result = _calculator.Add(2, 3);
        Assert.AreEqual(5, result);
    }

    [Test] // Test method for subtraction
    public void Subtract_ShouldReturnDifference_WhenGivenTwoIntegers()
    {
        int result = _calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
    }
}
