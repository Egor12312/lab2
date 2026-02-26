using System;

class Bird : Animal
{
  private double _wingSpan;

  public Bird(string name, int age, string habitat, string foodType, double wingSpan)
      : base(name, age, habitat, foodType)
  {
    _wingSpan = wingSpan;
  }

  public double WingSpan
  {
    get { return _wingSpan; }
  }

  public override string GetInfo()
  {
    return base.GetInfo() + ", Type: Bird, Wingspan: " + _wingSpan + " m";
  }
}