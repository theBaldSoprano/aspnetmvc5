using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.OOP.Constructors {
    class Constructors {
        public static void Main(string[] ) {
            Person p = new Person { name = "tom" };
        }
    }
    class Person {
        public string name;
        public int age;
        //default call to constrctr will input all default values
        //by calling 1st 2st and 3nd constructors
        public Person() : this("Неизвестно") {
        }
        //second will take name and place age by default
        public Person(string name) : this(name, 18) {
        }
        //the most complete constrctr
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public void GetInfo() {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Door {
        private string name;
        public string Name => name;
        public void foo(int x) {

        }
        public long foo(long x) {
            return x;
        }

    }
}
