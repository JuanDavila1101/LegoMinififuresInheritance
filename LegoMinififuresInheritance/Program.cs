using LegoMinififuresInheritance.Heads;
using System.Collections.Generic;

namespace LegoMinififuresInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      var head = new ConstructionWorker();

      head.Color = LegoColor.Red;

      var batmanHead = new BatmanHead();
      batmanHead.SayHi();


      var astronautHead = new AstronautHead();
      astronautHead.SayHi();

      // var weirdhead = new HeadBase();
      // you cannot make an istance of an abstract class 
      // b/c it's only used for inheritance

      var heads = new List<AstronautHead>() {astronautHead};


    }
  }
}
