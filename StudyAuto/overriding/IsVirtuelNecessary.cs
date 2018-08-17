using System;

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

            Animal alll = new Yourk();
            Console.WriteLine(alll.shout());
        }
    }
    class Animal {
        //AND HERE is the virtual property
        public virtual string Name { set; get; }
        public virtual string shout() {
            return ("its animal");
        }
    }
    class Dog : Animal {
        private string _name;
        //and here is the OVERRIDE of property
        
        public override string Name {
            set {
                _name = value + " the Dog";
            }
            get {
                return _name;
            }
        }
        //AND make it SEALED so it cant be overriden in the next inheriter
        public sealed override string shout() {
            
            return "its dog" + base.shout();
        }
    }
    class Yourk : Dog {
       // public override string shout() {
        //    return "hey its yoorlk";
        //}
    }
}
