using System;

namespace RememberYourPets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pluto = new Pet("dog", "Pluto");
            Pet figaro = new Pet("cat", "Figaro");
            
            Pet[] pets = new Pet[] {pluto, figaro};

            Console.WriteLine("Your pets are:");

            foreach (Pet pet in pets)
            {
                Console.WriteLine($"A {pet.Species} called {pet.Name}");
            }
        }
    }
}
