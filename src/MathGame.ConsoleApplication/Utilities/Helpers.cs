// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.Helpers
// -------------------------------------------------------------------------------------------------
// Helper class to provide sample data and other functions used in GameEngine.
// -------------------------------------------------------------------------------------------------

using MathGame.Enums;
using MathGame.Models;


namespace MathGame.ConsoleApplication.Utilities;
internal class Helpers
{
    #region Methods: Internal
    internal static MathNumbers GetDivisionNumbers(GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);

        var random = new Random();

        int firstNumber;
        int secondNumber;

        firstNumber = random.Next(settings.minNum, settings.maxNum + 1);
        secondNumber = random.Next(settings.minNum, settings.maxNum + 1);

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        return new MathNumbers(firstNumber, secondNumber);
    }  
    internal static string? ValidateResult(string result)
    {
        while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an intger. Try again");
            result = Console.ReadLine();
        }
        return result;
    }
    internal static string GetName()
    {
        Console.WriteLine("Please input your name");
        var name = Console.ReadLine();


        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name can't be empty");
            name = Console.ReadLine();
        }
        return name;
    }

    #endregion
}
