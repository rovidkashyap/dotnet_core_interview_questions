using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace synchronous_and_asynchronous
{

    // `Synchronous Method` execute sequentially, blocking the thread until the operation completes
    //  and returns the result.

    // In the below example of `Synchronous Method` the function `CalculateSum` will block the thread
    // until it completes the addition operation and returns the result immediately.

    // `Asynchronous Method` enables non-blocking execution, allowing the thread to be released to
    // perform other tasks while waiting for the operation to complete.

    internal class Program
    {
        static void Main(string[] args)
        {
            Process();      // Calling Synchronous Method

            ProcessAsync(); // Calling Asynchronous Method
        }

        #region Synchronous Method

        // Synchronous Method
        public static int CalculateSum(int a, int b)
        {
            Console.WriteLine("Calculating sum synchonously....");
            return a + b;
        }

        // Calling Synchronous Method
        public static void Process()
        {
            int result = CalculateSum(5, 3);
            Console.WriteLine($"Result: {result}");
        }

        #endregion

        #region Asynchronous Method

        // Asynchronous Method
        public static async Task<int> CalculateSumAsync(int a, int b)
        {
            Console.WriteLine("Calculating sum asynchronously...");
            await Task.Delay(1000);     // Simulate delay (I/O-bound operation)
            return a + b;
        }

        // Calling asynchronous method
        public static async Task ProcessAsync()
        {
            int result = await CalculateSumAsync(5, 3);
            Console.WriteLine($"Result: {result}");
        }

        #endregion
    }
}
