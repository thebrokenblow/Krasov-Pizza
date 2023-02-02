using System.Windows;
using KrasovPizzaViewModel;

namespace KrasovPizzaView;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MenuView : Window
{
    private static readonly ViewModel viewModel = new();
    public MenuView()
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    public MenuView(CartViewModel cartViewModel)
    {
        InitializeComponent();
        viewModel.Cart = cartViewModel.Cart;
        DataContext = viewModel;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        CartView cart = new(viewModel);
        cart.Show();
        Close();
    }
}