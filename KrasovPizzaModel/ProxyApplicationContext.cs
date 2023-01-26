namespace KrasovPizzaModel;

public class ProxyApplicationContext
{
    public static List<Product>? GetProduct()
    {
        List<Product>? listProduct;

        using (ApplicationContext context = new ApplicationContext())
        {
            listProduct = context.Products.ToList();
        }

        return listProduct;
    }
}