
Session and State Management in ASP.Net Core are important aspects of web application development, as they
help maintain user data across multiple requests.

SESSION MANAGEMENT -

Session management allow storing user data across multiple requests in a web application. Session are
particulary useful for maintining user state, such as login status, user preference, or temporary data
between page requests.

How Session Management Works

1. Session ID: When a user first accessed a web application, a unique session ID is generated and stored
			   in a cookie on the client side.

2. Server-Side Storage: The session data is stored on the server and its associated with the session ID.
						This data can be stored in various backends, such as in-memory, distributed cache,
						SQL Server, etc.

3. Subsequent Requests: On subsequent requests, the session ID is sent back to the server via the cookies,
						and the server retrieves the corresponding session data.


Configuring Session in ASP.Net Core

1. Add Session Service: In the `Startup.cs` file, add session services to the service container.
						Check the `Program.cs` file of project.

2. Configure Middleware: Add the session middleware to the request processing pipeline.
						 Check this in `Program.cs` file of this project.

3. Use Session in Controllers: Check the controller of this project.


STATE MANAGEMENT - 

State Management refers to the techniques used to preserve the state of an application across different
requests and sessions. In ASP.Net Core, state management can be achieved using various mechanism.

Types of State Management -

1. Application State: Data shared across all users and sessions. Typically stored in memory or a shared
					  cache.

2. Session State: Data specific to a single user session, as discuss above.

3. Cookies State: Data stored in cookies on the client side. Useful for small pieces of data that need 
				  to persist across multiple requests.

4. Query Strings: Data passed in the URL query string. Useful for transferring small amounts of data
				  between pages.

5. Hidden Fields: Data stored in hidden form fields. Useful for persisting data between from submissions.

6. TempData: A feature in ASP.Net Core MVC that provides a temporary storage mechanism for data that
			 need to be available for the next request.