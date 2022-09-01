using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task14
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте метод, который в качестве аргумента принимает массив целых чисел
    //и возвращает коллекцию всех четных чисел массива.Для формирования коллекции используйте оператор yield. 

    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach(int item in Checker(array))
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> Checker(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
            }
        }
    }
}