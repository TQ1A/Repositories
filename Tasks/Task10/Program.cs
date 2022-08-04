namespace Task10
{
//    Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 

    internal class Program
    {
        static void Main()
        {
            MyList<int> myList = new MyList<int>();

            foreach (int item in myList.GetArray())
            {
                Console.Write(item + " ");
            }
        }
    }
}