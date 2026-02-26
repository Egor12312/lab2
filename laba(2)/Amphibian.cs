using System;

class Amphibian : Animal
{
  private string _skinMoisture;

  public Amphibian(string name, int age, string habitat, string foodType, string skinMoisture)
      : base(name, age, habitat, foodType)
  {
    _skinMoisture = skinMoisture;
  }

  public string SkinMoisture
  {
    get { return _skinMoisture; }
  }

  public override string GetInfo()
  {
    return base.GetInfo() + ", Type: Amphibian, Skin: " + _skinMoisture;
  }
}