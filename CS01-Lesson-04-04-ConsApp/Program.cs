using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Например, у нас есть класс, внутри которого есть поле — массив, но поле объявлено приватным.
//Чтобы получить доступ к элементу массива, можно сделать либо публичный метод, который будет
//возвращать элемент массива по его номеру, либо индексируемое свойство.

namespace CS01_Lesson_04_04_ConsApp
{
    class MyArray
    {
        int[] a;
        public MyArray(int n)
        {
            a = new int[n];
        }

        public int Get(int i)
        {
            return a[i];
        }

        public void Set(int i, int value)
        {
            a[i] = value;
        }

        // Индексируемое свойство
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10);

            for (int i = 0; i < 10; i++)
                // Для доступа можно использовать либо метод
                array.Set(i, i * 10);

            for (int i = 0; i < 10; i++)
                // Или индексируемое свойство, что более удобно
                array[i] = array[i] * 10;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
