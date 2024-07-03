
In ASP.Net Core, `IHostedService` is an interface that allows you to run background tasks or services
on application startup and shutdown. It provides a way to execute long-running background operations
independently of the main application thread, it suitable for scenarios such as background tasks, 
timers, or periodic operations.

1. `IHostedService` allows you to define background tasks that run asynchronously when the application
	starts.

2. Implement the `StartAsync(cancellationToken)` and `StopAsync(cancellationToken)` methods, which are
   invoked by the application's lifetime management.

3. Can be injected with dependencies using the ASP.Net Core dependency injection mechanism.

4. `StartAsync(CancellationToken)` is called when the application starts, allowing initialization of
	the hosted service.

5. `StopAsync(CancellationToken)` is called when the application is shutting down, allowing cleanup
	tasks to be performed.