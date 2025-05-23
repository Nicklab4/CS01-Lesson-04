using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Lesson_04_03_ConsApp
{
    // 
    // Массив как объект
    // 

    class Program
    {
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void Change(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] < 0) a[i] = -a[i];
        }

        static void Main(string[] args)
        {
            int[] myArray = { 0, -1, -2, 3, 4, -6, -7, 5, 8, -9 };
            Print(myArray);
            Change(myArray);
            Print(myArray);

            Console.ReadLine();
        }
    }
}
