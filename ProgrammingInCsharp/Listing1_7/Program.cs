using System;
using System.Threading;

// Queuing some work to the thread pool
namespace Listing1_7 {

    internal class Program {

        private static void Main(string[] args) {
            // reaproveitando threads que estão na threadpool
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadLine();
        }
    }
}