
The SOLID principles are a set of design principles that help developers create more maintainable,
understandable, and flexible software. 

1. Single Responsibility Principle (SRP)
2. Open/Closed Principle (OCP)
3. Liskov Substitution Principle (LSP)
4. Interface Segregation Principle (ISP)
5. Depenendecy Inversion Principle (DIP)

1. Single Responsibility Principle (SRP) - A class should have only one reason to change, it should
   only have one responsibility.

   - Please check the `UserService.cs` file.

2. Open/Closed Principle (OCP) - A Software entities (classes, modules, functions, etc) should be open 
   for extension but closed for modification.

   - Please check the `DiscountService.cs` file.

3. Liskov Substitution Principle (LSP) - Objects of a superclass should be replaceable with objects of a
   subclass without affecting the correctness of the program.

   - Please check the `liskov.cs` file.

4. Interface Segregation Principle (ISP) - Client should not be forced to implement an interface it 
   doesn't use.

   - Please check the `Worker.cs` file.

5. Dependency Inversion Principle (DIP) - High level modules should not depend on low-level modules. Both
   should depend on abstractions (e.g., interface). Abstraction should not depende on details. Details
   should depend on abstraction.

   - Please check the `DIP.cs` file.


By Following the OSOLID principles in your .NET Core 8 applications, you can create more modular, scalable
and maintainable software. 

These principles helps ensure that your code is easier to understand, extend,
and modify, which ultimately leads to higher quality and more robust applications.