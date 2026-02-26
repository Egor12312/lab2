using System;
using System.Collections.Generic;

class AnimalManager
{
  private static AnimalManager s_instance;
  private List<Animal> animals;

  private AnimalManager()
  {
    animals = new List<Animal>();
  }

  public static AnimalManager Instance
  {
    get
    {
      if (s_instance == null)
      {
        s_instance = new AnimalManager();
      }

      return s_instance;
    }
  }

  public void AddAnimal(Animal animal)
  {
    if (animal != null)
    {
      animals.Add(animal);
      Console.WriteLine("Animal " + animal.Name + " added!");
    }
  }

  public void ShowAllAnimals()
  {
    if (animals.Count == 0)
    {
      Console.WriteLine("Animal list is empty!");
      return;
    }

    Console.WriteLine("\n--- ANIMAL LIST ---");

    for (int animalIndex = 0; animalIndex < animals.Count; ++animalIndex)
    {
      Console.WriteLine(animals[animalIndex].GetInfo());
      Console.WriteLine("---");
    }
  }

  public void FindAnimalByName(string searchName)
  {
    bool found;
    found = false;

    for (int animalIndex = 0; animalIndex < animals.Count; ++animalIndex)
    {
      if (animals[animalIndex].Name.ToLower() == searchName.ToLower())
      {
        Console.WriteLine("\n--- ANIMAL FOUND ---");
        Console.WriteLine(animals[animalIndex].GetInfo());
        Console.WriteLine("--------------------");

        found = true;
        break;
      }
    }

    if (found == false)
    {
      Console.WriteLine("Animal with name '" + searchName + "' not found!");
    }
  }
}