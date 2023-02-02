namespace KrasovPizzaModel
{
    public class ProductItemInCart
    {
        public Product Key { get; set; }
        public int Value { get; set; }
        public decimal? Price { get; set; }

        public ProductItemInCart(Product product, int count)
        {
            Key = product;
            Value = count;
            Price = Key.Price * Value;
        }
    }

    public class Cart
    {
        public List<Product> ProductsInCart { get; set; }

        public Cart()
        {
            ProductsInCart = new();    
        }

        public void AddProduct(Product productItem)
        {
            ProductsInCart.Add(productItem);
        }

        public void RemoveProduct(Product productItem)
        {
            ProductsInCart.Remove(productItem);
        }

        public List<ProductItemInCart> GroupByProductInCar()
        {
            List<ProductItemInCart> productsInCar =
                (from x in ProductsInCart
                 group x by x into g
                 orderby g.Key.Name
                 let count = g.Count()
                 select new ProductItemInCart(g.Key, count)).ToList();

            return productsInCar;
        }

        public decimal? GetFinalAmount()
        {
            decimal? fianlAmount = 0;
            foreach (Product productItem in ProductsInCart)
            {
                fianlAmount += productItem.Price;
            }
            return fianlAmount;
        }
    }
}
