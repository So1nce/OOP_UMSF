using System;
using System.Text;

namespace GeometryCalculator
{
    class Program
    {
        // Перерахування з необхідними константами
        enum ShapeType
        {
            Triangle,
            Rectangle
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Обчислення площі фігур");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Оберіть тип фігури:");
            Console.WriteLine("1. Трикутник");
            Console.WriteLine("2. Прямокутник");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateTriangleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("Обчислення площі трикутника");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Введіть довжину основи трикутника:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть висоту трикутника:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseLength * height;

            Console.WriteLine($"Площа трикутника: {area}");
        }

        static void CalculateRectangleArea()
        {
            Console.WriteLine("Обчислення площі прямокутника");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Введіть ширину прямокутника:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть висоту прямокутника:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;

            Console.WriteLine($"Площа прямокутника: {area}");
        }
    }
}