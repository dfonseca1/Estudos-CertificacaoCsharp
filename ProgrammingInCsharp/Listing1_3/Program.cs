using System;
using System.Threading;

// Using the ParameterizedThreadStart
namespace Listing1_3 {

    internal class Program {

        public static void ThreadMethod(object o) {
            for (int i = 0; i < (int)o; i++) {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        private static void Main(string[] args) {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            // Outra alternativa
            // Thread t = new Thread(ThreadMethod);

            // Passando um valor para o método que foi passado para a thread
            t.Start(5);
            t.Join();
        }
    }
}