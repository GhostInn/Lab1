namespace Lab1;

public abstract class VerticalFlyLand : Aircraft
{
    public VerticalFlyLand(string name, int maxHorizontalSpeed, int maxAltitude) : base(name, maxHorizontalSpeed, maxAltitude)
    {
    }

    public override void Land()
    {
        Console.WriteLine("У меня вертикальная посадка");
    }
}