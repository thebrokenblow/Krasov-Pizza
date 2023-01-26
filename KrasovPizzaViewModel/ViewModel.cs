using KrasovPizzaModel;

namespace KrasovPizzaViewModel;


public class ViewModel
{
    public List<Product>? Products { get; set; }

    public ViewModel()
    {
        List<Product>? listProduct = ProxyApplicationContext.GetProduct();
        if (listProduct != null)
        {
            Products = listProduct;
        }
    }
}