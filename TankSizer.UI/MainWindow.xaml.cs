using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
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

    private void ItemBorder_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        ColorAnimation colorAnimation = new()
        {
            From = Colors.WhiteSmoke,
            To = Colors.LightGray,
            BeginTime = TimeSpan.FromSeconds(.1),
            Duration = TimeSpan.FromSeconds(.25)
        };

        ThicknessAnimation thicknessAnimation = new()
        {
            From = new Thickness(0),
            To = new Thickness(15),
            BeginTime = TimeSpan.FromSeconds(.1),
            Duration = TimeSpan.FromSeconds(.25)
        };

        Storyboard.SetTarget(thicknessAnimation, (Border)sender);
        Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Padding"));
        Storyboard.SetTarget(colorAnimation, (Border)sender);
        Storyboard.SetTargetProperty(colorAnimation, new PropertyPath("(Border.Background).(SolidColorBrush.Color)"));
        Storyboard storyboard = new();
        storyboard.Children.Add(thicknessAnimation);
        storyboard.Children.Add(colorAnimation);

        storyboard.Begin(this);
    }

    private void ItemBorder_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        ColorAnimation colorAnimation = new()
        {
            From = Colors.LightGray,
            To = Colors.WhiteSmoke,
            BeginTime = TimeSpan.FromSeconds(.1),
            Duration = TimeSpan.FromSeconds(.25)
        };

        ThicknessAnimation thicknessAnimation = new()
        {
            From = new Thickness(15),
            To = new Thickness(0),

            Duration = TimeSpan.FromSeconds(.25)
        };

        Storyboard.SetTarget(thicknessAnimation, (Border)sender);
        Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Padding"));
        Storyboard.SetTarget(colorAnimation, (Border)sender);
        Storyboard.SetTargetProperty(colorAnimation, new PropertyPath("(Border.Background).(SolidColorBrush.Color)"));

        Storyboard storyboard = new();
        storyboard.Children.Add(thicknessAnimation);
        storyboard.Children.Add(colorAnimation);

        storyboard.Begin(this);
    }
}