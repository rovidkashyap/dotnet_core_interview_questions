
MIDDLEWARE -

Middleware is a component that processes HTTP requests and responses. Middleware is designed to handle 
low-level request processing and can perform a variety of tasks such as authentication, logging, routing, 
and more. Middleware components are chained together to form a request pipeline.

Characteristics of Middleware:

Request Pipeline: Middleware operates at the level of the HTTP request pipeline, processing requests as 
				  they enter and responses as they leave.

Global Scope: Middleware applies to all requests handled by the application.

Order of Execution: The order in which middleware components are added to the pipeline is crucial and 
					determines the order of execution.

Customization: Middleware components are highly customizable and can handle any part of the HTTP request 
			   and response.

Performance Impact: Middleware is typically designed for high performance, as it processes every request.

FILTERS - 

Filters are specific to the MVC framework in ASP.NET Core and are used to run code before or after 
certain stages in the processing of an MVC action. Filters are applied at the controller or action level 
and are typically used for handling cross-cutting concerns related to MVC actions, such as authorization, 
caching, error handling, and action execution.

Types of Filters:

1. Authorization Filters: Run before any other filters to determine whether the user is authorized to 
						  execute the action.

2. Resource Filters: Run after authorization and can handle tasks like caching or setting up resources.

3. Action Filters: Run before and after the action method execution.

4. Exception Filters: Run when there is an unhandlese exception thrown by the action or another filter.

5. Result Filters: Run before and after the execution of the action result.