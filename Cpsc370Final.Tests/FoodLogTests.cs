namespace Cpsc370Final.Tests
{
    public class FoodLogTests
    {
        [Fact]
        public void AddEntry_ShouldAddFoodToLog()
        {
            // Arrange
            var foodLog = new FoodLog();

            // Act
            foodLog.AddEntry("Apple", 100, 52);

            // Assert
            Assert.Contains("Apple - 100g - 52 kcal", GetLogEntries(foodLog));
        }

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

        // ====== Helper Methods for Testing ======
        private static string CaptureConsoleOutput(Action action)
        {
            using var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);
            action.Invoke();
            return consoleOutput.ToString();
        }

        private static string[] GetLogEntries(FoodLog foodLog)
        {
            var consoleOutput = CaptureConsoleOutput(foodLog.DisplayLog);
            return consoleOutput.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
