/*
    Файл класса

 */
using System;

namespace ConsoleApp13
{
    class Class1
    {
        public Class1(int f)
        {
            _firstField = f;
        }

        public Class1()
        {
            _firstField = 2;
        }

        private int _firstField;
        public int FirstField
        {
            get { return _firstField; }
            set { _firstField = FirstField; /* Можно без всего */}
        }

        public double CountSmth
        {
            get { return 2 + 2 * 2; }
        }
    }
}
