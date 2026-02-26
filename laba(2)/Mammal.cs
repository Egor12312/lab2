using System;

class Mammal : Animal
{
  private bool _hasFur;

  public Mammal(string name, int age, string habitat, string foodType, bool hasFur)
      : base(name, age, habitat, foodType)
  {
    _hasFur = hasFur;
  }

  public bool HasFur
  {
    get { return _hasFur; }
  }

  public override string GetInfo()
  {
    string furText;

    if (_hasFur == true)
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