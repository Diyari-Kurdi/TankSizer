using TankSizer.Models;

namespace TankSizer;

public static class GenerateTank
{
    public static List<TankOption> GenerateTankOptions(double desiredCapacity, double range = 10, double panelSize = 1.22, int maxRow = 4, int minRow = 1, int maxColumn = 15, int minColumn = 1, int maxYColumn = 15, int minYColumn = 1)
    {
        List<TankOption> options = [];

        for (int lengthPanels = minColumn; lengthPanels <= maxColumn; lengthPanels++)
        {
            for (int widthPanels = minYColumn; widthPanels <= maxYColumn; widthPanels++)
            {
                for (int heightPanels = minRow; heightPanels <= maxRow; heightPanels++)
                {
                    double length = lengthPanels * panelSize;
                    double width = widthPanels * panelSize;
                    double height = heightPanels * panelSize;

                    double capacity = length * width * height;

                    if (IsCapacityInRange(capacity, desiredCapacity, range))
                    {
                        var newTankOption = new TankOption(lengthPanels, widthPanels, heightPanels, panelSize);
                        //Check the new tank if it is duplicated
                        if (!options.Any(to => to.Length == newTankOption.Width && to.Width == newTankOption.Length && to.Height == newTankOption.Height))
                        {
                            options.Add(newTankOption);
                        }
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
