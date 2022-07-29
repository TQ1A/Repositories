﻿namespace Task7
{
    //    Вопросы для самоконтроля:
    //•	Что такое структура? 
    //•	Можно ли создавать структуры без оператора new? 
    //•	Какие есть ограничения при использовании структур? 
    //•	Назовите основные отличия классов от структур.
    //•	Почему структуры могут наследоваться только от интерфейсов.
    //•	Можно ли в структуре создавать конструкторы? 
    //Практическое задание:
    //•	Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application. 
    //Требуется: Описать структуру с именем Product, содержащую следующие поля: название страна производитель, номер товара, цена.
    //Написать программу, выполняющую следующие действия: 
    //- сделать внутренний массив, состоящий из нескольких элементов типа Prouct; 
    //- вывести на экран отсортированную  последовательность товаров по цене, начиная с самого дорого товара.

    internal class Program
    {
        static void Main()
        {
            Store store = new Store();

            Console.WriteLine($"{"Name",-15}|{"Price",-15}");

            foreach (Product product in store.SorterByPrice())
            {
                Console.WriteLine($"{product.Name,-15}|{product.Price,-15}");
            }

            Console.ReadLine();
        }
    }
}