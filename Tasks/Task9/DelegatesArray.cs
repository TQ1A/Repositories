namespace Task9
{
    internal class DelegatesArray
    {
        public delegate int RandomNumber();
        public RandomNumber[] DSRN = new RandomNumber[5];

        public DelegatesArray()
        {
            for (int i = 0; i < DSRN.Length; i++)
            {
                DSRN[i] = new RandomNumber(SelectRandomNumber);
            }
        }

        private static int SelectRandomNumber()
        {
            Random rnd = new Random((int)System.DateTime.Now.Ticks);
            int value = rnd.Next(1, 100);
            Console.WriteLine(value);
            return value;
        }
    }
}
