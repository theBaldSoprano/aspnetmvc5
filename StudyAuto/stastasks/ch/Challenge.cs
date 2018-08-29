using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StudyAuto.stastasks {
    class Challenge {
        public static String firstAndOthers(List<String> input) {
            return input.GroupBy(x => input.FirstOrDefault(), x => $" and {input.Count - 1} else")
                .Select(x => $"{x.Key}\\{x.Skip(1).Distinct().Aggregate("", (acc, val) => acc += val)}")
                .FirstOrDefault();
        }

        public static Dictionary<String, String> stasCookier(String input) {
            return input.Select((val, ind) => new { ch = val, i = ind })
                .GroupBy(x => new { interval = (int)x.i / 2000 })
                .Select((gr, ind) => new { gr_name = $"{"MOCK"}_{ind}", cookie_part = String.Join("", gr.Select(x => x.ch)) })
                .ToDictionary(x => x.gr_name, x => x.cookie_part);
        }

        public static Dictionary<String, String> myCookier(String input) {
            return input
                .Select((c, i) => i).AsParallel()
                .Where(i => i % 2000 == 0)
                .Select(i => new { ind = i, val = String.Concat(input.Skip(i).Take(2000)) })
                .OrderBy(x => x.ind)
                .ToDictionary(x => x.ind.ToString(), x => x.val.ToString());
        }



        public static void Main(string[] f) {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //getSun(10000, '*');
            //sw.Stop();
            //Console.WriteLine($"greg is ${sw.ElapsedMilliseconds}");
            //sw = new Stopwatch();
            //sw.Start();
            //stasGetSun(10000, '*');
            //sw.Stop();
            //Console.WriteLine($"stas is ${sw.ElapsedMilliseconds}");
            var array = Enumerable.Range(1, 10000000).Where(x => x != 7).ToArray();

            //Console.ReadKey();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int stas = getInt(array);
            sw.Stop();
            Console.WriteLine($"stas is ${sw.ElapsedMilliseconds}");
            Console.WriteLine(stas);

            sw = new Stopwatch();
            sw.Start();
            int skip = getInt2(array);
            sw.Stop();
            Console.WriteLine($"skip is ${sw.ElapsedMilliseconds}");
            Console.WriteLine(skip);

            sw = new Stopwatch();
            sw.Start();
            int intersect = getInt3(array);
            sw.Stop();
            Console.WriteLine($"intersect is ${sw.ElapsedMilliseconds}");
            Console.WriteLine(skip);

            sw = new Stopwatch();
            sw.Start();
            var grisha = findElem(array, array.Length + 1);
            sw.Stop();
            Console.WriteLine($"grisha is ${sw.ElapsedMilliseconds}");
            Console.WriteLine(grisha);

            sw = new Stopwatch();
            sw.Start();
            var another = anotherfindElem(array, array.Length + 1);
            sw.Stop();
            Console.WriteLine($"another is ${sw.ElapsedMilliseconds}");
            Console.WriteLine(another);

            Console.ReadKey();


        }

        public static Dictionary<int, string> getSun(int count, char c) {
            return
                Enumerable.Range(1, count * count)
                .Select(x => new { i = x, sun = c })
                .GroupBy(x => ((int)x.i - 1) / count + 1)
                .Select(x => new { _key = x.Key, _val = x.Skip(count - x.Key).Aggregate("", (acc, val) => acc += val.sun) })
                .ToDictionary(x => x._key, x => x._val);

        }

        public static Dictionary<int, string> stasGetSun(int count, char c) {
            return Enumerable.Range(1, count).ToDictionary(x => x, x => String.Join(c.ToString(), new string[x + 1]));
        }

        public static long findElem(int[] array, int last) {
            long sum1 = 0;

            //  long sum4 = array.Aggregate(0,(acc,val)=>acc+=val);

            // long sum1 = array.Sum();


            for (int i = 0; i < array.Length; i++) {
                sum1 += array[i];
            }
            long sum2 = 0;
            for (long i = 1; i <= last; i++) {
                sum2 += i;
            }
            return sum2 - sum1;
        }

        public static int getInt(int[] array) {
            return array.OrderBy(x => x).Where((x, ind) => x > ind + 1).FirstOrDefault() - 1;
        }

        public static int getInt2(int[] array) {
            return array.OrderBy(x => x).SkipWhile((x, ind) => x == ind + 1).FirstOrDefault() - 1;
        }

        public static int getInt3(int[] array) {
            return array.Intersect(Enumerable.Range(1, array.Length + 1).ToArray()).FirstOrDefault() - 1;
        }

        public static long anotherfindElem(int[] array, long last) {
            long sum1 = 0;
            for (long i = 0; i < array.Length; i++) {
                sum1 += array[i];
            }

            long sum2 = (last * (last + 1) / 2);
            return sum2 - sum1;
        }
    }
}
