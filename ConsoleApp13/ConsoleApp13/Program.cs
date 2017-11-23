/*
 * Дисциплина: "Программирование"
 * Группа: БПИ173/2
 * Студент: Торилов Дмитрий
 * Вариант: 
 * Дата: 23.11.2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            const uint leftBound = 1,
                       rightBound = (uint)1E5;

            do
            {
                Class1[] class1arr = new Class1[5];
                for (int i = 0; i < 5; i++)
                {
                    class1arr[i] = new Class1(i);
                }

                Student s = new Student("Иванов", "Иван", 1);
                Console.WriteLine(s);
                Console.WriteLine($"{RandomHelper.NextDouble(1, 3)} {RandomHelper.NextDouble(1, 3)} {RandomHelper.NextDouble(1, 3)}");

                Console.WriteLine($"{class1arr[0].CountSmth}");
                // Объявление и ввод переменных
                Console.WriteLine($"a{3.15:F1}a{456:D5}{123,+5} {class1arr[0].CountSmth} {class1arr[4].FirstField}");
                double a;
                a = InputHelper.InputDoubleInRange("Пи", leftBound, rightBound);

                // Рассчёт значения функции в данной точке
                try
                {
                    checked
                    {

                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение");
                }

                Console.WriteLine("Продолжить? (N/n для завершения)");
            } while (!Console.ReadLine().ToLower().Equals("n"));

        }
    }
}
