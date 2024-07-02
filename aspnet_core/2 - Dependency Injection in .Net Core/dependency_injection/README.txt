
Dependency Injection (DI) is a design pattern that allows the separation of concerns in an application 
by injecting dependencies into classes rather than having those classes create the dependencies 
themselves. 

.NET Core provides built-in support for DI, making it easy to use and integrate into your applications.

1. Built-In Dependency Container :

	.Net Core comes with a built-in dependency injection container that is lighweight and easy to configure.
	This container supports constructor injection, method injection and property injection.

2. Setting Up Dependency Injection in .Net Core :

	2.1	Register Services: Services are registered in `ConfigureServices` method of the `Startup` class or
		`Program.cs` file in .Net Core 7/8.

		- `AddTransient`: Creates a new instance of the service each time it is requested.
		- `AddScoped` : Created a new instance of the service per HTTP request.
		- `AddSingleton` : Creates a single instance of the service for the entire application's lifetime.

	2.2 Inject Services :

		Once Services are registered, you can inject them into your classes via constructors.

3. Service Lifetimes :
		
		- Transient: Services are created each time they are requested. This is suitable for lightweight,
					 stateless services.
		
		- Scoped: Scoped are created once per client request. This is ideal for services that maintain
				  state within a request.

		- Singleton: Services are created the first time they are requested and then reused for every
					 subsequent request. This is useful for stateful services or those with significant
					 initialization overhead.

4. Configuration and Options :

	You can also inject configuration settings using the `IOptions<T>` pattern. This is useful for passing
	configuration values to services.

5. Third-Party Dependency Injection Containers :

	While the built-In DI container is sufficient for most applications, .Net Core also supports integrating
	third party DI containers like Autofac, Ninject and StructureMap.