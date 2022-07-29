namespace Task7
{
    internal class Store
    {
        public Product[] _products = new Product[5];

        public Store()
        {
            Sword();
            Pickaxe();
            Axe();
            Pants();
            Cake();
        }

        public int SorterByPrice()
        {
            int[] sorted_index = new int[_products.Length];

            //sorted_index[0] = Array.FindIndex(_products, x => x._price == _products.Max(x=>x._price));

            //for(int i = 1; i < sorted_index.Length; i++)
            //sorted_index[i] = Array.FindIndex(_products, x => x._price == _products.Max(x => x._price));

            sorted_index[0] = 

            return sorted_index;
        }

        private void Sword()
        {
            _products[0] = new Product();
            _products[0]._name = "Sword";
            _products[0]._country = "Lee yu-e";
            _products[0]._creator = "Old Anvil";
            _products[0]._id = 1;
            _products[0]._price = 100;
        }
        private void Pickaxe()
        {
            _products[1] = new Product();
            _products[1]._name = "Pickaxe";
            _products[1]._country = "Lee yu-e";
            _products[1]._creator = "Old Anvil";
            _products[1]._id = 2;
            _products[1]._price = 90;
        }
        private void Axe()
        {
            _products[2] = new Product();
            _products[2]._name = "Axe";
            _products[2]._country = "Lee yu-e";
            _products[2]._creator = "Old Anvil";
            _products[2]._id = 3;
            _products[2]._price = 80;
        }
        private void Pants()
        {
            _products[3] = new Product();
            _products[3]._name = "Pants";
            _products[3]._country = "Inazuma";
            _products[3]._creator = "Sharp Needle";
            _products[3]._id = 4;
            _products[3]._price = 40;
        }
        private void Cake()
        {
            _products[4] = new Product();
            _products[4]._name = "Cake";
            _products[4]._country = "Mondstadt";
            _products[4]._creator = "Sweet Home";
            _products[4]._id = 5;
            _products[4]._price = 333;
        }
    }
}
