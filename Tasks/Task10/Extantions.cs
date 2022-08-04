namespace Task10
{
    internal static class Extantions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            object objlist = list.GetList().ToArray();
            T[] array = new T[0];
            object objarray = array;
            objarray = objlist;
            array = (T[])objarray;
            return array;
        }
    }
}