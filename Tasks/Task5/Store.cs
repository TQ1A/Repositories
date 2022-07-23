namespace Task5
{
    // TODO: CR: Маркин Евгений: У тебя тема массивы и индексаторы,
    // надо сделать поиск по индексу и названию через индексатор,
    // public string this[int index] { get { ... } } и
    // public string this[string index] { get { ... } } соответственно

    internal class Store
    {
        private Article[] item = new Article[4];
        public Store()
        {
            for (int i = 0; i <= 3; i++) item[i] = new Article();

            item[0].item_name = "wood"; item[0].store_name = "lumberman Joe"; item[0].price_uah = 1.00;
            item[1].item_name = "sword"; item[1].store_name = "Old Anvil"; item[1].price_uah = 100.00;
            item[2].item_name = "apple"; item[2].store_name = "Sweet Home"; item[2].price_uah = 5.00;
            item[3].item_name = "pants"; item[3].store_name = "Lee yu-e"; item[3].price_uah = 40.00;
        }
        
        public string this[int index]
        {
            get
            {
                if(index >= 0 && index <= 3)
                {
                    return "Имя: " + item[index].item_name
                        + "\nНазвание магазина: " + item[index].store_name
                        + "\nЦена(грн): " + item[index].price_uah;
                }
                return "Такого товара не существует!";
            }
        }
        
        public string this[string name]
        {
            get
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (item[i].item_name == name)
                    {
                        return "Имя: " + item[i].item_name
                            + "\nНазвание магазина: " + item[i].store_name
                            + "\nЦена(грн): " + item[i].price_uah;
                    }
                }
                return "Такого товара не существует!";
            }
        }
    }
}