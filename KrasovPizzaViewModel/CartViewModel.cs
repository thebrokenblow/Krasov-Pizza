using KrasovPizzaModel;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KrasovPizzaViewModel
{
    public class CartViewModel : BindableBase
    {
        public class ProductItemInCart
        {
            public Product Key { get; set; }
            public int Value { get; set; }
            public decimal Price { get; set; }

            public ProductItemInCart(Product product, int count)
            {
                Key = product;
                Value = count;
                GetSumProduct();
            }

            private void GetSumProduct()
            {
                Price = (decimal)(Key.Price * Value);
            }
        }

        public ObservableCollection<ProductItemInCart> ObservableProductsInCart { get; set; }
        public List<Product> ListProductsInCart { get; set; }


        public CartViewModel(ViewModel viewModel)
        {
            ListProductsInCart = viewModel.ProductsInCart;
            
            List<ProductItemInCart> productsInCar = GroupByProductInCar(ListProductsInCart);
            ObservableProductsInCart = new(productsInCar);

            RemoveProductCommand = new DelegateCommand<Product>(RemoveProduct);
            AddProductCommand = new DelegateCommand<Product>(AddProduct);
        }

        private List<ProductItemInCart> GroupByProductInCar(List<Product> ListProductsInCart)
        {
            List<ProductItemInCart> productsInCar = 
                (from x in ListProductsInCart
                    group x by x into g
                    orderby g.Key.Name
                    let count = g.Count()
                    select new ProductItemInCart(g.Key, count)).ToList();

            return productsInCar;
        }

        public DelegateCommand<Product> RemoveProductCommand { get; }

        public void RemoveProduct(Product productItem)
        {
            ListProductsInCart.Remove(productItem);
            List<ProductItemInCart> productsInCar = GroupByProductInCar(ListProductsInCart);
            ObservableProductsInCart = new(productsInCar);

            RaisePropertyChanged(nameof(ObservableProductsInCart));
        }

        public DelegateCommand<Product> AddProductCommand { get; }

        public void AddProduct(Product productItem)
        {
            ListProductsInCart.Add(productItem);
            List<ProductItemInCart> productsInCar = GroupByProductInCar(ListProductsInCart);
            ObservableProductsInCart = new(productsInCar);

            RaisePropertyChanged(nameof(ObservableProductsInCart));
        }
    }
}