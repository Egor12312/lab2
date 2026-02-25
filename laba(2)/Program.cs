using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("ZOO");
    Console.WriteLine("===");

    AnimalManager manager = AnimalManager.Instance;

    CreateDemoAnimals(manager);
    RunMenu(manager);
  }

  static void CreateDemoAnimals(AnimalManager manager)
  {
    Mammal lion = new Mammal("Simba", 5, "Savanna", "Predator", true);
    Bird eagle = new Bird("Kesha", 3, "Mountains", "Predator", 2.3);
    Fish fish = new Fish("Nemo", 2, "Ocean", "Omnivore", "Salt");
    Reptile snake = new Reptile("Kaa", 4, "Jungle", "Predator", true);
    Amphibian frog = new Amphibian("Quak", 1, "Swamp", "Insects", "Moist");

    manager.AddAnimal(lion);
    manager.AddAnimal(eagle);
    manager.AddAnimal(fish);
    manager.AddAnimal(snake);
    manager.AddAnimal(frog);

    Console.WriteLine();
  }

  static void RunMenu(AnimalManager manager)
  {
    bool isWork;
    string choice, name;

    isWork = true;

    while (isWork == true)
    {
      Console.WriteLine("\n--- MENU ---");
      Console.WriteLine("1. Show all animals");
      Console.WriteLine("2. Find animal by name");
      Console.WriteLine("3. Add new animal");
      Console.WriteLine("4. Exit");
      Console.Write("Choose action: ");

      choice = Console.ReadLine();

      if (choice == "1")
      {
        manager.ShowAllAnimals();
      }
      else if (choice == "2")
      {
        Console.Write("Enter name: ");

        name = Console.ReadLine();

        manager.FindAnimalByName(name);
      }
      else if (choice == "3")
      {
        AddNewAnimal(manager);
      }
      else if (choice == "4")
      {
        Console.WriteLine("Goodbye!");
        isWork = false;
      }
      else
      {
        Console.WriteLine("Error! Choose 1, 2, 3 or 4.");
      }
    }
  }

  static void AddNewAnimal(AnimalManager manager)
  {
    string name, habitat, foodType, typeChoice;
    string furInput;
    string waterType;
    string venomInput;
    string skinMoisture;
    bool hasFur;
    bool isVenomous;
    int age;
    double wingSpan;

    Console.WriteLine("\n--- ADD NEW ANIMAL ---");

    Console.Write("Enter name: ");
    name = Console.ReadLine();

    Console.Write("Enter age: ");
    age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter habitat: ");
    habitat = Console.ReadLine();

    Console.Write("Enter food type: ");
    foodType = Console.ReadLine();

    Console.WriteLine("\nChoose type:");
    Console.WriteLine("1. Mammal");
    Console.WriteLine("2. Bird");
    Console.WriteLine("3. Fish");
    Console.WriteLine("4. Reptile");
    Console.WriteLine("5. Amphibian");
    Console.Write("Your choice: ");

    typeChoice = Console.ReadLine();

    Animal newAnimal = null;

    if (typeChoice == "1")
    {
      Console.Write("Has fur? (yes/no): ");

      furInput = Console.ReadLine();

      hasFur = false;

      if (furInput == "yes")
      {
        hasFur = true;
      }

      newAnimal = new Mammal(name, age, habitat, foodType, hasFur);
    }
    else if (typeChoice == "2")
    {

      Console.Write("Enter wingspan: ");
      wingSpan = Convert.ToDouble(Console.ReadLine());

      newAnimal = new Bird(name, age, habitat, foodType, wingSpan);
    }
    else if (typeChoice == "3")
    {

      Console.Write("Water type (fresh/salt): ");
      waterType = Console.ReadLine();

      newAnimal = new Fish(name, age, habitat, foodType, waterType);
    }
    else if (typeChoice == "4")
    {

      Console.Write("Is venomous? (yes/no): ");
      venomInput = Console.ReadLine();

      isVenomous = false;

      if (venomInput == "yes")
      {
        isVenomous = true;
      }

      newAnimal = new Reptile(name, age, habitat, foodType, isVenomous);
    }
    else if (typeChoice == "5")
    {

      Console.Write("Skin moisture: ");
      skinMoisture = Console.ReadLine();

      newAnimal = new Amphibian(name, age, habitat, foodType, skinMoisture);
    }
    else
    {
      Console.WriteLine("Wrong choice!");
      return;
    }

    if (newAnimal != null)
    {
      manager.AddAnimal(newAnimal);
    }
  }
}