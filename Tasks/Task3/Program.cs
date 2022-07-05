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
            // TODO: CR: Маркин Евгений: есть правило единой ответвенности (из принципов SOLID),
            // в соответствии с которым каждая операция должна быть отдельным методом
            // в данном случаи есть 2 операции.
            // 1. switch с созданием DocumentWorker
            // 2. использование DocumentWorker
            // сделай методы c сигнатурой DocumentWorker CreateDocumentWorker(); и void ProcessDocument(DocumentWorker doc);

            // TODO: CR: Маркин Евгений: старые коментарии убирай, их можно посмотреть в истории
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
                    // TODO: CR: Маркин Евгений: метод в методе вызывать плохая практика, нужно разделять вызовы методов.
                    DocLoader(new ExpertDocumentWorker());
                    break;

                default: 
                    Console.WriteLine("\nЗагрузка Trial версии...\n" + new String('=',50));
                    DocLoader(new DocumentWorker());
                    break;
            }
        }

        // TODO: CR: Маркин Евгений: название метода не очевидно, на мой взгляд лучше подойдел ProcessDocument или любое другое по аналогии.
        static void DocLoader(DocumentWorker docw)
        {
            docw.OpenDocument();
            docw.EditDocument();
            docw.SaveDocument();
        }// TODO: CR: Маркин Евгений: тут нужно сделать пустую строку, так красивее
        static string CodeListener()
        {
            Console.WriteLine("Введите ключ продукта");
            return Console.ReadLine();
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

