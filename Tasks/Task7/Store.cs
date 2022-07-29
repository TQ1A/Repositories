namespace Task7
{
    internal class Store
    {
        public readonly Product[] _products = new Product[5];

        public Store()
        {
            Sword();
            Pickaxe();
            Axe();
            Pants();
            Cake();
        }

        public Product[] SorterByPrice()
        {
            Product[] result = _products.OrderByDescending(x => x.Price).ToArray(); 
            return result;
        }

        private void Sword()
        {
            _products[0] = new Product();
            _products[0].Name = "Sword";
            _products[0].Country = "Lee yu-e";
            _products[0].Creator = "Old Anvil";
            _products[0].ID = 1;
            _products[0].Price = 100;
        }
        private void Pickaxe()
        {
            _products[1] = new Product();
            _products[1].Name = "Pickaxe";
            _products[1].Country = "Lee yu-e";
            _products[1].Creator = "Old Anvil";
            _products[1].ID = 2;
            _products[1].Price = 90;
        }
        private void Axe()
        {
            _products[2] = new Product();
            _products[2].Name = "Axe";
            _products[2].Country = "Lee yu-e";
            _products[2].Creator = "Old Anvil";
            _products[2].ID = 3;
            _products[2].Price = 80;
        }
        private void Pants()
        {
            _products[3] = new Product();
            _products[3].Name = "Pants";
            _products[3].Country = "Inazuma";
            _products[3].Creator = "Sharp Needle";
            _products[3].ID = 4;
            _products[3].Price = 40;
        }
        private void Cake()
        {
            _products[4] = new Product();
            _products[4].Name = "Cake";
            _products[4].Country = "Mondstadt";
            _products[4].Creator = "Sweet Home";
            _products[4].ID = 5;
            _products[4].Price = 333;
        }
    }
}
