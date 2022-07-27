namespace Task5
{
    internal class Article
    {
        private string _item_name;
        private string _store_name;
        private double _price_uah;

        public string Item_Name
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

        public string Store_Name
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

        public double Price_UAH
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
