using System;
public class Zero : Vehicle
{ // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero zoomed past. ZZZZOOOOOMMM!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero skidded left then right then off the road.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero stopped to show off his kung fu skills to some thugs.");
    }

}