using System;
using System.Threading.Tasks;

// Attaching child tasks to a parent task
namespace Listing1_12 {

    internal class Program {

        private static void Main(string[] args) {

            //parent task só termina quando todos os childs terminarem de rodar
            Task<Int32[]> parent = Task.Run(() => {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                   TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                   TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            // só roda quando o parent terminar de rodar
            var finalTask = parent.ContinueWith(
                parentTask => {
                    foreach (int i in parentTask.Result) {
                        Console.WriteLine(i);
                    }
                });

            finalTask.Wait();

            Console.ReadKey();
        }
    }
}