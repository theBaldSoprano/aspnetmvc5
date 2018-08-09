using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyAuto.GetterSetter;

namespace StudyAuto.EntryPoint {
    class EntryPoint {
        public static void Main(String[] args) {
            String[] lines = { "foo", "bar", "baz" };
            Console.WriteLine(lines[0]);
            Console.Out.WriteLine("");
  
            Console.BackgroundColor = ConsoleColor.Green;

            Person p = new Person();
            p.Name = "gregory";
            Console.WriteLine(p.Name);

            Console.Beep();


            Console.ReadKey();
        }
    }
}
