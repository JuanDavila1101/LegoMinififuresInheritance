using System;

namespace LegoMinififuresInheritance.Heads
{
  // The abstract is defining the idea of a method
  abstract class HeadBase
  {
    public LegoColor Color { get; set; }

    public virtual  void SayHi()
    {
      Console.WriteLine("Hi");
    }

    // The abstract is forcing the inherited classes to have this behavior
    // The class that is inheriting has to implement this method 
    public abstract void Spin();
    // and what ever uses it must have override in it's method

  }
}
