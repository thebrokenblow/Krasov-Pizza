using System.Windows;
using KrasovPizzaViewModel;

namespace KrasovPizzaView;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
   
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ViewModel();  
    }
}
