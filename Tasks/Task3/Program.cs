using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            // TODO: CR: Маркин Евгений: не нужно создавать лишние экземпляры классов, тем более если ты ими не пользуешься
            switch (CodeListener())
            {
                case "Pro-123": 
                    Console.WriteLine("\nЗагрузка Professional версии...\n" + new String('=', 50));
                    // TODO: CR: Маркин Евгений: тут должно быть только создание типов ProDocumentWorker, ExpertDocumentWorker или DocumentWorker
                    // вызов методов нужно осуществлять вне конструкции switch 
                    DocLoader(new ProDocumentWorker());
                    break;

                case "Exp-123":
                    Console.WriteLine("\nЗагрузка Expert версии...\n" + new String('=', 50));
                    DocLoader(new ExpertDocumentWorker());
                    break;

                default: 
                    Console.WriteLine("\nЗагрузка Trial версии...\n" + new String('=',50));
                    DocLoader(new DocumentWorker());
                    break;
            }
        }
        static void DocLoader(DocumentWorker docw)
        {
            docw.OpenDocument();
            docw.EditDocument();
            docw.SaveDocument();
        }
        static string CodeListener()
        {
            Console.WriteLine("Введите ключ продукта");
            return Console.ReadLine();
        }
    }
}
