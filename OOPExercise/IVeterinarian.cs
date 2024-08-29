using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal interface IVeterinarian
    {
        string GetName();
        string ExaminePet(Pet pet);
    }
}
