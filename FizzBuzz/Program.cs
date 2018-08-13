using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {
            List<string> result = new List<string>();
            Stopwatch stopwatch = new Stopwatch();
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); // Use only the second core 
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 2000) {
                //Console.WriteLine("...warming");
            }
            stopwatch.Stop();
            stopwatch.Reset();

            for (int i = 0; i < 50; i++) {

                stopwatch.Start();
                IEnumerable<int> nums = Enumerable.Range(1, 1000000);
                var vals = new[] { new { word = "fizz", num = 3 }, new { word = "buzz", num = 5 } };
                var lst = nums
                    .SelectMany(num => vals, (n, v) => new { n, v })
                    .Select(x => new { n = x.n, v = x.v, r = x.n % x.v.num })
                    .Where(x => x.r == 0)
                    .GroupBy(x => x.n)
                    .Select(x => new {
                        k = x.Key,
                        vl = x.Select(g => g.v.word).Aggregate<string, string>("", (acc, next) => acc + next)
                    }
                    ) 
                    .ToList();
                    //.ForEach(x => Console.WriteLine($"{x.k} -- {x.vl}"));
                result.Add("functional: " + (stopwatch.ElapsedMilliseconds));
                stopwatch.Stop();
                stopwatch.Reset();


                // на вход коллекция строк
                // на выходе значение первого элемента
                // + количество строк "стул и еще 2 элемента"

                stopwatch.Start();
                List<string> list = new List<string>();
                for (int j = 1; j <= 10000000; j++) {
                    if (j % 3 == 0 && j % 5 == 0) {
                        list.Add("fizzbuzz");
                        //Console.WriteLine("FizzBuzz");
                    } else if (j % 5 == 0) {
                        list.Add("buzz");
                        //Console.WriteLine("Buzz");
                    } else if (j % 3 == 0) {
                        list.Add("fizz");
                        //Console.WriteLine("Fizz");
                    }
                }
                result.Add("imperative: " + (stopwatch.ElapsedMilliseconds));
                stopwatch.Stop();
                result.Add("-------------------------------");
                stopwatch.Reset();
            }

            result.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();

        }
    }
    class FB {
        private void foo() {
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
            }
            Console.ReadKey();
        }

    }
}