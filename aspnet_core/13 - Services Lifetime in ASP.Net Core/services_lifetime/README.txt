
In ASP.NET Core, services are typically added to the dependency injection (DI) container with a 
specified lifetime. The lifetime of a service determines how long a service instance is kept alive 
and reused. There are three primary service lifetimes in ASP.NET Core:

1. Transient

2. Scoped

3. Singleton

1. Transient Service - Service are created each time they are requested. This service works best for
					   lightweight, stateless services.

					 - Use Transient service for those that do not maintain any state and need to be
					   short-lived.

2. Scoped Service - Services are create once per client request (connection). They are disposed of once
					the request completes.

				  - This service maintain state within a single request but should not be shared across
				    multiple requests.

				  - A service that handles database operations where the same instance is needed throughout
				    a request.

3. Singleton Service - This service are created the first time they are requested and then every subsequent
					   request uses the same instance. The instance is shared throughout the application's
					   lifetime.

					 - A service that handles application-wide configurations or caching.