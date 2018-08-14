using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.overriding {
    class IsVirtuelNecessary {
        //yes 
        //it is necessary to mark method to be overrided
        // as virtual method
       
        public static void Main(string[] dd) {
            Dog dog = new Dog();
            Console.WriteLine("it must be dog " + dog.shout());

            Animal al = dog;
            Console.WriteLine("it must be dog " + al.shout());

            al = new Animal();
            Console.WriteLine("it must be animal " + al.shout());

            //yep so its all awright
        }
    }
    class Animal {
        public virtual string shout() {
            return ("its animal");
        }
    }
    class Dog : Animal {
        public override string shout() {
            return "its dog";
        }
    }
}
