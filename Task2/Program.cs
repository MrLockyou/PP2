using System;

namespace Lab1_Task2
{
    class Student // Создаем класс
    {
        string name; // переменные класса
        string id;
        public int yearofStudy;
        public Student(string n; string i) // конструктор с 2 параметрами
            {
            name = n;
            id = i;
            }
    public void data() // метод который выводит данные студента
    {
        Console.WriteLine("Name of student " + name + "\n" + "ID of student: " + id);
    }
    public
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
