/*
 
    Choosing between .NET Core and .NET Standard for your class library project depends on the target 
    platforms and the intended usage scenarios. Here’s a breakdown of when to use each:

    .Net Core Class Library -

    1. Target Platform: Use .NET Core class libraries when your application or service targets the 
                        .NET Core runtime specifically.

    2. Cross-Platform Compatibility: .NET Core is designed for cross-platform development, so if you 
                                     need your library to work seamlessly across different operating 
                                     systems (Windows, Linux, macOS), .NET Core is the appropriate 
                                     choice.

    3. Modern Features: If you want to leverage the latest features and improvements introduced in 
                        .NET Core, such as performance optimizations, new APIs, and language 
                        enhancements, then .NET Core is suitable.

    4. Microservices and Containers: If your application architecture involves microservices deployed 
                                     as Docker containers or cloud-native applications, .NET Core is 
                                     well-suited due to its lightweight and modular nature.

    .Net Standard Class Library -

    1. Targeting Multiple Frameworks: Use .NET Standard class libraries when you need to target 
                                      multiple .NET implementations, such as .NET Framework, .NET 
                                      Core, and Xamarin.

    2. Library Reusability: .NET Standard is designed for maximum code reuse across different .NET 
                            implementations. It provides a common set of APIs that are available 
                            across all platforms that implement the .NET Standard version you target.

    3. Shared Libraries: If you are building libraries (e.g., NuGet packages) that are intended to be 
                         consumed by a wide range of .NET applications running on different platforms, 
                         .NET Standard ensures compatibility across these platforms.

    4. Legacy Applications: If you need to support older .NET Framework applications while also 
                            targeting newer platforms like .NET Core, .NET Standard allows you to 
                            maintain compatibility without duplicating code.

*/