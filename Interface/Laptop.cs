using System;

namespace Abstraction.Interface
{
  public class Laptop : IHardware
  {
    public void Merek()
    {
      Console.WriteLine("Laptop Merek Toshiba");
      Console.WriteLine("Model Satellite L745");
    }
  }
}