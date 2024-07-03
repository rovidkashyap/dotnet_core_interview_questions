
Clean Architecture is a software design philosphy that aims to create a seperation of concerns and
maintainability by organising code into distinct layers. this typically involves seperating the 
application into the following layers:

1. Core - Contains the domain entities, interfaces, and logic
2. Application - Contains use cases and application-specified business rules.
3. Infrastructure - Contains implementation details such as data access, external services, etc
4. Web - The presentation layer, typically an ASP.Net Core MVC or Web API project.

Project Structure

src/
|-- Core/
|	|-- Entities/
|	|-- Interfaces/
|	|-- Services/
|-- Application/
|	|-- Commands/
|	|-- Queries/
|	|-- Interfaces/
|	|-- Services/
|-- Infrastructure/
|	|-- Persistence/
|	|-- Repositories/
|	|-- Services/
|-- Web/
	|-- Controllers/
	|-- Models/
	|-- Middleware/
	|-- Program.cs


Step-By-Step Implementation

Step 1 - Define the Core Layer - Core/Entities/Order.cs
							   - Core/Interfaces/IOrderRepository.cs

Step 2 - Define the Application Layer - Application/Interfaces/IOrderService.cs
									  - Application/Services/OrderService.cs

Step 3 - Define the Infrastructure Layer - Infrastructure/Persistence/ApplicationDBContext.cs
										 - Infrastructure/Repositories/OrderRepository.cs

Step 4 - Define the Web Layer - WebApi/Controllers/OrdersController.cs

Step 5 - Configure Dependency Injection - WebAPI/Program.cs


By following these steps, you can build a maintainable, testable, and scalable ASP.NET Core application 
using the principles of Clean Architecture.