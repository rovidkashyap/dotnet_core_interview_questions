// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 
    ASP.NET Core, like any application built on the .NET runtime, relies on the .NET Garbage Collector 
    (GC) to manage memory automatically. The Garbage Collector is a critical component of the .NET 
    runtime that is responsible for allocating and deallocating memory, ensuring efficient memory 
    usage, and improving application performance. 

    Key Concepts of Garbage Collection in .NET

    1. Automatic Memory Management: The GC automatically frees memory occupied by objects that are no 
                                    longer in use by the application, which helps prevent memory 
                                    leaks and other memory-related issues.
 
    2. Generations: The GC divides objects into generations to optimize the collection process:
                    Generation 0: Short-lived objects, such as temporary variables.
                    Generation 1: Objects that survived one GC cycle.
                    Generation 2: Long-lived objects that survived multiple GC cycles.

    3. Heap Segments: The managed heap is divided into segments for different generations, and large 
                      objects are allocated in a special segment called the Large Object Heap (LOH).

    4. GC Modes:
        
        Workstation GC - Optimized for single-user desktop applications. It balances responsiveness 
                         and throughput.
        
        Server GC - Optimized for multi-threaded, high-throughput applications, such as web servers. 
                    It uses multiple threads to perform collections in parallel, making it suitable 
                    for ASP.NET Core applications.

*/