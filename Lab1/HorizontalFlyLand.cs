namespace Lab1;

public class HorizontalFlyLand : Aircraft
{
    public HorizontalFlyLand(string name, int maxHorizontalSpeed, int maxAltitude) : base(name, maxHorizontalSpeed, maxAltitude)
    {
    }

    public override void Land()
    {
        Console.WriteLine("У меня горизонтальная посадка");
    }
}