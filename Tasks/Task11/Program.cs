namespace Task11
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
    //использования его экземпляра для создания парка машин.
    //Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин
    //с названием машины и года ее выпуска, индексатор для получения значения элемента по указанному индексу и
    //свойство только для чтения для получения общего количества элементов. 
    //Создайте метод удаления всех машин автопарка. 

    // TODO: CR: Маркин Евгений: 1. включи пожалуйста текущий проект(Task11.csproj) в решение(Tasks.sln), если он включен то проверь что все файлы залиты в git нормально.
    // TODO: CR: Маркин Евгений: где ограничение? в чем суть урока?

    internal class Program
    {
        static void Main()
        {
            CarCollection<int,string> Cars = new CarCollection<int,string>();

            Cars.Add(1999, "car1");
            Cars.Add(1997, "car2");
            Cars.Add(2005, "car3");

            Console.WriteLine(Cars.Count);

            Console.Write(@$"Введите индекс автомобиля(1-{Cars.Count}): ");
            int index = Int32.Parse(Console.ReadLine())-1;

            Console.WriteLine(Cars[index]);

            Cars.Clear();

            Console.WriteLine(Cars.Count);
        }
    }
}