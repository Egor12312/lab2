using System;

class Bird : Animal
{
  private double wingSpan;

  public Bird(string name, int age, string habitat, string foodType, double wingSpan)
      : base(name, age, habitat, foodType)
  {
    this.wingSpan = wingSpan;
  }

  public double WingSpan
  {
    get { return wingSpan; }
  }

  public override string GetInfo()
  {
    return base.GetInfo() + ", Type: Bird, Wingspan: " + wingSpan + " m";
  }
}