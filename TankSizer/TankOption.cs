namespace TankSizer.Models;

public class TankOption
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    public double Capacity { get; }

    public TankOption(int lengthPanels, int widthPanels, int heightPanels, double panelSize)
    {
        Length = lengthPanels * panelSize;
        Width = widthPanels * panelSize;
        Height = heightPanels * panelSize;
        Capacity = Length * Width * Height;
    }
}