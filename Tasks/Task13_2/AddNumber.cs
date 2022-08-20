namespace Task13_2
{
    internal class AddNumber
    {
        object locker = new object();

        public void Threads()
        {
            lock (locker)
            {
                int number = RandomNumber();
                Count._count += number;
            }
        }

        int RandomNumber()
        {
            Random rnd = new Random((int)System.DateTime.Now.Ticks);
            int result = rnd.Next(1, 10);
            return result;
        }
    }
}
