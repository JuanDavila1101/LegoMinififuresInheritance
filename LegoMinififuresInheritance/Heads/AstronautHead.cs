using System;

namespace LegoMinififuresInheritance.Heads
{
  class AstronautHead : HeadBase
  {
    public LegoColor Color { get; set; }
    public bool WearingHelmet { get; set; }
    public bool IsWearingMask { get; set; }
    public FacialHair FacialHair { get; set; }


    public override void Spin()
    {
      Console.WriteLine($"The astronaut head spins to ground control....");
    }


    public override void SayHi()
    {
      base.SayHi();
      Console.WriteLine("I am The Astronaut.");
    }


    public void Shave()
    {
      Console.WriteLine($"The Astronaut shaves its {FacialHair}.");
      FacialHair = FacialHair.None;
    }




  }
}
