using Lab1;
public class Program
{
    static void Main(string[] args)
    {
        List<Aircraft> aircrafts = new List<Aircraft>
            {
                new FighterJet("F-22", 2414, 19812, 1361, 2414),
                new Helicopter("Apache", 287, 6400, 12, 2),
                new Bomber("B-2", 1010, 16764, 18144, 524),
                new Convertiplane("V-22", 518, 7620, 152, 162),
                new Quadcopter("DJI Phantom 4", 72, 19685, "Consumer", "Wi-Fi")
            };

        List<Aircraft> verticalTakeoffAircrafts = new List<Aircraft>();
        List<Aircraft> horizontalTakeoffAircrafts = new List<Aircraft>();

        foreach (var aircraft in aircrafts)
        {
            if (aircraft is Helicopter || aircraft is Convertiplane || aircraft is Quadcopter)
            {
                verticalTakeoffAircrafts.Add(aircraft);
            }
            else
            {
                horizontalTakeoffAircrafts.Add(aircraft);
            }
        }
        Console.WriteLine("Vertical Takeoff Aircrafts:");
        foreach (var aircraft in verticalTakeoffAircrafts)
        {
            Console.WriteLine($"- {aircraft.Name}");
        }

        Console.WriteLine("\nHorizontal Takeoff Aircrafts:");
        foreach (var aircraft in horizontalTakeoffAircrafts)
        {
            Console.WriteLine($"- {aircraft.Name}");
        }
    }
}
//Эта программа определяет базовый класс `Aircraft` и производные классы `FighterJet`, `Helicopter`, `Bomber`, `Convertiplane` и `Quadcopter`. Каждый класс имеет соответствующие свойства, определенные в вашем вопросе.
//В методе `Main` создается список самолетов, который затем делится на два списка: `verticalTakeoffAircrafts` и `horizontalTakeoffAircrafts`. Затем программа выводит названия самолетов, относящихся к каждой группе.

