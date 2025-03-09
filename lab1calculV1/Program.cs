using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1calculV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            string choice = Console.ReadLine();

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "2":
                    result = num1 - num2;
                    break;
                case "3":
                    result = num1 * num2;
                    break;
                case "4":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Ошибка: деление на ноль");
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}