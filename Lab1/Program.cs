using Lab1;
public class Program
{
    static void Main(string[] args)
    {
        List<Aircraft> aircrafts = new List<Aircraft>
            {
                new FighterJet("Су-27", 1, 1, 1, 1),
                new Helicopter("Ми-24", 1, 1, 1, 1),
                new Bomber("Ту-4", 1, 1, 1, 1),
                new Convertiplane("Ми-30", 1, 1, 1, 1),
                new Quadcopter("Квадрокоптер", 1, 1, "Тип", "Связь")
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
        Console.WriteLine("Системы с вертикальным взлётом:");
        foreach (var aircraft in verticalTakeoffAircrafts)
        {
            Console.WriteLine($"- {aircraft.Name}");
        }

        Console.WriteLine("\nСистемы с горизонтальным взлетом:");
        foreach (var aircraft in horizontalTakeoffAircrafts)
        {
            Console.WriteLine($"- {aircraft.Name}");
        }
    }
}
//Эта программа определяет базовый класс `Aircraft` и производные классы `FighterJet`, `Helicopter`, `Bomber`, `Convertiplane` и `Quadcopter`. Каждый класс имеет соответствующие свойства, определенные в вашем вопросе.
//В методе `Main` создается список самолетов, который затем делится на два списка: `verticalTakeoffAircrafts` и `horizontalTakeoffAircrafts`. Затем программа выводит названия самолетов, относящихся к каждой группе.

