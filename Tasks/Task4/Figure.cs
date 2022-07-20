using System;

namespace Task4
{
    abstract class Figure
    {
        public abstract int GetSquare();
        public abstract int GetPerimetr();
    }

    class Rectangle : Figure
    {
        public override int GetSquare()
        {
            return 100;
        }  
        public override int GetPerimetr()
        {
            return 40;
        }
    }
}
