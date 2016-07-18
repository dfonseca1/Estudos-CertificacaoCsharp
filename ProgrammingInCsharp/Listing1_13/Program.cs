using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using a TaskFactory
namespace Listing1_13 {
    class Program {
        static void Main(string[] args) {


            Task<Int32[]> parent = Task.Run(() => {
                var results = new Int32[3];

                //definindo as configurações da taskFactory, as quais serão aplicadas a todas tasks criadas pela factory
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

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
