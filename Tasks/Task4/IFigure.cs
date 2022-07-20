using System;

namespace Task4
{
    interface IFigure
    {
        int GetSquare();
        int GetPerimetr();
    }

    class Circle : IFigure
    {
        public int GetSquare()
        {
            return 90;
        }
        public int GetPerimetr()
        {
            return 30;
        }
    }
}
