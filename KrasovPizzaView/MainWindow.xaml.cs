using System.Windows;
using System.Windows.Controls;
using KrasovPizzaModel;
using KrasovPizzaViewModel;

namespace KrasovPizzaView;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ViewModel viewModel = new();
    public MainWindow()
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    private void AddProtuctToCart(object sender, RoutedEventArgs e)
    {
        Button? button = sender as Button;
        if (button?.DataContext is Product selectedProduct)
        {
            viewModel.AddProtuctToCart(selectedProduct);
        }
    }
}