using System;

class Fish : Animal
{
  private string waterType;

  public Fish(string name, int age, string habitat, string foodType, string waterType)
      : base(name, age, habitat, foodType)
  {
    this.waterType = waterType;
  }

  public string WaterType
  {
    get { return waterType; }
  }

  public override string GetInfo()
  {
    return base.GetInfo() + ", Type: Fish, Water: " + waterType;
  }
}