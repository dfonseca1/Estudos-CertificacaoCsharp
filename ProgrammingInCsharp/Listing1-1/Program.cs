using System;
using System.Threading;

// Creating a thread with Thread Class
namespace Listing1_1 {

    public static class Program {

        public static void ThreadMethod() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Thread Proc: {0}", i);
                //informa que a thread acabou a execução e impede que espere o time slice
                Thread.Sleep(0);
            }
        }

        private static void Main(string[] args) {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            t.Start();

            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Main thread: Do some work.");
                //informa que a thread acabou a execução e impede que espere o time slice
                Thread.Sleep(0);
            }

            // faz esperar as threads acabarem de executar
            t.Join();
        }
    }
}