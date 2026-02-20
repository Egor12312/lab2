using System;

public class Animal
{
  public string Name;
  public int Age;
  public string Habitat;
  public string DietType;

  public double Weight;
  public string Color;

  public Animal(string name, int age, string habitat, string dietType)
  {
    Name = name;
    Age = age;
    Habitat = habitat;
    DietType = dietType;
  }

  public void ShowInfo()
  {
    Console.WriteLine($"Кличка: {Name}");
    Console.WriteLine($"Возраст: {Age}");
    Console.WriteLine($"Среда: {Habitat}");
    Console.WriteLine($"Питание: {DietType}");
    Console.WriteLine($"Вес: {Weight} кг");
    Console.WriteLine($"Окрас: {Color}");
  }
}