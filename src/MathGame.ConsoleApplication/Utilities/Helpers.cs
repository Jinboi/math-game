// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.Utilities.Helpers
// -------------------------------------------------------------------------------------------------
// Helper class to provide sample data and other functions used in game engine.
// -------------------------------------------------------------------------------------------------

namespace MathGame.ConsoleApplication.Utilities;
internal class Helpers
{
    #region Methods: Internal    
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
    internal static int usersChooseNumberOfQuestions()
    {
        Console.WriteLine("How many questions do you want to solve?");

        var result = Console.ReadLine();

        result = ValidateResult(result);

        int resultInt = int.Parse(result);

        return resultInt;
    }
    #endregion
}
