namespace Task9
{
    //    Вопросы для самоконтроля:
    //•	Что такое делегат? 
    //•	Что такое комбинированный делегат? 
    //•	Что такое анонимный метод? 
    //•	Какие есть правила при вызове методов сообщенных с делегатами? 
    //•	Что такое лямбда выражение? 
    //•	Чем лямбда выражение отличается от лямбда оператора?
    //Практическое задание:
    //•	Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и
    //возвращает среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
    //Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 

    internal class Program
    {
        delegate int MidValue(DelegatesArray.RandomNumber[] random);

        static DelegatesArray _delegatesArray = new DelegatesArray();

        static void Main()
        { 
            Console.WriteLine(_midValue(_delegatesArray.DSRN));
        }

        static MidValue _midValue = delegate (DelegatesArray.RandomNumber[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]();
            }
            int result = sum / arr.Length;
            return result;
        };
    }
}