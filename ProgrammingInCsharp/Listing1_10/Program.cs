using System;
using System.Threading.Tasks;

// Adding a continuation
namespace Listing1_10 {

    internal class Program {

        private static void Main(string[] args) {
            Task<int> t = Task.Run(() => {
                return 42;
            }
            ).ContinueWith((i) => {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result); // Displays 84
            Console.ReadKey();
        }
    }
}