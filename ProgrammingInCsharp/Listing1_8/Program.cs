using System;
using System.Threading.Tasks;

// Starting a new Task
namespace Listing1_8 {

    internal class Program {

        private static void Main(string[] args) {
            // criando uma task e esperando seu resultado
            Task t = Task.Run(() => {
                for (int x = 0; x < 100; x++) {
                    Console.Write('*');
                }
            });

            t.Wait();
        }
    }
}