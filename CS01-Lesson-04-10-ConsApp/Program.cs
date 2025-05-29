using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 3. Частотный массив

//Дана последовательность натуральных чисел от 0 до 99. Найти, какое число встречается чаще всего.
//Если таких чисел несколько, то вывести все числа.

namespace CS01_Lesson_04_10_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 10;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(0, 100);

            foreach (var v in a)
                Console.Write(v + " ");

            int[] mass = new int[100];

            foreach (var v in a)
                mass[v]++;

            int imax = 0;
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] > mass[imax]) imax = i;

            Console.WriteLine("\n");

            for (int i = 0; i < mass.Length; i++)
                if (mass[i] == mass[imax]) Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
