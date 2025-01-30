namespace Cpsc370Final;
public class FoodDatabase
{
    private readonly Dictionary<string, int> _foodItems = new()
    {
        { "chicken", 165 },
        { "rice", 130 },
        { "banana", 89 },
        { "apple", 52 },
        { "egg", 155 },
        { "orange", 47 },
        { "strawberry", 32 },
        { "blueberry", 57 },
        { "grape", 69 },
        { "beef", 250 },
        { "pork", 242 },
        { "salmon", 208 },
        { "tuna", 132 },
        { "shrimp", 99 },
        { "lobster", 89 },
        { "crab", 87 },
        { "oysters", 81 },
        { "cod", 82 },
        { "tilapia", 96 },
        { "turkey", 189 },
        { "duck", 337 },
        { "lamb", 294 },
        { "bacon", 541 },
        { "hot dog", 290 },
        { "sausage", 301 },
        { "milk", 61 },
        { "water", 0 },
        { "butter", 717 },
        { "white rice", 130 },
        { "pasta", 131 },
        { "tomato", 18 },
        { "potato", 77 },
        { "broccoli", 55 },
        { "spinach", 23 },
        { "lettuce", 15 },
        { "mushroom", 22 },
        { "lentils", 100 },
      
    };
    public int GetCaloriesPer100G(string foodName)
    {
        return _foodItems.GetValueOrDefault(foodName.ToLower(), -1);
    }
}