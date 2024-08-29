namespace OOPExercise
{
    internal class PetClinic
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>
            {
            new Dog("Buddy", 3, "golden Retriever"),
            new Cat("Whiskers", 2, "brown")
            };

            IVeterinarian generalVet = new GeneralVeterinarian("Dr. Smith");
            IVeterinarian specialistVet = new SpecialistVeterinarian("Dr. John", "Dermatology");

            foreach (Pet pet in pets)
            {
                Console.WriteLine($"Pet Name: {pet.GetName()}");
                Console.WriteLine($"Pet Age: {pet.GetAge()}");
                Console.WriteLine($"Pet Species: {pet.GetSpecies()}");
                Console.WriteLine($"Pet Sound: {pet.MakeSound()}");
                Console.WriteLine($"Pet Eats: {pet.Eat()}");

                Console.WriteLine(generalVet.ExaminePet(pet));
                Console.WriteLine(specialistVet.ExaminePet(pet));
                Console.WriteLine();
                Console.ReadLine(); 
            }
        }
    }
}