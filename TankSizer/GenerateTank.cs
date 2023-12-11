namespace TankSizer;

public static class GenerateTank
{
    public static List<TankOption> GenerateTankOptions(double desiredCapacity, double range = 10, double panelSize = 1.22, int maxRow = 4, int maxColumn = 15, int maxYColumn = 15)
    {
        List<TankOption> options = [];

        for (int lengthPanels = 1; lengthPanels <= maxColumn; lengthPanels++)
        {
            for (int widthPanels = 1; widthPanels <= maxYColumn; widthPanels++)
            {
                for (int heightPanels = 1; heightPanels <= maxRow; heightPanels++)
                {
                    double length = lengthPanels * panelSize;
                    double width = widthPanels * panelSize;
                    double height = heightPanels * panelSize;

                    double capacity = length * width * height;

                    if (IsCapacityInRange(capacity, desiredCapacity, range))
                    {
                        options.Add(new TankOption(lengthPanels, widthPanels, heightPanels, panelSize));
                    }
                }
            }
        }

        return options;
    }

    private static bool IsCapacityInRange(double capacity, double targetCapacity, double range)
    {
        return Math.Abs(capacity - targetCapacity) <= range;
    }
}
