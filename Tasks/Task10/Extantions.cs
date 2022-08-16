namespace Task10
{
    internal static class Extantions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            int i = 0;
            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }
            return array;
        }
    }
}