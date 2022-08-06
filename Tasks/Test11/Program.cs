using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test11
{
    internal class Program
    {
        public struct StrucA
        {
            public string Name;
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
            };
            ClassA classA = new ClassA()
            {
                Name = "asd",
            };

            Console.WriteLine(classA.Name); //asd
            Console.WriteLine(structA.Name); //asd

            Method1(structA); //asd2
            Method1(classA); //asd2

            Console.WriteLine(classA.Name); //asd2
            Console.WriteLine(structA.Name); //asd

            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Method1(i);
            }
        }

        private static void Method1(int i)
        {
            i = 100;
        }

        private static void Method1(ClassA classA)
        {
            classA.Name = "asd2";
            Console.WriteLine(classA.Name);
        }

        private static void Method1(StrucA strucA)
        {
            strucA.Name = "asd2";
            Console.WriteLine(strucA.Name);
        }

    }
}



