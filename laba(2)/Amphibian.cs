using System;

class Amphibian : Animal
{
  private string skinMoisture;

  public Amphibian(string name, int age, string habitat, string foodType, string skinMoisture)
      : base(name, age, habitat, foodType)
  {
    this.skinMoisture = skinMoisture;
  }

  public string SkinMoisture
  {
    get { return skinMoisture; }
  }

  public override string GetInfo()
  {
    return base.GetInfo() + ", Type: Amphibian, Skin: " + skinMoisture;
  }
}