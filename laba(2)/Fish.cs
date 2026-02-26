using System;

class Fish : Animal
{
  private string _waterType;

  public Fish(string name, int age, string habitat, string foodType, string waterType)
      : base(name, age, habitat, foodType)
  {
    _waterType = waterType;
  }

  public string WaterType
  {
    get { return _waterType; }
  }

  public override string GetInfo()
  {
    return base.GetInfo() + ", Type: Fish, Water: " + _waterType;
  }
}