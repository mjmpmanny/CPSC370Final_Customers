namespace Cpsc370Final.Tests;

using Cpsc370Final;

// This Unit Test is For UserInterface.cs

public class UserInterfaceTests
{

    // Display Menu
    
    [Fact]
    public void DisplayMenu_ShouldPrintCorrectMenu()
    {
        // Arrange: Redirect console output
        var output = new StringWriter();
        Console.SetOut(output);

        var ui = new UserInterface();

        // Act: Call the method
        ui.DisplayMenu();

        // Assert: Verify that the menu was printed correctly
        string consoleOutput = output.ToString();
        Assert.Contains("=== Nutrition Tracker ===", consoleOutput);
        Assert.Contains("1. Add Food Item", consoleOutput);
        Assert.Contains("2. Show Food Log", consoleOutput);
        Assert.Contains("3. Calculate Total Calories", consoleOutput);
        Assert.Contains("4. Set and Check Calorie Goal", consoleOutput);
        Assert.Contains("5. Exit", consoleOutput);
    }
    
    // Check Prompt Display

    [Fact]
    public void GetUserInput_ShouldDisplayPrompt()
    {
        // Arrange: Simulate user input
        var input = new StringReader("test\n");
        Console.SetIn(input);

        var output = new StringWriter();
        Console.SetOut(output);

        var ui = new UserInterface();

        // Act: Call the method
        ui.GetUserInput("Enter: ");

        // Assert: Verify that the prompt message is printed
        Assert.Contains("Enter: ", output.ToString());
    }
}