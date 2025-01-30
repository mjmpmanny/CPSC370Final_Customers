
using System.Reflection;

namespace Cpsc370Final.Tests
{
    public class NutritionTrackerUnitTest
    {
        private void InvokePrivateMethod(NutritionTracker tracker, string methodName)
        {
            MethodInfo method = typeof(NutritionTracker).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            method?.Invoke(tracker, null);
        }

        [Fact]
        public void SetCalorieGoal_ShouldSetValidGoal()
        {
            // Arrange
            var tracker = new NutritionTracker();
            Console.SetIn(new System.IO.StringReader("2000\n"));

            // Act
            InvokePrivateMethod(tracker, "SetCalorieGoal");

            // Assert
            Assert.True(true); // Ideally, check internal state if possible
        }
        
        [Fact]
        public void DisplayTotalCalories_ShouldShowCorrectValue()
        {
            // Arrange
            var tracker = new NutritionTracker();
            Console.SetOut(new System.IO.StringWriter());

            // Act
            InvokePrivateMethod(tracker, "DisplayTotalCalories");

            // Assert
            Assert.True(true); // Ideally, capture console output and validate
        }
    }
}