using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tusk 1
            double a = 3.4;
            double b = 2.1;
            Console.WriteLine("Введіть значення x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if (x > 1)
            {
                y = a * Math.Exp(-b * x) * Math.Cos(Math.PI * x);
            }
            else if (x <= -1)
            {
                y = Math.Sqrt(Math.Pow(x - 5, 2) / Math.Pow(x + 1, 2));
            }
            else
            {
                y = 0;
            }
            Console.WriteLine($"Значення y: {y}");
            Console.ReadKey();
            //end



            //tusk2
            Console.WriteLine("task 2");
           Console.WriteLine("Введіть координати x і y:");
           double c = Convert.ToDouble(Console.ReadLine());
           double v = Convert.ToDouble(Console.ReadLine());

           if (c == 0 && v == 0)
           {
               Console.WriteLine("Точка знаходиться в початку координат.");
           }
           else if (c == 0)
           {
               Console.WriteLine("Точка знаходиться на осі Y.");
           }
           else if (v == 0)
           {
               Console.WriteLine("Точка знаходиться на осі X.");
           }
           else if (c > 0 && v > 0)
           {
               Console.WriteLine("Точка знаходиться в першій чверті.");
           }
           else if (c < 0 && v > 0)
           {
               Console.WriteLine("Точка знаходиться в другій чверті.");
           }
           else if (c < 0 && v < 0)
           {
               Console.WriteLine("Точка знаходиться в третій чверті.");
           }
           else if (c > 0 && v < 0)
           {
               Console.WriteLine("Точка знаходиться в четвертій чверті.");
           }
           Console.ReadKey();
            //end

            //tusk 3
            Console.WriteLine("tusk3");

            Console.WriteLine("Введіть перше число (r):");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число (t):");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Виберіть операцію: 1 - додавання, 2 - віднімання, 3 - множення, 4 - ділення, 5 - піднесення до степеня:");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case 1:
                    result = r + t;
                    break;
                case 2:
                    result = r - t;
                    break;
                case 3:
                    result = r * t;
                    break;
                case 4:
                    if (t != 0)
                        result = r / t;
                    else
                        Console.WriteLine("Помилка: ділення на нуль!");
                    break;
                case 5:
                    result = Math.Pow(r, t);
                    break;
                default:
                    Console.WriteLine("Невірний номер операції.");
                    break;
            }

            if (operation >= 1 && operation <= 5)
                Console.WriteLine("Результат: " + result);
                Console.ReadKey();
        }
    }

}
