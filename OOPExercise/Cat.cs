using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal class Cat : Pet
    {
        private string color;

        public Cat(string name, int age, string color) : base(name, age)
        {
            this.color = color;
        }
        public override string Eat()
        {
            return "Cats eat cat food";
        }

        public override string MakeSound()
        {
            return "Cats meow";
        }
    }
}
