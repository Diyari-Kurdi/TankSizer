using System.Windows;
using TankSizer.UI.ViewModels;

namespace TankSizer.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new MainViewModel();
        InitializeComponent();
    }
}