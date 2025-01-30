namespace Cpsc370Final.Tests;

public class FoodItemUnitTest
{
    
    [Fact]
    public void Constructor_ShouldInitializeCorrectly()
    {
        //arrange
        string expectedName = "Apple";
        int expectedCalories = 52;

        //act
        var foodItem = new FoodItem(expectedName, expectedCalories);

        //assert
        Assert.Equal(expectedName, foodItem.Name);
        Assert.Equal(expectedCalories, foodItem.CaloriesPer100G);
    }

    [Fact]
    public void NameProperty_ShouldReturnCorrectValue()
    {
        //arrange
        var foodItem = new FoodItem("Banana", 89);

        //act and assert
        Assert.Equal("Banana", foodItem.Name);
    }

    [Fact]
    public void CaloriesPer100GProperty_ShouldReturnCorrectValue()
    {
        //arrange
        var foodItem = new FoodItem("Chicken", 165);

        //act and assert
        Assert.Equal(165, foodItem.CaloriesPer100G);
    }
}