# Overview of object oriented techniques in C#
In C#, the definition of a type—a class, struct, or record—is like a blueprint that specifies what the type can do. An object is basically a block of memory that has been allocated and configured according to the blueprint. 
## Encapsulation
Encapsulation is a fundamental principle of object-oriented programming (OOP) that involves bundling data (fields) and methods that operate on that data into a single unit, typically a class. It also restricts direct access to certain components of an object, allowing controlled interaction through well-defined interfaces (methods and properties).

### Data Hiding:

Prevents direct access to the internal state of an object.
Ensures data integrity by exposing only what is necessary.
### Access Modifiers:
Encapsulation is achieved using access modifiers like private, protected, internal, and public to control access to class members.
-*private*: Accessible only within the class.
-protected: Accessible within the class and derived classes.
-public: Accessible from any part of the program.
-internal: Accessible within the same assembly.
### Getters and Setters:
Controlled access to private fields is provided using properties (with get and set accessors) in C#.

## Inheritance
Inheritance is a mechanism in which one class acquires the properties and behavior of another class. It promotes code reusability and establishes a relationship between classes. The class that inherits is called a derived class, and the class that is inherited is called a base class.

## Objects - create instances of types
An object is an instance of a class, struct, or record type. It is a concrete entity based on a blueprint (class) that defines its structure and behavior. Objects have states (fields) and behaviors (methods).

### Struct Instances vs. Class Instances
Structs are value types, and classes are reference types in C#. When you create an instance of a struct, the memory is allocated on the stack, whereas for a class, it is allocated on the heap.

### Object Identity vs. Value Equality
Object identity refers to the reference to the object in memory, while value equality compares the values of the objects. The `==` operator compares object identity for reference types and value equality for value types.

## Inheritance - derive types to create more specialized behavior
Inheritance is a mechanism in which a new class inherits properties and behavior from an existing class. The new class is called a derived class, and the existing class is called a base class. Inheritance promotes code reuse and establishes a relationship between classes.

### Abstract and virtual methods
Abstract methods have no implementation in the base class and must be implemented in derived classes. Virtual methods have a default implementation in the base class but can be overridden in derived classes.

### Base class constructors
Derived classes can call the base class constructor using the `base` keyword. This allows the base class to initialize its fields before the derived class constructor runs.

## Polymorphism
Polymorphism is the ability of an object to take on multiple forms. In C#, polymorphism is achieved through method overriding and method overloading.

### Method Overriding
Method overriding allows a subclass to provide a specific implementation of a method that is already provided by its base class. It is used to achieve runtime polymorphism.

### Method Overloading
Method overloading allows a class to have multiple methods with the same name but different signatures. It is used to achieve compile-time polymorphism.

## Abstraction
Abstraction is the process of hiding the complex implementation details and showing only the essential features of an object. It is achieved through abstract classes and interfaces in C#.

### Abstract Classes
Abstract classes cannot be instantiated and may contain abstract methods that must be implemented by derived classes. They provide a blueprint for other classes to inherit from.

### Interfaces
Interfaces define a contract that classes can implement. They contain method and property signatures that must be implemented by classes that implement the interface. Interfaces allow for multiple inheritance in C#.







