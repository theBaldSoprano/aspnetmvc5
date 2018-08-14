using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.Null {
    class Null {
        public static void Main(string[] dd) {
            Person p = new Person();
            //null default examples
            //calls to the fields preceding with ? sign
            //thus returns null if null but not try to access a fiels of null var
            //after double sign ?? there is a default value that will be put in ad variable
            Address ad = p?.pet?.address ?? new Address();
        }
    }
    class Person {
        public Address address;
        public Pet pet;
        public int goo;

    }
    class Pet {
        public Address address;

    }
    class Address {

    }
}
