using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread");
            //Thread thread1 = new Thread(Print);
            Thread thread2 = new Thread(Print1);
            thread2.IsBackground = true;

            // thread1.Start();
            thread2.Start();

            Console.WriteLine(Thread.CurrentThread.Name);

            //Console.ReadKey();
        }

        static void Print()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Foreground Thread => " + (i + 1));
            }
        }

        static void Print1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Background Thread => " + (i + 1));
            }
        }
    }
    

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Async method call ========");
            var output1 = SumOfNumbersAsync(8);


            Console.WriteLine("======== Sync method call ========");
            var output2 = SumOfNumbers(8);


            Console.WriteLine("Sync method call output: " + output2);
            Console.WriteLine("Async method call output: " + output1.Result);

            Console.ReadKey();
        }

        private static int SumOfNumbers(int count)
        {
            int results = 0;
            for (int i = 1; i <= count; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("Sync method, number print : "  + i);
                results += i;
            }
            return results;
        }

        private static Task<int> SumOfNumbersAsync(int count)
        {
            int results = 0;
            Task<int> task = new Task<int>(() =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("Async method, number print : " + i);
                    results += i;
                }
                return results;
            });

            task.Start();
            return task;
        } 
    }
    */
}
