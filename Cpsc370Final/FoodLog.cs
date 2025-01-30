namespace Cpsc370Final;

public class FoodLog
{
    public int CalculateTotalCalories()
    {
        int totalCalories = 0;

        foreach (string entry in _logEntries)
        {
            string[] parts = entry.Split('-');
            if (parts.Length >= 3))
            {
                string caloriePart = parts[2].Replace(" kcal", "").Trim();
                if (int.TryParse(caloriePart, out int calories))
                {
                    totalCalories += calories;
                }
            }
        }
        
        return totalCalories;
    }
}