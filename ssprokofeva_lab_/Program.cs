using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ssprokofeva_lab_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("задание 1.");
            Console.WriteLine(Math.Round(Math.E,1) + "/n");
            // задание 2. Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("задание 2.");
            Console.WriteLine(50);
            Console.WriteLine(10);
            // задание 3. Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("задание 3.");
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            // задание 4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("задание 4.");
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine(10);
            int c = a + 10;
            Console.WriteLine(c);
            Console.ReadLine();
            // задание 5. Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("задание 5.");
            Console.WriteLine("Введите длину стороны квадрата");
            double длина = double.Parse(Console.ReadLine());
            double perimetr = 4 * длина;
            Console.WriteLine("Периметр: {0}", perimetr);
            // задание 6. Дан радиус окружности. Найти длину окружности и площадь круга.
            int radius;
            double length;
            double area;
            Console.WriteLine("Введите радиус окружности: ");
            radius = int.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
            length = 2 * Math.PI * radius;
            area = Math.Round(area, 2);
            length = Math.Round(length, 2);
            Console.WriteLine("Площадь: " + area);
            Console.WriteLine("Длина: " + length);
            Console.ReadLine();
            // задание 7. Найти значение y=cos(x).
            Console.WriteLine("задание 6.");
            Console.WriteLine("Введите значение x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"y = cos({x} = {y}");
            // задание 8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("pадание 8.");
            Console.WriteLine("Введите длину основания a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину основания b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту h");
            double h = Convert.ToDouble(Console.ReadLine());
            double per = Math.Sqrt(Math.Pow(Math.Abs(a - b) / 2, 2) + Math.Pow(h, 2) * 2 + a + b);
            // задание 9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили X кг конфет, y  кг печенья и z кг яблок.
            Console.WriteLine("задание 9.");
            Console.WriteLine("Введите стоимость 1 кг конфет:");
            double ценаконф = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг печенья:");
            double ценапеч = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг яблок:");
            double ценаябл = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество кг конфет:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество кг печенья:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество кг яблок:");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Общая стоимость покупки:");
            // задание 12.  Программа для подсчета периметра и площади фигур (треугольник,
            //четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
            //будет считать – площадь или периметр.Задаётся все необходимые значения, а на
            //основе полученных результатов, программа должна подсчитать, какими могли бы
            //быть периметры или площади остальных фигур.
           Console.WriteLine("задание 12.");
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Четырехугольник");
            Console.WriteLine("3. Круг");
            int figure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Что хотите вычислить? (1 - Площадь, 2 - Периметр)");
            int deistv = Convert.ToInt32(Console.ReadLine());

            if (figure == 1) // Треугольник
            {
                if (deistv == 1) // Площадь
                {
                    Console.Write("Введите основание: ");
                    double osn = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту: ");
                    double h1 = Convert.ToDouble(Console.ReadLine());
                    double area = 0.5 * osn * h1;
                    Console.WriteLine("Площадь треугольника равна " + area);
                }
                else // Периметр
                {
                    Console.Write("Введите длины сторон: ");
                    double a12_1 = Convert.ToDouble(Console.ReadLine());
                    double b12_1 = Convert.ToDouble(Console.ReadLine());
                    double c12_1 = Convert.ToDouble(Console.ReadLine());
                    double perimeter1 = a12_1 + b12_1 + c12_1;
                    Console.WriteLine("Периметр треугольника: " + perimeter1);
                }
            }
            else if (figure == 2) // Четырехугольник
            {
                if (deistv == 1) // Площадь
                {
                    Console.Write("Введите длину: ");
                    double dlina = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите ширину: ");
                    double shirina = Convert.ToDouble(Console.ReadLine());
                    double area1 = dlina * shirina;
                    Console.WriteLine("Площадь четырехугольника: " + area1);
                }
                else // Периметр
                {
                    Console.Write("Введите длины сторон: ");
                    double a12_2 = Convert.ToDouble(Console.ReadLine());
                    double b12_2 = Convert.ToDouble(Console.ReadLine());
                    double c12_2 = Convert.ToDouble(Console.ReadLine());
                    double d12_2 = Convert.ToDouble(Console.ReadLine());
                    double perimeter2 = a12_2 + b12_2 + c12_2 + d12_2;
                    Console.WriteLine("Периметр четырехугольника: " + perimeter2);
                }
            }
            else if (figure == 3) // Круг
            {
                Console.Write("Введите радиус: ");
                double r1 = Convert.ToDouble(Console.ReadLine());
                if (deistv == 1) // Площадь
                {
                    double area2 = Math.PI * r1 * r1;
                    Console.WriteLine("Площадь круга: " + area2);
                }
                else // Периметр
                {
                    double per = 2 * Math.PI * r1;
                    Console.WriteLine("Периметр круга: " + per);
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор фигуры.");
            }

        }  







        }
    }
}
