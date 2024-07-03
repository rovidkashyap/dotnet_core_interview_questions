
CQRS, which stands for Command Query Responsibility Segregation, is a design pattern that separates the 
read and write operations of a system. This segregation allows for more flexible and scalable 
architectures. In ASP.NET Core 8, CQRS can be implemented using various libraries and techniques. 
Here’s an explanation of the concept along with a practical example:

Key Concepts of CQRS

1. Command and Query Seperation:

	- Commands: Represent operations that change the state of the system (write operations). Examples 
				include creating, updating, or deleting records.

	- Queries: Represent operations that retrieve data without changing the state of the system (read 
			   operations).

2. Components:

	- Command Handlers: Handle commands and execute business logic to change the state.

	- Query Handler: Handle queries and retrieve data.

	- Mediator: Acts as an intermediary to dispatch commands and queries to their respective handlers.


IMPLEMENTING CQRS in ASP.NET CORE 8

STEP 1 - Install Dependencies
		
		- Install Package `MediatR`
		- Install Package `MediatR.Extensions.Microsoft.DependencyInjection`

STEP 2 - Define Commands and Queries

		- Command Example - `CreateOrderCommand` file.
		- Query Example - `GetOrderByIdQuery` file.

STEP 3 - Implement Command and Query Handlers

		- Command Handler `CreateOrderCommandHandler` file.
		- Query Handler `GetOrderByIdQueryHandler` file.

STEP 4 - Register MediatR in `Startup.cs` or `Program.cs` file.

		- Register MediatR and the handlers in the service container.

STEP 5 - Use MediatR in Controllers

		- Injet `IMediator` into your controllers and use it to send commands and queries.