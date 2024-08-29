using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal class Dog : Pet
    {
        private string breed;

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }
        public override string Eat()
        {
            return "Dogs eat dog food";
        }

        public override string MakeSound()
        {
            return "Dogs bark";
        }
    }
}
