namespace Task6
{
    //    Вопросы для самоконтроля:
    //•	Что такое статический класс? 
    //•	Что такое вложенный класс? 
    //•	Что такое расширяющие методы? 
    //•	Что такое техника делегирования?
    //Практическое задание:
    //•	Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.
    
    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 10, 2, 6, 3, 4, 7, 8, 9, 1, 5 };

            // TODO: CR: Маркин Евгений: метод расширения должен вызываться так
            // numbers.IntSorter();
            string result = string.Join(" ",Array.ConvertAll(Sorter.IntSorter(numbers), x => x.ToString()));

            Console.WriteLine(result);
        }
    }
}