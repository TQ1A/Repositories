namespace Task10
{
    internal static class Extantions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.GetList().Count()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.GetList().IndexOf(i);
            }
            return array;
        }
        private static void IntToGeneric<T>(ref T value)
        {
            value 
        }
    }
}
