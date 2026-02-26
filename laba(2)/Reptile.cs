using System;

class Reptile : Animal
{
  private bool _isVenomous;

  public Reptile(string name, int age, string habitat, string foodType, bool isVenomous)
      : base(name, age, habitat, foodType)
  {
    _isVenomous = isVenomous;
  }

  public bool IsVenomous
  {
    get { return _isVenomous; }
  }

  public override string GetInfo()
  {
    string venomText;

    if (_isVenomous == true)
    {
      venomText = "yes";
    }
    else
    {
      venomText = "no";
    }

    return base.GetInfo() + ", Type: Reptile, Venomous: " + venomText;
  }
}