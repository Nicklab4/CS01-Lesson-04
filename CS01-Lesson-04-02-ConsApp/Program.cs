using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Lesson_04_02_ConsApp
{
    class Program
    {
        //
        // Массив как параметр
        //

        static void Print(int n , int[] a)
        {
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
        }

        static void Change(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
                if (a[i] < 0) a[i] = -a[i];
        }

        static void Main(string[] args)
        {
            int[] myArray = { 0, -1, -2, 3, 4, -6, -7, 5, 8, -9 };
            Print(10, myArray);
            Console.WriteLine();
            Change(10, myArray);
            Print(10, myArray);

            Console.ReadLine();
        }
    }
}
