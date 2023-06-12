using System;
using System.Collections.Generic;
using System.Text;

struct Meteo
{
    public string DayOfWeek;
    public int Temperature;
    public int Precipitation;

    public string GetInfo()
    {
        return $"{DayOfWeek}; {Temperature}; {Precipitation}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<Meteo> meteoList = new List<Meteo>();

        // Ввід даних з клавіатури
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Введіть дані для дня {0}:", i + 1);
            Console.Write("День тижня: ");
            string dayOfWeek = Console.ReadLine();
            Console.Write("Температура: ");
            int temperature = int.Parse(Console.ReadLine());
            Console.Write("Опади: ");
            int precipitation = int.Parse(Console.ReadLine());

            Meteo meteo = new Meteo
            {
                DayOfWeek = dayOfWeek,
                Temperature = temperature,
                Precipitation = precipitation
            };

            meteoList.Add(meteo);
        }

        Console.WriteLine("Список Meteo:");

        // Вивід списку на екран за допомогою методу GetInfo()
        foreach (Meteo meteo in meteoList)
        {
            Console.WriteLine(meteo.GetInfo());
        }

        // Знайти кількість днів, коли йшов сніг
        int snowDays = 0;
        foreach (Meteo meteo in meteoList)
        {
            if (meteo.Temperature <= 0)
            {
                snowDays++;
            }
        }
        Console.WriteLine("Кількість днів, коли йшов сніг: " + snowDays);

        // Знайти загальну кількість опадів у дощі
        int rainPrecipitation = 0;
        foreach (Meteo meteo in meteoList)
        {
            if (meteo.Temperature > 0)
            {
                rainPrecipitation += meteo.Precipitation;
            }
        }
        Console.WriteLine("Загальна кількість опадів у дощі: " + rainPrecipitation);
    }
}