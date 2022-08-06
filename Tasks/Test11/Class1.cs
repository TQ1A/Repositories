using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    internal class Class1
    {
        public struct StrucA
        {
            public string Name;
            public ClassA Class;
        }

        public class ClassA
        {
            public string Name;
        }


        static void Main2(string[] args)
        {
            StrucA structA = new StrucA()
            {
                Name = "asd",
                Class = new ClassA()
                {
                    Name = "asd"
                }
            };

            Console.WriteLine(structA.Name); // asd
            Console.WriteLine(structA.Class.Name); // asd
            Console.WriteLine();

            Method1(structA); // asd2; asd
            Console.WriteLine();

            Method2(structA); // asd; asd2
            Console.WriteLine();

            Console.WriteLine(structA.Name); // asd
            Console.WriteLine(structA.Class.Name); // asd2
            Console.ReadLine();
        }

        private static void Method1(StrucA strucA)
        {
            strucA.Name = "asd2";
            Console.WriteLine(strucA.Name);
            Console.WriteLine(strucA.Class.Name);
        }

        private static void Method2(StrucA strucA)
        {
            strucA.Class.Name = "asd2";
            Console.WriteLine(strucA.Name);
            Console.WriteLine(strucA.Class.Name);
        }
    }
}
