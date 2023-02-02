using Prism.Mvvm;
using Prism.Commands;
using KrasovPizzaModel;

namespace KrasovPizzaViewModel;

public class ViewModel : BindableBase
{
    public List<Product>? Products { get; set; }
    public List<string?>? NameProduct { get; set; }

    public ViewModel()
    {
        _cart = new();
        GetProducts();
        NameProduct = Products?.Select(x => x.Name)?.ToList();
        AddProductInCarCommand = new DelegateCommand<Product>(AddProductInCar);
    }

    private Cart _cart;
    public Cart Cart
    {
        get 
        {
            return _cart;
        }
        set
        {
            _cart = value;
            CountOfCart = _cart.ProductsInCart.Count;
        }
    }

    private void GetProducts()
    {
        List<Product>? listProduct = ProxyApplicationContext.GetProducts();
        if (listProduct != null)
        {
            Products = listProduct;
            RaisePropertyChanged(nameof(Products));
        }
    }

    private int countOfCart = 0;
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
        Cart.AddProduct(productItem);
        CountOfCart++;
    }
}