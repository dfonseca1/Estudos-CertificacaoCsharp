using System;
using System.Threading;

// Using a background thread
namespace Listing1_2 {

    public class Program {

        public static void ThreadMethod() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        private static void Main(string[] args) {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            // faz a aplicação fechar imediatamente, pois vira uma background thread
            t.IsBackground = true;
            t.Start();
        }
    }
}