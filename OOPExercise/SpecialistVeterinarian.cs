using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal class SpecialistVeterinarian : GeneralVeterinarian
    {
        private string specialty;
        public SpecialistVeterinarian(string name, string specialty) : base(name)
        {
            this.specialty = specialty;
        }
        public override string ExaminePet(Pet pet)
        {
            return $"Specialist examination of {pet.GetName()} by {GetName()} (Specialty: {specialty}): Healthy.";
        }
    }
}
