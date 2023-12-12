using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TankSizer.Models;

namespace TankSizer.UI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private double _capacity = 10;
    partial void OnCapacityChanged(double value) => CalculateTankCapacity();
    [ObservableProperty]
    private double _range = 10;
    partial void OnRangeChanged(double value) => CalculateTankCapacity();
    [ObservableProperty]
    private int _maxXColumns = 15;
    partial void OnMaxXColumnsChanged(int value) => CalculateTankCapacity();
    [ObservableProperty]
    private int _minXColumns = 1;
    partial void OnMinXColumnsChanged(int value) => CalculateTankCapacity();
    [ObservableProperty]
    private int _maxYColumns = 15;
    partial void OnMaxYColumnsChanged(int value) => CalculateTankCapacity();
    [ObservableProperty]
    private int _minYColumns = 1;
    partial void OnMinYColumnsChanged(int value) => CalculateTankCapacity();
    [ObservableProperty]
    private int _maxRows = 4;
    partial void OnMaxRowsChanged(int value) => CalculateTankCapacity();
    [ObservableProperty]
    private int _minRows = 1;
    partial void OnMinRowsChanged(int value) => CalculateTankCapacity();

    [ObservableProperty]
    private ObservableCollection<TankOption> _tankOptions = [];

    private void CalculateTankCapacity()
    {
        TankOptions.Clear();
        TankOptions = new ObservableCollection<TankOption>(
            GenerateTank.GenerateTankOptions(Capacity, Range, 1.22, MaxRows,
            MinRows, MaxXColumns, MinXColumns, MaxYColumns, MinYColumns));
    }
}
