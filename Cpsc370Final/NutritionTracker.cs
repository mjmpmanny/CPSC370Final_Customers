namespace Cpsc370Final;

public class NutritionTracker
{
    private readonly FoodDatabase _foodDatabase = new();
    private readonly FoodLog _foodLog = new();
    private readonly UserInterface _ui = new();
    private int _calorieGoal = 0;

    public void Run()
    {
        bool running = true;
        while (running)
        {
            _ui.DisplayMenu();
            string choice = _ui.GetUserInput("");

            switch (choice)
            {
                case "1":
                    AddFoodItem();
                    break;
                case "2":
                    _foodLog.DisplayLog();
                    break;
                case "3":
                    DisplayTotalCalories();
                    break;
                case "4":
                    SetCalorieGoal();
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    
    private void AddFoodItem()
    {
        string foodName = _ui.GetUserInput("Enter food name: ");
        int caloriesPer100G = _foodDatabase.GetCaloriesPer100G(foodName);


        if (caloriesPer100G == -1)
        {
            Console.WriteLine("Food item not found.");
            return;
        }


        if (!int.TryParse(_ui.GetUserInput("Enter grams: "), out int grams) || grams <= 0)
        {
            Console.WriteLine("Invalid grams input.");
            return;
        }


        int totalCalories = (caloriesPer100G * grams) / 100;
        _foodLog.AddEntry(foodName, grams, totalCalories);
    }
    
    private void DisplayTotalCalories()
    {
        int totalCalories = _foodLog.CalculateTotalCalories();
        Console.WriteLine($"Total Calories Consumed Today: {totalCalories} kcal");
    }


    private void SetCalorieGoal()
    {
        if (!int.TryParse(_ui.GetUserInput("Set daily calorie goal: "), out _calorieGoal) || _calorieGoal <= 0)
        {
            Console.WriteLine("Invalid calorie goal.");
            return;
        }


        int totalCalories = _foodLog.CalculateTotalCalories();
        Console.WriteLine($"Goal: {_calorieGoal} kcal | Consumed: {totalCalories} kcal");


        if (totalCalories == 0)
            Console.WriteLine("No food logged yet.");
        else if (totalCalories < _calorieGoal)
            Console.WriteLine("You are below your goal. Keep eating!");
        else if (totalCalories > _calorieGoal)
            Console.WriteLine("You have exceeded your goal. Consider adjusting intake.");
        else
            Console.WriteLine("Congratulations! You met your goal.");
    }

}