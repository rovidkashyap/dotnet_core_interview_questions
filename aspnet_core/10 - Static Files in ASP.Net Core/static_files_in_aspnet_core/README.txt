
In ASP.NET Core, serving static files such as HTML, CSS, JavaScript, images, and other client-side 
assets is handled by the StaticFiles middleware. This middleware is responsible for locating and 
serving static files from the file system or another location specified in the application.

CONFIGURATION

To enable static file serving in an ASP.NET Core application, you typically configure the middleware in 
the Configure method of your Startup class. Here’s how you can configure static file serving:

1. Add the Middleware -
	
	for adding middleware, check the `Program.cs` file.

2. UseStaticFiles() Method -

	- `app.UseStaticFiles()` enables the serving of static files from the `wwwroot` directory. This
	  directory conventionally holds static assets like HTML, CSS, JavaScript, images, etc.

	- It also allows for customizing the request path prefix for serving static files, if needed.

	`wwwroot` Directory

	wwwroot/
	| -- css/
	|	| -- site.css
	| -- js/
	|	| -- script.js
	| -- images/
	|	| -- logo.png
	| -- index.html

	- When app.UseStaticFiles() is configured in the Startup class, requests for files like 
	  https://example.com/css/site.css or https://example.com/js/script.js are automatically handled 
	  by the middleware, serving the corresponding files from the wwwroot directory.