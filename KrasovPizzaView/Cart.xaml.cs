using KrasovPizzaViewModel;
using System.Windows;

namespace KrasovPizzaView
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        private readonly CartViewModel cartViewModel;
        public Cart(ViewModel viewModel)
        {
            InitializeComponent();
            cartViewModel = new(viewModel);
            DataContext = cartViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new(cartViewModel);
            mainWindow.Show();
            Close();
        }
    }
}
