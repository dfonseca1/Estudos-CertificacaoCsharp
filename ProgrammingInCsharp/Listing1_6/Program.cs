using System;
using System.Threading;

// Using ThreadLocal<T>
namespace Listing1_6 {

    internal class Program {

        //define variavel local com copia para cada thread e inicializa
        public static ThreadLocal<int> _field = new ThreadLocal<int>(
            () => Thread.CurrentThread.ManagedThreadId
        );

        private static void Main(string[] args) {
            new Thread(() => {
                Console.WriteLine("Thread A Id: {0}", Thread.CurrentThread.ManagedThreadId);

                for (int x = 0; x < _field.Value; x++) {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() => {
                Console.WriteLine("Thread B Id: {0}", Thread.CurrentThread.ManagedThreadId);

                for (int x = 0; x < _field.Value; x++) {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}