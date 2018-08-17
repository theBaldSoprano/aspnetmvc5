using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.shadowing {
    class HowToShadow {
        public static void Main(string[] f) {
            Animal al = new Animal();
            Animal la = new Animal();
            if (al.GetHashCode() == la.GetHashCode()) {
                Console.WriteLine("bingo");
            }
            if (al.GetType() == typeof(Animal)) {
                if(al.GetType() is Animal) {


                }
            }
        }
    }
    class Animal {
        public void scream() {
            Console.WriteLine("animal");
        }
        public override int GetHashCode() {
            return 0b101010001010110;
        }
    }
    class Dog : Animal {
        public new void scream() {
            Console.WriteLine("dog");
        }
    }
}
