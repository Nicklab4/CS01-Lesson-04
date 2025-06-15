using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Домашнее задание

//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
//значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
//программу, позволяющую найти и вывести количество пар элементов массива, в которых только
//одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
//элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

namespace CS01_Lesson_04_HW01_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[20];
            //int[] arr = new int[] {6, 2, 9, 3 };
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10000, 10001);

                if ((arr[i - 1] % 3 == 0 & arr[i] % 3 != 0) | (arr[i - 1] % 3 != 0 & arr[i] % 3 == 0))
                {
                    count++;
                }

            }

            Console.WriteLine(count);

            Console.ReadLine();

        }
    }
}
