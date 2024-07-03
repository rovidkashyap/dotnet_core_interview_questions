
Inversion of Control (IoC) is a design principle used to invert the flow of control in a system. Instead 
of the application controlling the flow, control is inverted, and an external entity (usually a 
framework) controls the flow. 

In the context of .NET Core, IoC is typically implemented using Dependency Injection (DI).

Key Concepts of IoC and DI

1. Dependency Injection (DI): A technique for achieving IoC, where an object receives its dependencies 
							  from an external source rather than creating them itself.

2. Service Container: A central place where all dependencies are registered and resolved.

3. Lifetime Management: Configuring how long a service should live (Transient, Scoped, Singleton).

Implementing IoC in .NET Core 8

STEP 1 - Define Services and Interfaces - Interface/IMessageService.cs

STEP 2 - Register Services in the Service Container - Program.cs

STEP 3 - Inject Services into Controllers - Controllers/HomeController.cs

Service Lifetime Management

1. Transient - Services are created each time they are requested. This is useful for lightweight, stateless 
			   services.

2. Scoped - Services are created once per request. This is useful for services that should be shared 
		    within a request but not across requests.

3. Singleton - Services are created the first time they are requested and then shared throughout the 
			   application's lifetime. This is useful for services that maintain state.


Inversion of Control (IoC) in .NET Core is primarily achieved through Dependency Injection (DI), 
allowing for better separation of concerns, easier testing, and more flexible and maintainable code. 

By defining interfaces, implementing services, registering those services in the DI container, and 
then injecting them where needed, you can effectively leverage IoC in your .NET Core applications.