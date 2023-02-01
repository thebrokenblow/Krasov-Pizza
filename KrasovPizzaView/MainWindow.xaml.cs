using System.Windows;
using KrasovPizzaViewModel;

namespace KrasovPizzaView;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private static readonly ViewModel viewModel = new();
    public MainWindow()
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    public MainWindow(CartViewModel cartViewModel)
    {
        InitializeComponent();
        viewModel.ProductsInCart = cartViewModel.ListProductsInCart;
        DataContext = viewModel;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Cart cart = new(viewModel);
        cart.Show();
        Close();
    }
}