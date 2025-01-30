namespace Cpsc370Final;

public class FoodItem
{
    public string Name { get; }
    public int CaloriesPer100G { get; }


    public FoodItem(string name, int calories)
    {
        Name = name;
        CaloriesPer100G = calories;
    }
}