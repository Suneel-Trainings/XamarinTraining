using System;
using System.Linq;
using MoreLinq;

namespace MoreLinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // BatchDemo();
            // InterleaveDemo();
            // PermutationDemo();
            SplitDemo();
            Console.Read();
        }

        static void BatchDemo()
        {
            var nums = Enumerable.Range(1, 100);
            var batches = nums.Batch(5);
            int i = 1;
            foreach (var batch in batches)
            {
                Console.WriteLine("Batch" + i.ToString());
                i++;
                foreach (var batchitem in batch)
                {
                    Console.Write($"{batchitem}\t");
                }
                Console.WriteLine();
            }
        }

        static void InterleaveDemo()
        {
            var randNum = new Random();
            var wholeNums = Enumerable.Range(1, 10).Select(_ => (double)randNum.Next(10));
            var fractNums = Enumerable.Range(1, 12).Select(_ => randNum.NextDouble());
            var output = wholeNums.Interleave(fractNums);
            //int i = 1;
            //Console.WriteLine("Whole Number \t Fraction Numbers");
            foreach (var item in wholeNums.Interleave(fractNums))
            {
                Console.Write(item);
                Console.Write("\t");

                //if (i % 2 == 0)
                //{
                //    Console.WriteLine();
                //}
                //i++;
            }
            Console.WriteLine();
        }

        static void PermutationDemo()
        {
            var chars = "testing".ToCharArray();
            int i = 1;
            foreach (var item in chars.Permutations())
            {
                Console.WriteLine(i.ToString() + " => " + new string(item.ToArray()));
                i++;
            }
        }

        static void SplitDemo()
        {
            var randNum = new Random();
            var nums = Enumerable.Range(1, 10);
            var split = nums.Split(7);
            foreach (var group in split)
            {
                Console.WriteLine($"{group.Count()} elements: " + string.Join(", ", group));
            }
        }
    }
}
