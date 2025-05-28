using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS01_Lesson_04_07_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("..\\..\\data.txt");

            int sum = 0, count = 0;

            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                Console.WriteLine("Считали строку: " + s);
                try
                {
                    int a = int.Parse(s);
                    sum = sum + a;
                    count++;
                }
                catch (Exception ex )
                {
                    Console.WriteLine(ex.Message);
                }
            }

            sr.Close();

            Console.WriteLine("Среднее арифметическое:{0:f2}", (double)sum/count);

            Console.ReadLine();
        }
    }
}
