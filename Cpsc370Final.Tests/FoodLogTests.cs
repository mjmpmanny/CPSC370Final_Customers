namespace Cpsc370Final.Tests;
using Cpsc370Final;

    public class FoodLogTests
    {

        // Add Entry

        [Fact]
        public void AddEntry_ShouldAddFoodToLog()
        {
            // Arrange
            var foodLog = new FoodLog();

            // Act
            foodLog.AddEntry("Apple", 100, 52);

            // Assert
            Assert.Contains("Apple - 100g - 52 kcal", foodLog.GetEntries());
        }

        // Display Log with Entries

        [Fact]
        public void DisplayLog_ShouldShowEntries_WhenFoodIsAdded()
        {
            // Arrange
            var foodLog = new FoodLog();
            foodLog.AddEntry("Banana", 150, 134);

            // Act & Assert
            var consoleOutput = CaptureConsoleOutput(foodLog.DisplayLog);
            Assert.Contains("Banana - 150g - 134 kcal", consoleOutput);
        }


        // Display Log when No Food Logged

        [Fact]
        public void DisplayLog_ShouldShowNoFoodMessage_WhenNoFoodIsLogged()
        {
            // Arrange
            var foodLog = new FoodLog();

            // Act
            var consoleOutput = CaptureConsoleOutput(foodLog.DisplayLog);

            // Assert
            Assert.Contains("No food logged today.", consoleOutput);
        }
        
        // Calculate Total Calories with Entries

        [Fact]
        public void CalculateTotalCalories_ShouldReturnCorrectSum()
        {
            // Arrange
            var foodLog = new FoodLog();
            foodLog.AddEntry("Rice", 200, 260);
            foodLog.AddEntry("Chicken", 150, 247);

            // Act
            int totalCalories = foodLog.CalculateTotalCalories();

            // Assert
            Assert.Equal(507, totalCalories);  // 260 + 247 = 507
        }


        // Calculate Total Calories with No Entries
        
        [Fact]
        public void CalculateTotalCalories_ShouldReturnZero_WhenNoEntries()
        {
            // Arrange
            var foodLog = new FoodLog();

            // Act
            int totalCalories = foodLog.CalculateTotalCalories();

            // Assert
            Assert.Equal(0, totalCalories);
        }

        private static string CaptureConsoleOutput(Action action)
        {
            var originalOutput = Console.Out;
            using var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            
            action.Invoke();

            Console.SetOut(originalOutput);
            return consoleOutput.ToString();
        }
    }