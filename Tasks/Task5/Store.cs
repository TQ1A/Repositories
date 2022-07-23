namespace Task5
{
    // TODO: CR: Маркин Евгений: удаляй плиз старые комменты.

    // TODO: CR: Маркин Евгений: У тебя тема массивы и индексаторы,
    // надо сделать поиск по индексу и названию через индексатор,
    // public string this[int index] { get { ... } } и
    // public string this[string index] { get { ... } } соответственно

    internal class Store
    {
        // TODO: CR: Маркин Евгений: 1. это же массив, значит items
        // 2. давай договоримся что поля начинаются с _ тоесть _item
        // 3. поле по коду не меняется значит должно быть помеченно readonly 
        private Article[] item = new Article[4];

        public Store()
        {
            // TODO: CR: Маркин Евгений: 1. нужно избегать магических чисел по коду используй index <= item.Length
            // 2. много обращений к индексам, из за этого будет падать производительность.
            // 3. инициализацию свойств лучше делать сразу 
            //item[i] = new Article() { 
            //    store_name = "",
            //    item_name = "",
            //    ...
            //}
            // Одна строка - одна операция (принцип единой ответственности), нужно переносить тело цикла на другую строку
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
                // TODO: CR: Маркин Евгений: index <= item.Length
                if (index >= 0 && index <= 3)
                {
                    // TODO: CR: Маркин Евгений: много обращеий по индексу, лучше сделать локальную переменную и к массиву обратиться один раз
                    // Article article = item[index];

                    // TODO: CR: Маркин Евгений: дело стиля, но я бы рекомендовал писать так, просто удобней sql запросы копировать
                    //                    string result = @$"Имя: {article.item_name}
                    //Название магазина: {article.store_name}
                    //Цена(грн): {article.price_uah} ";

                    // TODO: CR: Маркин Евгений:нарушение принципа единой ответственности
                    // вычисление локальной переменной одна операция,
                    // возвращение результата (return) вторая операция
                    // значит должно быть две строки string result = ...; и return result;
                    // в будущем пригодится так как так гораздо удобней дебажить 

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

                // TODO: CR: Маркин Евгений: 1. index <= item.Length

                // 2. если интересно можешь погуглить что такое linq, нужный элемент можно найти выражением
                // Article article = item.FirstOrDefault(x => x.item_name == name); 
                // только много времени на linq не трать, у тебя будет отдельный урок 
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