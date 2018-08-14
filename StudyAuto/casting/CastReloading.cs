using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.casting {
    class CastReloading {
        public static void Main(string[] dd) {
            Dimention d = new Dimention(4, 6, 6);
            //THIS IS IMPLICIT cast as written below
            Volume v = d;

            //and this is an EXPLICIT cast
            d = (Dimention)v;
        }
    }
    class Dimention {
        public Dimention(int x, int y, int z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    class Volume {
        int volume { get; set; }
        //IMPLICIT
        public static implicit operator Volume(Dimention d) {
            return new Volume { volume = d.X * d.Y * d.Z };
        }
        //EXPLICIT
        public static explicit operator Dimention(Volume v) {
            return new Dimention(v.volume / 3, v.volume / 3, v.volume / 3);
        }
    }
}
