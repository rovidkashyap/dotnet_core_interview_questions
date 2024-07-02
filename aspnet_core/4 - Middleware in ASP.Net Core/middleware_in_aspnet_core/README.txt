
Middleware in ASP.Net Core is a crucial component for handling HTTP requests and responses. It allow
developers to build a pipeline of request processing modules, where each modules, or middleware component
can process the request, perform actions, and pass it to the next component in the pipeline.

PURPOSE OF MIDDLEWARE

1. Request handling: Middleware components handle incoming HTTP requests, process them, and produce HTTP 
					 responses. Each middleware can either handle the request itself or pass it to the 
					 next middleware in the pipeline.

2. Modular and Reusable Code: Middleware promotes modularity and reusability by allowing developers to 
							  encapsulate specific functionality (like authentication, logging, error 
							  handling, etc.) into distinct components that can be easily added or 
							  removed from the application pipeline.

3. Custom Processing: Middleware enables custom processing of requests and responses. Developers can 
					  create custom middleware to handle specific needs, such as custom logging, request 
					  validation, or response modification.

4. Pipeline Configuration: Middleware components are configured in a specific order in the pipeline, 
						   determining how requests are processed and how responses are generated. The 
						   order of middleware is critical as it affects the behavior of the application.

HOW MIDDLEWARE WORKS

In ASP.Net Core, middleware components are added to the application pipeline in the `Program.cs` file
or in the `Startup.cs` file (in previous versions of .net core).

1. Process Request: Perform actions on the incoming request.

2. Call Next Middleware: Pass control to the next middleware component in the pipeline.

3. Process Response: Performce actions on the outgoing response after the next middleware has processed
					 the request.

COMMON MIDDLEWARE COMPONENTS

1. Static Files Middleware - Serves static files (like HTML, CSS, JS) from the wwwroot folder.
2. Routing Middleware - Handles routing of the requests to the appropriate endpoints.
3. Authentication Middleware - Handles user authentication.
4. Authorization Middleware - Handles user authorization and access control.
5. Exception Handling Middleware - Catches and processes exceptions that occur during request processing.
6. Custom Middleware - Developers can create custom middleware to perform specific tasks.