using KrasovPizzaModel;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace KrasovPizzaViewModel
{
    public class CartViewModel : BindableBase
    {
        public Cart Cart{ get; private set; }
        public ObservableCollection<ProductItemInCart> ObservableProductsInCart { get; set; }

        public CartViewModel(Cart cart)
        {
            Cart = cart;
            
            List<ProductItemInCart> productsInCar = Cart.GroupByProductInCar();
            ObservableProductsInCart = new(productsInCar);

            RemoveProductCommand = new DelegateCommand<Product>(RemoveProduct);
            AddProductCommand = new DelegateCommand<Product>(AddProduct);
        }


        public DelegateCommand<Product> RemoveProductCommand { get; }

        public void RemoveProduct(Product productItem)
        {
            Cart.RemoveProduct(productItem);
            FinalAmount = Cart.GetFinalAmount();
            List<ProductItemInCart> productsInCar = Cart.GroupByProductInCar();
            ObservableProductsInCart = new(productsInCar);

            RaisePropertyChanged(nameof(ObservableProductsInCart));
        }

        public DelegateCommand<Product> AddProductCommand { get; }

        public void AddProduct(Product productItem)
        {
            Cart.AddProduct(productItem);
            FinalAmount = Cart.GetFinalAmount();
            List<ProductItemInCart> productsInCar = Cart.GroupByProductInCar();
            ObservableProductsInCart = new(productsInCar);

            RaisePropertyChanged(nameof(ObservableProductsInCart));
        }

        private decimal? finalAmount;

        public decimal? FinalAmount
        {
            get
            {
                finalAmount = Cart.GetFinalAmount();
                return finalAmount;
            }
            set
            {
                finalAmount = value;
                RaisePropertyChanged(nameof(FinalAmount));
            }
        }
    }
}