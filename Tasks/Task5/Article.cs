namespace Task5
{
    internal class Article
    {
        private string _item_name;
        private string _store_name;
        private double _price_uah;

        // TODO: CR: Маркин Евгений: 1. давай договоримся, свойства с большой буквы
        // 2. в данном случаи можно обойтись автосвойствами, public string Name { get; set; }
        public string item_name
        {
            get
            {
                return _item_name;
            }
            set
            {
                _item_name = value;
            }
        }

        public string store_name
        {
            get
            {
                return _store_name;
            }
            set
            {
                _store_name = value;
            }
        }

        public double price_uah
        {
            get
            {
                return _price_uah;
            }
            set
            {
                _price_uah = value;
            }
        }
    }
}
