using System;
namespace LegoMinififuresInheritance.Heads
{
  class ConstructionWorker : HeadBase
  {
    // properties The default is internal property class modifier
    public bool HasMullet { get; set; }
    //public LegoColor Color => LegoColor.Green;
    public int NumberOfTeeth { get; set; }
    public bool WearingTheHat { get; set; }

    public bool ToggleWorking()
    {
      WearingTheHat = !WearingTheHat;
      Console.WriteLine($"The construction worker head {(WearingTheHat ? "is" : "is not")} wearing its hard hat");
      return WearingTheHat;
    }

    public override void Spin()
    {
      if (NumberOfTeeth > 0)
      {
        NumberOfTeeth -= 1;
      }

      Console.WriteLine($"The {Color} construction worker head spins after being hit by it's girder ");
    }

    //public void SayHi()
    //{
    //  Console.WriteLine("The construction workers sais Hello.");
    //}


  }

  //enum LegoColor
  //{
  //  Yellow = 1, // explisit setting and the rest counsts after that
  //  White,
  //  Brown,
  //  Green,
  //  Red,
  //}


}
