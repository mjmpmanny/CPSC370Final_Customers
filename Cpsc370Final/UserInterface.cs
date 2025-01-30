namespace Cpsc370Final;

public class UserInterface
{
    public string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine()?.Trim() ?? "";
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\n=== Nutrition Tracker ===");
        Console.WriteLine("1. Add Food Item");
        Console.WriteLine("2. Show Food Log");
        Console.WriteLine("3. Calculate Total Calories");
        Console.WriteLine("4. Set and Check Calorie Goal");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
    }
}