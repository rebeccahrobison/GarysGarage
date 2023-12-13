namespace Garage;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla blazes by you. RREeeeeeee!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Tesla screeches while turning {direction}");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
    }
}