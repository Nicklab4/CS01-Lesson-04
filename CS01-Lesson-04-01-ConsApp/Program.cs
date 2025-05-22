using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Lesson_04_01_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Объявление массивов
            //

            int[] array0;
            array0 = new int[5];

            int[] array1 = new int[5];

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            int[] array3 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //
            // Вывод массива
            //

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array3[i]);
            }
            Console.WriteLine();

            //
            // Возведение каждого элемента в квадрат
            //

            for (int i = 0; i < 10; i++)
            {
                array3[i] = array3[i] * array3[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
