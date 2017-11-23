using System;

namespace ConsoleApp13
{
    /// <summary>
    /// Класс, определяющий студента
    /// </summary>
    class Student
    {
        /// <summary>
        /// Имя студента
        /// </summary>
        private string _name;
        /// <summary>
        /// Имя студента
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Фамилия студента
        /// </summary>
        private string _surname;
        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        /// <summary>
        /// Курс обучения
        /// </summary>
        private int _course;
        /// <summary>
        /// Курс обучения
        /// </summary>
        public int Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public override string ToString()
        {
            return $"Студент\n" +
                   $"Имя: {_name}\n" +
                   $"Фамилия: {_surname}\n" +
                   $"Курс {_course}";
        }

        public Student(string n, string sn, int c)
        {
            _name = n;
            _surname = sn;
            _course = c;
        }
    }
}
