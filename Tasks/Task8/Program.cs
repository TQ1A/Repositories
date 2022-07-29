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
            string worker = Console.ReadLine();

            while (!Enum.IsDefined(typeof(Post), worker))
            {
                Console.Write("Такой должности не существует, повторите попытку!: ");
                worker = Console.ReadLine();
            }

            Console.Write("Введите часы рыботы сотрудника: ");
            int hours = Int32.Parse(Console.ReadLine());

            if(accauntant.AskForBonus(StringToPost(worker), hours))
            {
                Console.WriteLine("Сотрудник отработал больше установленных часов, ему положенна премия.");
            }
            else
            {
                Console.WriteLine("Сотрудник не отработал больше установленных часов, ему не положенна премия.");
            }
        }

        public static Post StringToPost(string worker)
        {
            switch (worker)
            {
                case "Manager":
                    return Post.Manager;
                case "Secretary":
                    return Post.Secretary;
                case "Dispather":
                    return Post.Dispather;
            }
            return 0;
        }
    }
}