using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS01_Lesson_04_06_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём объект sr и связываем его с файлом data.txt
            StreamReader sr = new StreamReader("..\\..\\data.txt");

            // Читаем первую строку в которой задано количество строк которые
            // будут прочитаны и выведены на экран
            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(sr.ReadLine());
                Console.WriteLine(a);
            }

            // Освобождаемфайл для использования другими программами
            sr.Close();

            Console.ReadLine();
        }
    }
}
