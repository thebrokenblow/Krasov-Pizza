using Prism.Mvvm;
using Prism.Commands;
using KrasovPizzaModel;

namespace KrasovPizzaViewModel;
public class ViewModel : BindableBase
{
    public List<Product>? Products { get; set; }
    public List<string?>? NameProduct { get; set; }
    public List<Product> ProductsInCart { get; set; }

    public ViewModel()
    {
        GetProducts();
        NameProduct = Products?.Select(x => x.Name)?.ToList();
        ProductsInCart = new();
        countOfCart = 0;
        AddProductInCarCommand = new DelegateCommand<Product>(AddProductInCar);
    }

    public ViewModel(List<Product> productsInCart)
    {
        ProductsInCart = productsInCart;
        GetProducts();
        NameProduct = Products?.Select(x => x.Name)?.ToList();
        countOfCart = ProductsInCart.Count;
        AddProductInCarCommand = new DelegateCommand<Product>(AddProductInCar);
    }

    private void GetProducts()
    {
        List<Product>? listProduct = ProxyApplicationContext.GetProduct();
        if (listProduct != null)
        {
            Products = listProduct;
            RaisePropertyChanged(nameof(Products));
        }
    }

    private int countOfCart;
    public int CountOfCart
    {
        get
        {
            return countOfCart;
        }
        set
        {
            countOfCart = value;
            RaisePropertyChanged(nameof(CountOfCart));
        }
    }

    public DelegateCommand<Product> AddProductInCarCommand { get; }

    public void AddProductInCar(Product productItem)
    {
        ProductsInCart.Add(productItem);
        CountOfCart++;
    }
}