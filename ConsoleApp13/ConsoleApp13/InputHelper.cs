/*
    Файл класса InputHelper
    Предназначен для упрощения диалога с пользователем во время ввода информации
 */

using System;

namespace ConsoleApp13
{
    class InputHelper
    {
        /// <summary>
        /// Метод ввода дробного числа,
        /// реализует цикличный ввод
        /// </summary>
        /// <param name="str">Строка для диалога с пользователем</param>
        /// <returns>Введённое число</returns>
        public static double InputDouble(string str)
        {
            double d;
            string input;
            do
            {
                Console.Write(str);
                input = Console.ReadLine();
            } while (!double.TryParse(input, out d));
            return d;
        }

        /// <summary>
        /// Метод ввода целого числа,
        /// реализует цикличный ввод
        /// </summary>
        /// <param name="str">Строка для диалога с пользователем</param>
        /// <returns>Введённое число</returns>
        public static int InputInt(string str)
        {
            int d;
            string input;
            do
            {
                Console.Write(str);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out d));
            return d;
        }

        /// <summary>
        /// Метод ввода целого неотрицательного числа,
        /// реализует цикличный ввод
        /// </summary>
        /// <param name="str">Строка для диалога с пользователем</param>
        /// <returns>Введённое число</returns>
        public static uint InputUInt(string str)
        {
            uint d;
            string input;
            do
            {
                Console.Write(str);
                input = Console.ReadLine();
            } while (!uint.TryParse(input, out d));
            return d;
        }

        /// <summary>
        /// Метод проверки принадлежности числа a промежутку [l; r]
        /// </summary>
        /// <param name="a">Число, принадлежность которого необходимо проверить</param>
        /// <param name="l">Левая граница промежутка</param>
        /// <param name="r">Правая граница промежутка</param>
        /// <returns>Принадлежность числа промежутку</returns>
        static bool IsInRange(uint a, uint l, uint r)
        {
            return (l <= a) && (a <= r);
        }

        /// <summary>
        /// Метод проверки принадлежности числа a промежутку [b; c]
        /// </summary>
        /// <param name="a">Число, принадлежность которого необходимо проверить</param>
        /// <param name="b">Левая граница промежутка</param>
        /// <param name="c">Правая граница промежутка</param>
        /// <returns>Принадлежность числа промежутку</returns>
        static bool IsInRange(double a, double l, double r)
        {
            return (l <= a) && (a <= r);
        }


        /// <summary>
        /// Метод ввода целого неотрицательного числа в заданном диапазоне, реализованы диалог с пользователем и циклический ввод
        /// </summary>
        /// <param name="str">Строка для диалога с пользователем</param>
        /// <param name="leftBound">Левая граница промежутка</param>
        /// <param name="rightBound">Правая граница промежутка</param>
        /// <returns>Введённое число</returns>
        public static uint InputUIntInRange(string str, uint leftBound, uint rightBound)
        {
            uint res;
            do
            {
                res = InputUInt($"Введите число {str} из диапазона [{leftBound}; {rightBound}]: ");
            } while (!IsInRange(res, leftBound, rightBound));
            return res;
        }

        /// <summary>
        /// Метод ввода целого неотрицательного числа в заданном диапазоне, реализован циклический ввод
        /// </summary>
        /// <param name="leftBound">Левая граница промежутка</param>
        /// <param name="rightBound">Правая граница промежутка</param>
        /// <returns>Введённое число</returns>
        public static uint InputUIntInRange(uint leftBound, uint rightBound)
        {
            uint res;
            do
            {
                res = InputUInt($"Введите число из диапазона [{leftBound}; {rightBound}]: ");
            } while (!IsInRange(res, leftBound, rightBound));
            return res;
        }

        /// <summary>
        /// Метод ввода целого числа в заданном диапазоне, реализованы диалог с пользователем и циклический ввод
        /// </summary>
        /// <param name="str">Строка для диалога с пользователем</param>
        /// <param name="leftBound">Левая граница промежутка</param>
        /// <param name="rightBound">Правая граница промежутка</param>
        /// <returns>Введённое число</returns>
        public static int InputIntInRange(string str, int leftBound, int rightBound)
        {
            int res;
            do
            {
                res = InputInt($"Введите число {str} из диапазона [{leftBound}; {rightBound}]: ");
            } while (!IsInRange(res, leftBound, rightBound));
            return res;
        }

        /// <summary>
        /// Метод ввода целого числа в заданном диапазоне, реализован циклический ввод
        /// </summary>
        /// <param name="leftBound">Левая граница промежутка</param>
        /// <param name="rightBound">Правая граница промежутка</param>
        /// <returns>Введённое число</returns>
        public static int InputIntInRange(int leftBound, int rightBound)
        {
            int res;
            do
            {
                res = InputInt($"Введите число из диапазона [{leftBound}; {rightBound}]: ");
            } while (!IsInRange(res, leftBound, rightBound));
            return res;
        }

        /// <summary>
        /// Метод ввода дробного числа в заданном диапазоне, реализованы диалог с пользователем и циклический ввод
        /// </summary>
        /// <param name="str">Строка для диалога с пользователем</param>
        /// <param name="leftBound">Левая граница промежутка</param>
        /// <param name="rightBound">Правая граница промежутка</param>
        /// <returns>Введённое число</returns>
        public static double InputDoubleInRange(string str, double leftBound, double rightBound)
        {
            double res;
            do
            {
                res = InputDouble($"Введите число {str} из диапазона [{leftBound}; {rightBound}]: ");
            } while (!IsInRange(res, leftBound, rightBound));
            return res;
        }

        /// <summary>
        /// Метод ввода дробного числа в заданном диапазоне, реализован циклический ввод
        /// </summary>
        /// <param name="leftBound">Левая граница промежутка</param>
        /// <param name="rightBound">Правая граница промежутка</param>
        /// <returns>Введённое число</returns>
        public static double InputDoubleInRange(double leftBound, double rightBound)
        {
            double res;
            do
            {
                res = InputDouble($"Введите число из диапазона [{leftBound}; {rightBound}]: ");
            } while (!IsInRange(res, leftBound, rightBound));
            return res;
        }
    }
}
