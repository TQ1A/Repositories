using System;

namespace Task4
{
    //    Вопросы для самоконтроля:
    //•	Что такое абстрактный класс? 
    //•	Что такое интерфейс? 
    //•	Чем абстрактный класс отличается от интерфейса? 
    //•	Что такое множественное наследование? 
    //•	Чем абстрактный класс отличается от конкретного? 
    //•	Какие члены могут быть абстрактными?
    //Практическое задание:
    //•	Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: 
    //Создайте абстрактный класс Figure и интерфейс IFigure.В интерфейсе и абстрактном классе создайте методы int GetSquare()  и int GetPerimetr(). 
    //Создайте производный класс Rectangle от базового класса Figure и Circle от базового интерфейса IFigure.
    //Написать программу, которая выводит площадь и периметр (длину окружности) прямоугольника и круга. 

    class Program
    {
        public static void Main()
        {
            RectangleInfo();

            Console.WriteLine();

            CircleInfo();
        }

        public static void RectangleInfo()
        {
            Figure rectangle = new Rectangle();

            Console.WriteLine("Площадь прямоугольника: " + rectangle.GetSquare());
            Console.WriteLine("Периметр прямоугольника: " + rectangle.GetPerimetr());
        }

        public static void CircleInfo()
        {
            IFigure circle = new Circle();

            Console.WriteLine("Площадь окружности: " + circle.GetSquare());
            Console.WriteLine("Длина окружности: " + circle.GetPerimetr());
        }
    }
}