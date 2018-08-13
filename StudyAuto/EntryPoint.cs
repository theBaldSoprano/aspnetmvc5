using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyAuto.GetterSetter;
using StudyAuto.MyString;

namespace StudyAuto {
    class EntryPoint {
        public static void Main(String[] args) {
            {
                String[] lines = { "foo", "bar", "baz" };
                Console.WriteLine(lines[0]);
                Console.Out.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Green;
                Person p = new Person();
                p.Name = "gregory";
                Console.WriteLine(p.Name);

                Console.ReadKey();
                Word dic = new Word("foo");
                Console.ReadKey();
                Console.Write(dic.word);
            }


            object o = "ddd";

            Console.WriteLine("type is " + o.GetType().Name);

            Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
