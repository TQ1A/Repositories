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
            ProDocumentWorker pdocw = new ProDocumentWorker();
            ExpertDocumentWorker edocw = new ExpertDocumentWorker();
            DocumentWorker docw = new DocumentWorker();
            switch (CodeListener())
            {
                case "Pro-123": 
                    Console.WriteLine("\nЗагрузка Professional версии...\n" + new String('=', 50));
                    // TODO: CR: Маркин Евгений: тут должно быть только создание типов ProDocumentWorker, ExpertDocumentWorker или DocumentWorker
                    // вызов методов нужно осуществлять вне конструкции switch 
                    docw.OpenDocument();
                    pdocw.EditDocument();
                    pdocw.SaveDocument();
                    break;

                case "Exp-123":
                    Console.WriteLine("\nЗагрузка Expert версии...\n" + new String('=', 50));
                    docw.OpenDocument();
                    pdocw.EditDocument();
                    edocw.SaveDocument();
                    break;

                default: 
                    Console.WriteLine("\nЗагрузка Trial версии...\n" + new String('=',50));
                    docw.OpenDocument();
                    docw.EditDocument();
                    docw.SaveDocument();
                    break;
            }
        }
        static string CodeListener()
        {
            Console.WriteLine("Введите ключ продукта");
            return Console.ReadLine();
        }
    }
}
