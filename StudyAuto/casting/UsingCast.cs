using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.casting {
    class UsingCast {
        public static void Main(string[] dd) {
            Animal al = new Dog("ff", 4);
            //to cast object using AS
            //if cants be cast - then var will be null
            //AS AS AS AS 
            Dog ddgg = al as Dog;


            //to check if object is of specific type
            //IS IS IS
            if(ddgg is Dog) {
                Console.WriteLine("it is!");
            }
        }
    }
    class Animal {
        string name;
        public Animal(string name) {
            this.name = name;
        }
    }
    class Dog : Animal {
        int legSize;
        public Dog(string name, int size) : base(name) {
            this.legSize = size;
        }
    }
}
