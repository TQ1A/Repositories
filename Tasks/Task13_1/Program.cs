using System;
namespace Task13_1
{
    //Создайте программу, которая будет выводить на экран случайные числа от 0 до 1000. Каждое новое число формируется в новом потоке.
    //    Если число от 0 до 300 число выводится белым, если от 300 до 600 зеленым, больше 600 красным.
    internal class Programm
    {
        static void Main()
        {
            Numbers numbers = new Numbers();
            for (int i = 0; i < 3; i++)
            {
                new Thread(numbers.NumbersCreator).Start();
            }
        }
    }
}