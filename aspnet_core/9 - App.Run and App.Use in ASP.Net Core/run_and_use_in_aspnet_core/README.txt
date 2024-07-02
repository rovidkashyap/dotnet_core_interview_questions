
In .NET Core 7 and 8, ASP.NET Core applications can be configured using a more streamlined approach, 
often referred to as the minimal hosting model. This approach simplifies the configuration of middleware 
directly within the Program.cs file using top-level statements. 

Let's explore how App.Run and App.Use are used in this context:

`App.Use` :

- The App.Use method in .NET Core 7 and 8 is used to add middleware components to the request processing 
  pipeline. Middleware components are software components that are assembled into an application pipeline 
  to handle requests and responses.

- Each middleware component in the pipeline can either handle an incoming request and produce a response 
  or pass the request to the next component in the pipeline.

  Please check the `Program.cs` file for code..

`App.Run` :

- The App.Run method in .NET Core 7 and 8 is used to add terminal middleware to the request processing 
  pipeline.

- Terminal middleware is the last middleware in the pipeline and handles the request without passing it 
  to any subsequent middleware.


Difference Between `App.Use()` and `App.Run()` :

1. `App.Use()` adds middleware components to the pipeline that can process the request and pass it to the
	subsequent middleware.

2. `App.Run()` adds terminal middlware that handles the request directly and does not pass it to any
	subsequent middleware.