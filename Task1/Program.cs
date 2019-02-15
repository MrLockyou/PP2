using System;

namespace _1lab
{
    class Program
    {
        public static bool Prime(int b)
        // Функция выеснящию что число простое или нет
        {
            if (b == 1) return false;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) return false;
                // Если числопри выеснение остатка будет с остатком 0,то она выведет false
            }
            return true;

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // Ввод цифр
            int[] a = new int[n];
            // создание массива
            int cnt = 0; // counter=0
            for (int i = 0; i < n; i++) // Ввод цифр в массив
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++) // Если простое число то counter вырастет на 1
            {
                if (Prime(a[i]))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt); // Выведит число простых чисел
            for (int i = 0; i < n; i++)
            // Цикл выведение простых чисел
            {
                if (Prime(a[i]))
                {
                    Console.WriteLine(a[i] + " "); // Показывает простые числа с массивом и пробелом
                }
            }

        }







    }

}
