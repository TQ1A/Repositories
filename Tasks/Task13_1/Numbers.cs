namespace Task13_1
{
    internal class Numbers
    {
        object locker = new object();

        public void NumbersCreator()
        {
            int number = RandomNumber();
            lock (locker)
            {
                if (number < 300)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                if (number >= 300 & number < 600)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                if (number >= 600)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(number);
                Console.WriteLine(new String('=',5));
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private int RandomNumber()
        {
            Random rnd = new Random((int)System.DateTime.Now.Ticks);
            int result = rnd.Next(1,1000);
            return result;
        }
    }
}
