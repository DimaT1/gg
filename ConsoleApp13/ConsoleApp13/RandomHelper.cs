using System;

namespace ConsoleApp13
{
    /// <summary>
    /// Класс упрощает работу с Random
    /// </summary>
    class RandomHelper
    {
        static Random r = new Random();

        /// <summary>
        /// Метод возвращает случайное целое число из диапазона [l; r] (на базе стандартного Random)
        /// </summary>
        /// <param name="l">Нижняя граница промежутка</param>
        /// <param name="r">Верхняя граница промежутка</param>
        /// <returns>Случайное целое число из диапазона [l; r]</returns>
        public static int NextInt(int l, int r)
        {
            return RandomHelper.r.Next(l, r + 1);
        }

        /// <summary>
        /// Метод возвращает случайное дробное число из диапазона [l; r] (на базе стандартного Random)
        /// </summary>
        /// <param name="l">Нижняя граница промежутка</param>
        /// <param name="r">Верхняя граница промежутка</param>
        /// <returns>Случайное дробное число из диапазона [l; r]</returns>
        public static double NextDouble(double l, double r)
        {
            return l + RandomHelper.r.NextDouble() * (r - l);
        }
    }
}
