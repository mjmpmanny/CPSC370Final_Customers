namespace Cpsc370Final.Tests
{
    public class FoodDatabaseUnitTest
    {
        private readonly FoodDatabase foodDatabase = new();

        [Fact]
        public void GetCaloriesPer100G_ReturnsCorrectCalories_ForKnownFoodItems()
        {
            Assert.Equal(165, foodDatabase.GetCaloriesPer100G("chicken"));
            Assert.Equal(130, foodDatabase.GetCaloriesPer100G("rice"));
            Assert.Equal(52, foodDatabase.GetCaloriesPer100G("apple"));
            Assert.Equal(541, foodDatabase.GetCaloriesPer100G("bacon"));
            Assert.Equal(0, foodDatabase.GetCaloriesPer100G("water"));
        }

        [Fact]
        public void GetCaloriesPer100G_IsCaseInsensitive()
        {
            Assert.Equal(165, foodDatabase.GetCaloriesPer100G("CHICKEN"));
            Assert.Equal(130, foodDatabase.GetCaloriesPer100G("RiCe"));
            Assert.Equal(52, foodDatabase.GetCaloriesPer100G("Apple"));
        }

        [Fact]
        public void GetCaloriesPer100G_ReturnsNegativeOne_ForUnknownFoodItems()
        {
            Assert.Equal(-1, foodDatabase.GetCaloriesPer100G("pizza"));
            Assert.Equal(-1, foodDatabase.GetCaloriesPer100G("burger"));
            Assert.Equal(-1, foodDatabase.GetCaloriesPer100G("sushi"));
        }
    }
}

