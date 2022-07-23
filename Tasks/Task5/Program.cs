namespace Task5
{
    internal class Program
    {
        //        Используя Visual Studio, создайте проект по шаблону Console Application.
        //Требуется: 
        //Создать класс Article, содержащий следующие закрытые поля: 
        //∙	название товара; 
        //∙	название магазина, в котором продается товар; 
        //∙	стоимость товара в гривнах.
        //Создать класс Store, содержащий закрытый массив элементов типа Article. 
        //Обеспечить следующие возможности: 
        //∙	вывод информации о товаре по номеру с помощью индекса; 
        //∙	вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
        //Написать программу, вывода на экран информацию о товаре.

        static void Main()
        {
            Console.Write("Введите название товара или его номер: ");
            string name = Console.ReadLine();
            Console.WriteLine(new String('-',50));

            if (Int32.TryParse(name, out int index))
                Console.WriteLine(new Store()[(index)]);
            else
                Console.WriteLine(new Store()[(name)]);

            Console.WriteLine(new String('-',50));
        }
    }
}