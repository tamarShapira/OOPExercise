using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal abstract class Pet
    {
        private string name;
        private int age;
        protected string species;

        protected Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
            species = GetType().Name;
        }
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetSpecies()
        {
            return GetType().Name;
        }
        public abstract string MakeSound();
        public abstract string Eat();

    }
}
