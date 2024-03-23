using Lab1;
public class Program
{
    static void Main(string[] args)//В методе Main написал список объектов класса Aircraft и его производных классов FighterJet,
                                   //Helicopter, Bomber, Convertiplane и Quadcopter. В искомые списки verticalTakeoffAircrafts и horizontalTakeoffAircrafts.
    {
        List<Aircraft> verticalTakeoffAircrafts = new List<Aircraft>
            {
                new Helicopter("Ми-24", 1, 1, 1, 1),
                new Convertiplane("Ми-30", 1, 1, 1, 1),
                new Quadcopter("Квадрокоптер", 1, 1, "Тип", "Связь")
            };

        List<Aircraft> horizontalTakeoffAircrafts = new List<Aircraft>
            {
                new FighterJet("Су-27", 1, 1, 1, 1),
                new Bomber("Ту-4", 1, 1, 1, 1),
            };

        //Потом выводятся названия всех объектов в списке verticalTakeoffAircrafts с помощью оператора foreach и строки $"- {aircraft.Name}".
        Console.WriteLine("Системы с вертикальным взлётом:");
        foreach (var aircraft in verticalTakeoffAircrafts)
        {
            Console.WriteLine($"{aircraft.Name}");
        }

        //Также со списком horizontalTakeoffAircrafts.
        Console.WriteLine("\nСистемы с горизонтальным взлетом:");
        foreach (var aircraft in horizontalTakeoffAircrafts)
        {
            Console.WriteLine($"{aircraft.Name}");
        }
    }
}
//В этой программе я определил базовый класс `Aircraft` и производные классы `FighterJet`, `Helicopter`, `Bomber`, `Convertiplane` и `Quadcopter`. Каждый класс имеет соответствующие свойства
//В методе `Main` создается два списка самолетов: `verticalTakeoffAircrafts` и `horizontalTakeoffAircrafts`. Затем программа выводит названия самолетов, относящихся к каждой системе взлета.

