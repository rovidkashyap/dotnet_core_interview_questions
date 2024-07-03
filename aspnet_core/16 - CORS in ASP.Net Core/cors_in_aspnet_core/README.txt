
Cross-Origin Resource Sharing (CORS) is a security feature implemented by browsers to restrict how web 
pages can make requests to a different domain than the one that served the web page. In ASP.NET Core, 
enabling CORS allows you to specify which origins are permitted to access your API.

1. Install CORS NuGet Package (if necessary)

	- As of ASP.NET Core 2.1 and later, CORS is included in the Microsoft.AspNetCore.App package, so you 
	  generally do not need to install it separately.

2. Configure Services in Program.cs

3. Use CORS Middleware

STEP 1 - Configure Services in `Program.cs` -

STEP 2 - Use CORS Middleware 
		 (For Globally, enable CORS in `Program.cs` file)
		 (For Specific Endpoints, This enables CORS for specific controllers or actions)
		
STEP 3 - Use Custom CORS Policy