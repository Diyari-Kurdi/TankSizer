namespace TankSizer;

public class TankOption
{
    public string Description { get; }
    public double Capacity { get; }

    public TankOption(int lengthPanels, int widthPanels, int heightPanels, double panelSize)
    {
        double length = lengthPanels * panelSize;
        double width = widthPanels * panelSize;
        double height = heightPanels * panelSize;

        Description = $"Tank dimension:\nLength:{length}m\nWidth:{width}m\nHeight:{height}m";
        Capacity = length * width * height;
    }
}