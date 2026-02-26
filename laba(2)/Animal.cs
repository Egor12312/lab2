using System;

abstract class Animal
{
  private string _name;
  private int _age;
  private string _habitat;
  private string _foodType;

  public Animal(string name, int age, string habitat, string foodType)
  {
    _name = name;
    _age = age;
    _habitat = habitat;
    _foodType = foodType;
  }

  public string Name
  {
    get { return _name; }
  }

  public int Age
  {
    get { return _age; }
  }

  public string Habitat
  {
    get { return _habitat; }
  }

  public string FoodType
  {
    get { return _foodType; }
  }

  public virtual string GetInfo()
  {
    return "Name: " + _name +
           ", Age: " + _age +
           ", Habitat: " + _habitat +
           ", Food: " + _foodType;
  }
}