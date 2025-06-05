using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 5. Задача на матрицу

//Дан прямоугольный массив целых положительных чисел N х M, заполненный случайными числами.
//Реализовать алгоритм поиска строки с наименьшей суммой элементов.Вывести на печать номер строки
//и сумму её элементов.Если таких строк несколько, вывести информацию о каждой строке.

namespace CS01_Lesson_04_12_ConsApp
{
    class Matrix
    {
        int[,] a;
        int[] rows;

        public Matrix(int n, int m)
        {
            a = new int[n, m];
            Random rnd = new Random();
            rows = new int[n];
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(-5, 6);
                    s += a[i, j];
                }
                rows[i] = s;
            }
        }

        public void Print()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write("{0,4}", a[i, j]);
                Console.WriteLine();
            }
        }

        public int Search(out int count)
        {
            int min = int.MaxValue;
            count = 0;
            foreach (int e in rows)
                if (e < min) min = e;

            foreach (int e in rows)
                if (e == min) count++;

            return min;
        }

        public void SearchRows()
        {
            int countRows;
            int min = Search(out countRows);

            for (int i = 0; i < rows.Length; i++)
                if(rows[i]==min)
                    // i+1 приведение идекса массива к виду номера строк
                    Console.WriteLine("\n{0} {1}", i+1, rows[i]);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(10, 20);
            a.Print();
            a.SearchRows();

            Console.ReadLine();
        }
    }
}
