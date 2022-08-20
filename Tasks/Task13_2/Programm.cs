using System;
namespace Task13_2
{
    //Создайте класс с одним статическим полем типа int. 
    //Сделайте программу, которая будет увеличивать счетчик на случайное число.
    //Каждое новое число формируется в новом потоке, используйте lock, чтобы одновременно отрабатывал только 1 поток.
    internal class Programm
    {
        static void Main()
        {
            AddNumber addNumber = new AddNumber();
            for (int i = 0; i < 50; i++)
            {
                new Thread(addNumber.Threads).Start();
                Thread.Sleep(500);
                Console.WriteLine(Count._count);
            }
        }
    }
}