static void Main(string[] args) { }
/*

ASP.NET Core supports several hosting models, each suited for different deployment scenarios and 
requirements. These hosting models provide flexibility in how ASP.NET Core applications are deployed, 
managed, and scaled. Here are the primary hosting models supported by ASP.NET Core:

1. Kestrel Server Hosting -

    - Kestrel is a cross-platform web server that is optimized for serving ASP.NET Core applications. 
      It is lightweight and fast, making it suitable for hosting applications directly without 
      requiring a reverse proxy server.

    - Kestrel can be used for development and production scenarios. It's typically used when you want 
      to self-host an ASP.NET Core application without relying on IIS or another web server.

    - Deploying an ASP.NET Core application with Kestrel involves running the application using dotnet 
      run or dotnet publish commands and configuring it to listen on a specified port.

2. IIS Hosting -

    - ASP.NET Core applications can also be hosted within Internet Information Services (IIS) on 
      Windows. IIS acts as a reverse proxy server to forward requests to the Kestrel server running 
      the ASP.NET Core application.

    - IIS hosting is common in environments where IIS is already used as the primary web server. It 
      provides features such as HTTPS termination, logging, and process management.

    - Deploying an ASP.NET Core application to IIS involves configuring the IIS server to act as a 
      reverse proxy to forward requests to Kestrel. This setup allows you to leverage IIS features 
      while running the application on Kestrel.

3. Windows Service Hosting -

    - ASP.NET Core applications can be hosted as Windows services on Windows machines. This hosting 
      model allows ASP.NET Core applications to run in the background without requiring a user to be 
      logged in.

    - Windows service hosting is suitable for long-running background tasks or services that need to 
      be managed by Windows Service Control Manager (SCM).

4. Docker Container Hosting -

    - ASP.NET Core applications can be packaged and deployed as Docker containers. Docker containers 
      provide a lightweight, isolated environment for running applications, ensuring consistency 
      across different environments.

    - Docker container hosting is ideal for microservices architectures, DevOps practices, and 
      cloud-native deployments. It allows applications to be easily deployed, scaled, and managed 
      using container orchestration tools like Kubernetes.

    - Deploying an ASP.NET Core application as a Docker container involves creating a Docker image 
      with the application's dependencies and runtime environment, then running containers based on 
      these images on Docker-compatible platforms.

5. Azure App Service Hosting -

    - Azure App Service is a platform-as-a-service (PaaS) offering in Microsoft Azure that allows 
      hosting web applications, including ASP.NET Core applications, without managing virtual 
      machines.

    - Azure App Service hosting is suitable for cloud deployments where scalability, high availability, 
      and managed infrastructure are desired. It supports automatic scaling, deployment slots, and 
      integration with Azure services.

    - Deploying an ASP.NET Core application to Azure App Service involves publishing the application 
      directly from Visual Studio, using Azure DevOps pipelines, or deploying Docker containers to 
      Azure App Service.

*/