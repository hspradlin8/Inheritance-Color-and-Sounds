using System;
public class Ram : Vehicle
{ // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram takes a hard right; taking down the stop sign with it.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram stops to get more beer.");
    }
}