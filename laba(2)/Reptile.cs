using System;

class Reptile : Animal
{
  private bool isVenomous;

  public Reptile(string name, int age, string habitat, string foodType, bool isVenomous)
      : base(name, age, habitat, foodType)
  {
    this.isVenomous = isVenomous;
  }

  public bool IsVenomous
  {
    get { return isVenomous; }
  }

  public override string GetInfo()
  {
    string venomText;

    if (isVenomous == true)
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