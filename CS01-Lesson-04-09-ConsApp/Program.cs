using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Задача 2. Массив и файл

//Дана последовательность целых чисел, записанная в текстовый файл.Требуется считать данные из
//файла в массив, найти среднее арифметическое элементов и вывести минимальный и максимальный
//элементы массива на экран.Отсортировать массив.

namespace CS01_Lesson_04_09_ConsApp
{
    class MyArray
    {
        int[] a;

        public MyArray(string filename)
        {
            StreamReader sr;

            try
            {
                sr = new StreamReader("..\\..\\" + filename);
            }
            catch (FileNotFoundException)
            {
                sr = new StreamReader("..\\..\\data1.txt");
            }

            int n = int.Parse(sr.ReadLine());
            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    a[i] = int.Parse(sr.ReadLine());
                }
                catch (FormatException)
                {
                    n++;
                    int[] temp = new int[n];
                    a.CopyTo(temp, 0);
                    a = temp;
                    continue;
                }
            }
        }

        public int Length
        {
            get
            {
                return a.Length;
            }
        }

        public double Sum
        {
            get
            {
                double sum = 0;
                foreach (int el in a)
                    sum += el;
                return sum;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public void BubleSort()
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length-1; j++)
                    if(a[j]>a[j+1])
                    {
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
        }

        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4} ", el);
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg);
            Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray("data.txt");
            a.Print();
            Console.WriteLine("\n\nMax:{0}", a.Max);
            Console.WriteLine("Min:{0}", a.Min);
            Console.WriteLine("Middle:{0}\n", a.Sum / a.Length);
            a.BubleSort();
            a.Print("Отсортированный массив");
            Console.ReadLine();
        }
    }
}
