// Stopping a thread

using System;
using System.Threading;

namespace Listing1_4 {

    internal class Program {

        private static void Main(string[] args) {
            bool stopped = false;

            // versão shorthand de delegate, usando lambda expression
            Thread t = new Thread(new ThreadStart(() => {
                while (!stopped) {
                    Console.WriteLine("Running ...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}