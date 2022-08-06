using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    internal class Class2
    {
        public struct StrucA
        {
            public string Name;
            public StrucB Struct;
        }

        public struct StrucB
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            StrucA structA = new StrucA()
            {
                Name = "asd",
                Struct = new StrucB()
                {
                    Name = "asd"
                }
            };

            Console.WriteLine(structA.Name); // asd
            Console.WriteLine(structA.Struct.Name); // asd
            Console.WriteLine();

            Method1(structA); // asd2; asd
            Console.WriteLine();

            Method2(structA); // asd; asd2
            Console.WriteLine();

            Console.WriteLine(structA.Name); // asd
            Console.WriteLine(structA.Struct.Name); // asd2
            Console.ReadLine();
        }

        private static void Method1(StrucA strucA)
        {
            strucA.Name = "asd2";
            Console.WriteLine(strucA.Name);
            Console.WriteLine(strucA.Struct.Name);
        }

        private static void Method2(StrucA strucA)
        {
            strucA.Struct.Name = "asd2";
            Console.WriteLine(strucA.Name);
            Console.WriteLine(strucA.Struct.Name);
        }
    }
}
