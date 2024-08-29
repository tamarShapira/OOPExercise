using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal class GeneralVeterinarian : IVeterinarian
    {
        private string name;

        public GeneralVeterinarian(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual string ExaminePet(Pet pet)
        {
            return $"General examination of {pet.GetName()}: Healthy.";
        }

    }
}
