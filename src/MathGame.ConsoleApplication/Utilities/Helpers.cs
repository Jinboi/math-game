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

    

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
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
