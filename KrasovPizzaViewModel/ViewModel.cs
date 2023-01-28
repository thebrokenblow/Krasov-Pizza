using KrasovPizzaModel;
using Prism.Commands;
using Prism.Mvvm;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace KrasovPizzaViewModel;
public class ViewModel : BindableBase
{
    public List<Product>? Products { get; set; }
    public List<string?>? NameProduct { get; set; }
    public List<Product> ProductsInCart { get; set; }
    private List<Product>? copyProduct;

    public ViewModel()
    {
        GetProducts();
        NameProduct = Products?.Select(x => x.Name)?.ToList();
        ProductsInCart = new();
        countOfCart = 0;
        AddProductInCarCommand = new DelegateCommand<Product>(AddProductInCar);
    }

    private void GetProducts()
    {
        List<Product>? listProduct = ProxyApplicationContext.GetProduct();
        if (listProduct != null)
        {
            Products = listProduct;
            copyProduct = listProduct;
            RaisePropertyChanged(nameof(Products));
        }
    }

    //private string? nameProduct;

    //public string? NameProduct
    //{
    //    get { return nameProduct; }
    //    set
    //    {
    //        nameProduct = value;
    //        if (nameProduct?.Trim() == "")
    //        {
    //            Products = copyProduct;
    //            OnPropertyChanged(nameof(Products));
    //        }
    //        else
    //        {
    //            nameProduct = nameProduct?.ToLower().Trim();
    //            Products = copyProduct?.Where(x => x.Name?.ToLower().Trim() == nameProduct).ToList();
    //            OnPropertyChanged(nameof(Products));
    //        }
    //    }
    //}

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