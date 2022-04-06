using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample
{
    /*
    public class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("code 1");
            Console.WriteLine("code 2");
            SomeMethod();
            Console.WriteLine("code 7");
            Console.WriteLine("code 8");
        }

        static async void SomeMethod()
        {
            Console.WriteLine("code 3");
            Console.WriteLine("code 4");
            await Task.Delay(10000);
            Console.WriteLine("code 5");
            Console.WriteLine("code 6");
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
        
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
                sw.Stop();
                Console.WriteLine("For Method1 =>" + sw.ElapsedTicks);
            });

        }


        public static void Method2()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
            sw.Stop();
            Console.WriteLine("For Method2 =>" + sw.ElapsedTicks);
        }
    }
    */

    /*
    class Program
    {
        static async Task Main(string[] args)
        {
            await callMethod();
            Console.ReadKey();
        }

        public static async Task callMethod()
        {
            var count = Method1();
            Method2();
            // Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
    */

    /*
    class Program
    {
        static async Task Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Print));
            }
            Console.ReadKey();
        }

        static void Print(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string msg = $"BGThread: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread Id: {thread.ManagedThreadId}";
            Console.WriteLine(msg);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MethodWithThreadPool();
                MethodWithThread();
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            MethodWithThread();
            sw.Stop();
            Console.WriteLine("Time taken by Method with Thread:" + sw.ElapsedTicks.ToString());

            Console.WriteLine("========");

            sw.Reset();
            sw.Start();
            MethodWithThreadPool();
            sw.Stop();
            Console.WriteLine("Time taken by Method with ThreadPool:" + sw.ElapsedTicks.ToString());

            Console.ReadKey();
        }

        // Using threads created by us
        static void MethodWithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Print);
            }
        }

        // Using threads from the Threadpool
        static void MethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Print));
            }
        }

        static void Print(object obj)
        {
            Console.WriteLine("Something...");
        }












        //static async Task CallMultipleRestAPIs()
        //{
        //    var collection = new List<string>();
        //    foreach (var uri in collection)
        //    {
        //        async Task<string> func()
        //        {
        //            var client = new HttpClient();
        //            var response = await client.GetAsync(uri);
        //            return await response.Content.ReadAsStringAsync();
        //        }

        //        tasks.Add(func());
        //    }

        //    await Task.WhenAll((IEnumerable<Task>)tasks);

        //    var postResposes = new List<string>();
        //    foreach (var t in tasks)
        //    {
        //        var response = await t;
        //        postResposes.Add(postResposes);
        //    }
        //}
    }
    */

    class LinqOperations
    {
        static void Main(string[] args)
        {
            //string[] names = { "an1", "bn1", "n2", "n3", "n4", "n5" };

            ////var printSelectedName = from name in names
            ////                        where name.Contains("n1")
            ////                        orderby name descending
            ////                        select name ;

            //var printSelectedName = names.Where(x => x.Contains("n1")).OrderBy(x => x);

            //foreach (var item in printSelectedName)
            //{
            //    Console.WriteLine(item);
            //}
            //

            List<Student> students = new List<Student>
            {
                new Student {Id=1, Name = "Name1", Age=13},
                new Student {Id=2, Name = "Name2", Age=14},
                new Student {Id=3, Name = "Name3", Age=12},
                new Student {Id=4, Name = "Name4", Age=15},
                new Student {Id=5, Name = "Name5", Age=11},
                new Student {Id=6, Name = "Name6", Age=12},
                new Student {Id=7, Name = "Name7", Age=13 }
            };

            var printSelectedName = from student in students
                                    where student.Age >= 12 && student.Age <= 14
                                    select student;

            foreach (var item in printSelectedName)
            {
                Console.WriteLine(item.Name +", " + item.Age.ToString());
            }

            Console.ReadKey();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}



