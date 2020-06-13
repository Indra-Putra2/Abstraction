using System;

using Abstraction.Interface;

namespace Abstraction
{
  class MainClass 
  {
    public static void Main (string[] args) 
    {
      /*Hardware hardware;

      hardware = new Laptop();
      hardware.Merek();*/

      IHardware hardware;

      hardware = new Laptop();
      hardware.Merek();

      Console.ReadKey();
    }
  }
}