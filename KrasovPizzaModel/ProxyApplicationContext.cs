namespace KrasovPizzaModel;

public class ProxyApplicationContext
{
    public static List<Product>? GetProducts()
    {
        List<Product>? listProduct;

        using (ApplicationContext context = new())
        {
            listProduct = context.Products.ToList();
        }

        return listProduct;
    }
}