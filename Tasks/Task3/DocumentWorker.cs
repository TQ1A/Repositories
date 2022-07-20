namespace Task3
{
    internal class DocumentWorker
    {
        public string Property { get; internal set; }

        private string _property;
        public string Property2
        {
            get
            {
                return _property;
            }
            private set
            {
                _property = value;
            }
        } 

        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}