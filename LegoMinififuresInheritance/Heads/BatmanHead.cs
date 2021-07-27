using System;

namespace LegoMinififuresInheritance.Heads
{
  class BatmanHead : HeadBase
  {
    public bool IsWearingMask { get; set; }
    public string Version { get; set; }
    public string FacialExpression { get; set; } = "Stoic";
    public bool WearingTheHat { get; set; }
    //public LegoColor Color => LegoColor.Black;

    public BatmanHead()
    {
      Color = LegoColor.Black;
    }


    public override void Spin()
    {
      WearingTheHat = !WearingTheHat;
      Console.WriteLine($"Where is the Joker");
    }


    public override void SayHi()
    {
      Console.WriteLine("I am Batman.");
    }








  }
}
