using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Исключения
//Функции обработки исключений на языке C# помогают обрабатывать любые непредвиденные или
//исключительные ситуации, происходящие при выполнении программы.При обработке исключений
//используются ключевые слова try, catch и finally.


namespace CS01_Lesson_04_05_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;

            do
            {
                Console.WriteLine("Введите число:");
                try
                {
                    flag = false;
                    int a = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Неверный формат данных");
                    Console.WriteLine(ex.Message);
                    flag = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Неправильно ввели данные");
                    Console.WriteLine(ex.Message);
                    flag = true;
                }

                // Блок finally содержит код, выполняемый вне зависимости от того,
                // вызывается ли исключение в блоке try, например для освобождения
                // ресурсов, выделенных в блоке try. 

                finally
                {
                    Console.WriteLine("finally");
                }


            } while (flag);

            Console.ReadLine();
        }
    }
}
