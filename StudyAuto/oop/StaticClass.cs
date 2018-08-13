using System;

namespace StudyAuto.oop {
    class StaticClass {
        //only static fields and methods
        private static int _foo;
        private static int FOO {
            get {
                return _foo;
            }
            set {
                _foo = value;
            }
        }
        public static void makeFoo() {
            Console.WriteLine("well make all foo");
        }
    }
}
