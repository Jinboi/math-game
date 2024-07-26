// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.GameEngine
// -------------------------------------------------------------------------------------------------
// Provides Division, Multiplication, Subtraction, and Addition Game Logics.
// -------------------------------------------------------------------------------------------------

using MathGame.ConsoleApplication.Utilities;
using MathGame.Enums;

namespace MathGame.ConsoleApplication.Models;
internal class GameEngine
{   
    #region Methods: Internal
    internal void DivisionGame(string message)
    {
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type key for next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.Type key for next question");
                Console.ReadLine();
            }

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
    internal void MultiplicationGame(string message)
    {
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);


            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
                Console.ReadLine();
            }

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }


        Helpers.AddToHistory(score, GameType.Mulitplication);
    }
    internal void SubtractionGame(string message)
    {
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} - {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);


            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
                Console.ReadLine();
            }

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }

        Helpers.AddToHistory(score, GameType.Subtraction);

    }
    internal void AdditionGame(string message)
    {
        Console.WriteLine("Choose Your Game Difficulty");

        Console.WriteLine($@"
                    Choose Your Game Difficulty:
                    1 - Easy
                    2 - Normal
                    3 - Hard");
        Console.WriteLine("_____________");

        var gameDifficulty = Console.ReadLine();

        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;


        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} + {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);




            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
                Console.ReadLine();
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}. Press any keo to go back to menu");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Addition);





    }

    #endregion
}

