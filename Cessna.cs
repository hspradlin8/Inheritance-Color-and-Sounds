  using System;
  public class Cessna : Vehicle
  { // Propellor light aircraft
      public double FuelCapacity { get; set; }

      public void RefuelTank() { }
      public override void Drive()
      {
          Console.WriteLine($"The {MainColor} Cessna flew above. ZOOOOOMMMM!!!!!");
      }
      public override void Turn()
      {
          Console.WriteLine($"The {MainColor} Cessan  dipped down into the trees.");
      }

      public virtual void Stop()
      {
          Console.WriteLine($"The {MainColor} Cessna stops to pick up chicks.");
      }

  }