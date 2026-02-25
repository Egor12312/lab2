using System;

class Mammal : Animal
{
  private bool hasFur;

  public Mammal(string name, int age, string habitat, string foodType, bool hasFur)
      : base(name, age, habitat, foodType)
  {
    this.hasFur = hasFur;
  }

  public bool HasFur
  {
    get { return hasFur; }
  }

  public override string GetInfo()
  {
    string furText;

    if (hasFur == true)
    {
      furText = "yes";
    }
    else
    {
      furText = "no";
    }

    return base.GetInfo() + ", Type: Mammal, Fur: " + furText;
  }
}