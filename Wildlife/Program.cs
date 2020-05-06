using System;
using System.Collections.Generic;
using Safari.Animals;

namespace Safari
{
  public class Program
  {
    public static Safari.Animals.Residents AddAnimal()
    {
      Console.WriteLine("Enter new animal name: ");
      string name = Console.ReadLine();
      Console.WriteLine("Enter new animal species: ");
      string species = Console.ReadLine();
      Console.WriteLine("Enter new animal sex: ");
      string sex = Console.ReadLine();
      Console.WriteLine("Enter new animal biome: ");
      string biome = Console.ReadLine();
      Residents animal = new Residents(name, species, sex, biome);
      return animal;
    }
    public static void Main()
    {
      List<Residents> AllAnimals = new List<Residents>(0);

      Console.WriteLine("Would you like to add a new animal? Y/N");
      string addResponse = Console.ReadLine();

      
      if (addResponse == "y" || addResponse == "Y")
      {
        Safari.Animals.Residents animal = AddAnimal();
        AllAnimals.Add(animal);
      }
      foreach (Safari.Animals.Residents animal in AllAnimals)
      {
        Console.WriteLine(animal.GetBiome());
      }
    }
  }
}