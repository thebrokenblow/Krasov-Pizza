using KrasovPizzaModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KrasovPizzaViewModel;
public class ViewModel : INotifyPropertyChanged
{
    public List<Product>? Products { get; set; }
    private List<Product> ProductsInCart { get; set; }
    private List<Product>? copyProduct;

    public ViewModel()
    {
        GetProducts();
        NameProduct = Products?.Select(x => x.Name)?.ToList();
        ProductsInCart = new();
        countOfCart = 0;
    }
   
    private void GetProducts()
    {
        List<Product>? listProduct = ProxyApplicationContext.GetProduct();
        if (listProduct != null)
        {
            Products = listProduct;
            copyProduct = listProduct;
            OnPropertyChanged(nameof(Products));
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



    public List<string?>? NameProduct { get; set; }

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
            OnPropertyChanged(nameof(CountOfCart));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }

    public void AddProtuctToCart(Product selectedProduct)
    {
        ProductsInCart.Add(selectedProduct);
        CountOfCart++;
    }
}