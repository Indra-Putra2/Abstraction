using System;

namespace Abstraction.AbstractClass
{
  public class Laptop : Hardware
  {
    public override void Merek()
    {
      Console.WriteLine("Laptop Merek Toshiba");
      Console.WriteLine("Model Satellite L745");
    }
  }
}