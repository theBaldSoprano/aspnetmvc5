using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyAuto.shadowing;

namespace StudyAuto.generics {
    class Account<T> {
        public T id { get; set; }

        public Account(){
           // this.id = default(T);
            this.id = default(T);
            Console.WriteLine("im here");
        }
    }
}
