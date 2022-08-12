namespace Task11
{
    internal class CarCollection<T,R>
    {
        public int Count
        {
            get { return CarNames.Count(); }
        }

        List<T> CarYears = new List<T>();
        List<R> CarNames = new List<R>();

        public void Add(T year, R name)
        {
            CarYears.Add(year);
            CarNames.Add(name);
        }

        public void Clear()
        {
            CarYears.Clear();
            CarNames.Clear();
        }

        public (T,R) this[int index]
        {
            get
            {
                return (CarYears[index], CarNames[index]);
            }
        }
    }
}
