using System;

abstract class Animal
{
  private string name;
  private int age;
  private string habitat;
  private string foodType;

  public Animal(string name, int age, string habitat, string foodType)
  {
    this.name = name;
    this.age = age;
    this.habitat = habitat;
    this.foodType = foodType;
  }

  public string Name
  {
    get { return name; }
  }

  public int Age
  {
    get { return age; }
  }

  public string Habitat
  {
    get { return habitat; }
  }

  public string FoodType
  {
    get { return foodType; }
  }

  public virtual string GetInfo()
  {
    return "Name: " + name +
           ", Age: " + age +
           ", Habitat: " + habitat +
           ", Food: " + foodType;
  }
}