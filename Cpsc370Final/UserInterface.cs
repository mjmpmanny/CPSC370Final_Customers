namespace Cpsc370Final;

public class UserInterface
{
    public string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine()?.Trim() ?? "";
    }
}