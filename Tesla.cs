using System;
public class Tesla : Vehicle
{ // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past.zzzZZZZZzzzz");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Telsa silently drifts to the right.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} Telsa stops silently in front of the murder's house.");
    }
}