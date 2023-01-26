using KrasovPizzaModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KrasovPizzaViewModel;
public class ViewModel : INotifyPropertyChanged
{
    public List<Product>? Products { get; set; }
    private List<Product>? copyProduct;

    public ViewModel()
    {
        GetProducts();
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

    private string? nameProduct;


    public string? NameProduct
    {
        get { return nameProduct; }
        set
        {
            nameProduct = value;
            if (nameProduct?.Trim() == "")
            {
                Products = copyProduct;
                OnPropertyChanged(nameof(Products));
            }
            else
            {
                nameProduct = nameProduct?.ToLower().Trim();
                Products = copyProduct?.Where(x => x.Name?.ToLower().Trim() == nameProduct).ToList();
                OnPropertyChanged(nameof(Products));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}