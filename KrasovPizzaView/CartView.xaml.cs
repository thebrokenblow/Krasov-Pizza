using KrasovPizzaViewModel;
using System.Windows;

namespace KrasovPizzaView
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class CartView : Window
    {
        private readonly CartViewModel cartViewModel;
        public CartView(ViewModel viewModel)
        {
            InitializeComponent();
            cartViewModel = new(viewModel.Cart);
            DataContext = cartViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuView mainWindow = new(cartViewModel);
            mainWindow.Show();
            Close();
        }
    }
}
