namespace Cpsc370Final;

public class FoodLog
{
    
    private readonly List<string> _logEntries = new();

    public void AddEntry(string foodName, int grams, int totalCalories)
    {
        string entry = $"{foodName} - {grams}g - {totalCalories} kcal";
        _logEntries.Add(entry);
        Console.WriteLine("✔ Food added to log.");
    }

    public void DisplayLog()
    {
        if (_logEntries.Count == 0)
        {
            Console.WriteLine("No food logged today.");
            return;
        }


        Console.WriteLine("\n=== Food Log ===");
        foreach (string entry in _logEntries)
        {
            Console.WriteLine(entry);
        }
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