namespace Task8
{
    //    Вопросы для самоконтроля:
    //•	Что такое упаковка и распаковка? 
    //•	Какие виды упаковки вы знаете? 
    //•	Ковариантны ли массивы элементов структурного типа? 
    //•	Какую структуру необходимо использовать для получения формата времени? 
    //•	В каких случаях необходимо использовать структуру TimeSpan.
    //•	Какие бывают виды перечислений? 
    //•	От какого класса наследуются все перечисления?
    //Практическое задание:
    //•	Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    //Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц. 
    //Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему положена премия. 

    internal class Program
    {
        private static void Main()
        {
            Accauntant accauntant = new Accauntant();

            Console.Write("Введите должность сотрудника: ");
            string positionStr = Console.ReadLine();

            Post position;
            while (!Enum.TryParse(positionStr, true, out position))
            {
                Console.Write("Такой должности не существует, повторите попытку!: ");
                positionStr = Console.ReadLine();
            }

            Console.Write("Введите часы рыботы сотрудника: ");
            string hoursStr = Console.ReadLine();
            int hours = Int32.Parse(hoursStr);

            if (accauntant.AskForBonus(position, hours))
                Console.WriteLine("Сотрудник отработал больше установленных часов, ему положенна премия.");
            else
                Console.WriteLine("Сотрудник не отработал больше установленных часов, ему не положенна премия.");
        }
    }
}