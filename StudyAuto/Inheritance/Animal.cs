using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.Inheritance {
    public abstract class Animal {

        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Animal(string name, int x, int y) {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public abstract Animal Reproduce();

        public abstract void MoveTo(int x, int y);

        public void Die(string deathcry) {
            Console.Write(deathcry);
            X = -1;
            Y = -1;
        }
    }

    //EXTENDS
    public class Fish : Animal {

        public ConsoleColor Flippers { get; set; }

        //HERE CALL TO PARENT CONSTRUCTOR
        public Fish(string name, int x, int y, ConsoleColor flippersColor) : base(name, x, y){
            this.Flippers = flippersColor;
        }

        public override void MoveTo(int x, int y) {
            this.Swim(x, y);
        }

        //OVERRIDING
        public override Animal Reproduce() {
            return new Fish(
                this.Name + "_child",
                this.X,
                this.Y,
                this.Flippers
            );
        }

        private void Swim(int x, int y) {
            Console.Write(String.Format("fish is swimming to %d, %d", x, y));
        }
    }
}
