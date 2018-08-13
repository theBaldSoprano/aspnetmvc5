using System;

namespace StudyAuto.Tuple {
    class Program {
        static void Main(string[] fff) {
            Person p = new Person();

        }
    }
    class Person {
        public string name;
        public int age;

        public Person() : this("Неизвестно") {
        }
        public Person(string name) : this(name, 18) {
        }
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public void GetInfo() {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
}