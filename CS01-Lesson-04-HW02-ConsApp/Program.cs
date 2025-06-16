using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Домашнее задание

//2. Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает
//задачу 1;
//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
//значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
//программу, позволяющую найти и вывести количество пар элементов массива, в которых только
//одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
//элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

//б) Добавьте статический метод для считывания массива из текстового файла.Метод должен
//возвращать массив целых чисел;
//в) Добавьте обработку ситуации отсутствия файла на диске.

namespace CS01_Lesson_04_HW02_ConsApp
{
    static class StaticClass
    {
        static int[] a;

        public static int Count(int[] arr)
        {
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
                if ((arr[i - 1] % 3 == 0 & arr[i] % 3 != 0) | (arr[i - 1] % 3 != 0 & arr[i] % 3 == 0))
                    count++;

            return count;
        }

        public static void ReadArr(string fileName)
        {
            StreamReader sr;


            try
            {
                sr = new StreamReader("..\\..\\" + fileName);
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

            Console.WriteLine(Count(a));
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }

        public static void PrintArr()
        {
            PrintArr(a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-10000, 10001);

            Console.WriteLine(StaticClass.Count(arr));
            StaticClass.PrintArr(arr);
            Console.WriteLine();

            StaticClass.ReadArr("data.txt");
            StaticClass.PrintArr();

            Console.ReadLine();
        }
    }
}

