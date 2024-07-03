
In ASP.NET Core, the Program.cs file plays a crucial role as the entry point and configuration center 
for the application. It is where the web host is configured, services are registered, and the 
application is started. Here’s a detailed look at the role and structure of the Program.cs 
file:

Structure of Program.cs -

The Program.cs file typically consists of two primary methods:

1. `Main` Method - 

	- The `Main` Method is the entry point of the application. It sets up the host builder 
	  (`WebHostBuilder` or `HostBuilder`) and starts the application.

	- It is responsible for configuring the host, setting up logging, and initializing the 
	  application environment

	- `CreateHostBuilder` Method setups up the host builder (`HostBuilder`), which is responsible for
	  configuring services, setting up the server (like Kestrel), and configuring the application's
	  startup.

	- `ConfigureWebHostDefaults` Method configures the web host (`WebHostBuilder`) with defaults for
	  for ASP.Net Core applications, including setting up Kestrel server and integrating with ASP.Net
	  Core Middleware.

2. `CreateHostBuilder` Method -

	- This method configures the host builder (`HostBuilder`) for the application.

	- It typically uses `Host.CreateDefaultBuilder(args)` to set up default configurations such as
	  environment variables, logging providers and configuration sources.