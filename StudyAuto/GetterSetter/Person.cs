using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.GetterSetter {
    class Person {
        //variations of getters and setters
        private string _name;

        public string getName() {
            Console.Write("do something");
            return this._name;
        }

        public string Name {
            get {
                Console.WriteLine("im in getter");
                return this._name;
            }
            set {
                Console.WriteLine("im in SETTER");
                this._name = value;
            }
        }

        //just plain ol gs/etters
        public string Sirname { set; get; }
    }
}
