using System.Windows;
using KrasovPizzaViewModel;

namespace KrasovPizzaView;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ViewModel viewModel = new();
    public MainWindow()
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    public MainWindow(CartViewModel cartViewModel)
    {
        InitializeComponent();
        viewModel = new ViewModel(cartViewModel.ListProductsInCart);
        DataContext = viewModel;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Cart cart = new Cart(viewModel);
        cart.Show();
        Close();
    }
}