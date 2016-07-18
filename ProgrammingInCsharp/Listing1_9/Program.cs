using System;
using System.Threading.Tasks;

// Using a task that returns a value
namespace Listing1_9 {

    internal class Program {

        private static void Main(string[] args) {
            Task<int> t = Task.Run(() => {
                return 42;
            });
            Console.WriteLine(t.Result);
        }
    }
}