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
            ProcessDocument();
        }

        static void ProcessDocument()
        {
            DocumentWorker doc = CreateDocumentWorker();
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
        }

        static string CodeListener()
        {
            Console.WriteLine("Введите ключ продукта");
            return Console.ReadLine();
        }

        static DocumentWorker CreateDocumentWorker()
        {
            switch (CodeListener())
            {
                case "Pro-123":
                    Console.WriteLine("\nЗагрузка Professional версии...\n" + new String('=', 50));
                    return new ProDocumentWorker();

                case "Exp-123":
                    Console.WriteLine("\nЗагрузка Expert версии...\n" + new String('=', 50));
                    return new ExpertDocumentWorker();

                default:
                    Console.WriteLine("\nЗагрузка Trial версии...\n" + new String('=', 50));
                    return new DocumentWorker();
            }
        }
    }
}

// TODO: CR: Маркин Евгений: давай лучше это оставим перед названием класса или namespace, коментарии все пишутся перед кодом, так принято

//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создайте класс DocumentWorker. 
//В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().

//В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
//Создайте производный класс ProDocumentWorker. 
//Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
//Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате". 
//В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker. 

