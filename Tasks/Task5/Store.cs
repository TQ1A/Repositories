namespace Task5
{
    internal class Store
    {
        private readonly Article[] _items = new Article[4];

        public Store()
        {
            for (int i = 0; i < _items.Length; i++) _items[i] = new Article();

            _items[0].Item_Name = "wood"; _items[0].Store_Name = "lumberman Joe"; _items[0].Price_UAH = 1.00;
            _items[1].Item_Name = "sword"; _items[1].Store_Name = "Old Anvil"; _items[1].Price_UAH = 100.00;
            _items[2].Item_Name = "apple"; _items[2].Store_Name = "Sweet Home"; _items[2].Price_UAH = 5.00;
            _items[3].Item_Name = "pants"; _items[3].Store_Name = "Lee yu-e"; _items[3].Price_UAH = 40.00;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _items.Length)
                {
                    Article article = _items[index];

                    string result = $@"Имя: {article.Item_Name}
Название магазина: {article.Store_Name}
Цена(грн): {article.Price_UAH}";

                    return result;
                }
                return "Такого товара не существует!";
            }
        }

        public string this[string name]
        {
            get
            {
                Article article = _items.FirstOrDefault(x => x.Item_Name == name);

                if (article == null)
                    return "Такого товара не существует!";
                else
                {
                    string result = $@"Имя: {article.Item_Name}
Название магазина: {article.Store_Name}
Цена(грн): {article.Price_UAH}";

                    return result;
                }
            }
        }
    }
}