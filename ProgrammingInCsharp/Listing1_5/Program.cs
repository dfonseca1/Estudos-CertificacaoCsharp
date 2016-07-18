using System;
using System.Threading;

// Using the ThreadStaticAttribute
namespace Listing1_5 {

    internal class Program {

        //faz com que cada thread tenha sua própria cópia
        [ThreadStatic]
        public static int _field;

        private static void Main(string[] args) {
            new Thread(() => {
                for (int x = 0; x < 10; x++) {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() => {
                for (int x = 0; x < 10; x++) {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}