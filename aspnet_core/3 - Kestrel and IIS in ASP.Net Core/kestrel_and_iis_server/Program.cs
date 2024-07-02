// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 
    Kestrel and IIS (Internet Information Services) are both web servers used in the .NET ecosystem, 
    but they serve different purposes and have distinct characteristics.

    KESTREL :

    - Kestrel is cross-platform web server for ASP.Net Core applications runs on Windows, macOS and 
      linux.

    - Kestrel is lighweight server, with fewer features compared to IISm but sufficient for handling
      basic HTTP requests and responses.

    - Kestrel is Default web server included with ASP.Net Core projects.

    - While Kestrel can be used both as inner (development) and outer (production) server, it is often
      used in conjunction with another web server (like IIS, Nginx, or Apache) in production for 
      security and additional features.

    IIS (Internet Information Services) :

    - IIS is available only on Windows provides some features like filtering, URL rewriting, application
      pool management, security features, and more.

    - IIS includes graphical user interface for managing websites, applications, and virtual directory.

    - IIS offers advance security features like request filtering, IP restrictions, and authentication
      mechanisms.

    - IIS used a reverse proxy server that forwards requests to Kestrel. This setup conbines the perf
      ormance of Kestrel with the advanced features of IIS.
 
 */