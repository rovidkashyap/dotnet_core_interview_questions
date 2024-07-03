
Routing in ASP.NET Core MVC is a system that maps incoming requests to corresponding controller actions. 
It is an essential part of the ASP.NET Core framework, as it defines how URLs are interpreted and how 
requests are handled by the application.

Overview of Routing

Routing in ASP.NET Core MVC involves defining URL patterns that are mapped to controllers and actions. 
This can be done through attribute-based routing or convention-based routing.

1. Convention-Based Routing -

Convention-based routing is defined in the Startup class, typically within the Configure method or if you
are working on .Net Core 6+ version than it sould be defined in `Program.cs` file. It uses a centralized 
route configuration that applies to all controllers in the application.

Please check the `Program.cs` file for the demo...

2. Attribute-Based Routing -

Attribute-based routing allows defining routes directly on the controller and action methods using 
attributes. This provides more flexibility and is often easier to manage in larger applications.

Please check the controller for the demo...

3. Customizing Routes -

You can create more complex route patterns and constraints using both convention-based and attribute
based routing.

4. Route Templates -

Route templates are patterns that define the structure of URLs. They can include literals, parameters,
optional parameters, and constraints.

5. Using `MapControllers` -

In applications using the endpoint routing system, you can use `MapControllers` to enable attribute routing
for all controllers:

