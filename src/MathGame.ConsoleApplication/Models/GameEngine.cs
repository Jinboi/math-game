// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.GameEngine
// -------------------------------------------------------------------------------------------------
// Provides Division, Multiplication, Subtraction, and Addition Game Logics.
// -------------------------------------------------------------------------------------------------

using MathGame.ConsoleApplication.Utilities;
using MathGame.Enums;
using MathGame.DataControl;
using MathGame.Models;
using System.Diagnostics;

namespace MathGame.ConsoleApplication.Models;
internal class GameEngine
{
    #region Constructors

    private Random random = new Random();

    #endregion
    #region Methods: Internal
    internal void PlayGame(GameType gameType)
    {
        Console.WriteLine(gameType);
        Console.ReadLine();

        Console.WriteLine();

        var gameDifficulty = ChooseDifficulty();

        switch (gameType)
        {
            case GameType.Addition:
                AdditionGame(gameDifficulty);
                break;

            case GameType.Subtraction:
                SubtractionGame(gameDifficulty);
                break;

            case GameType.Multiplication:
                MultiplicationGame(gameDifficulty);
                break;

            case GameType.Division:
                DivisionGame(gameDifficulty);
                break;

            default:
                Console.WriteLine("Invalid game type selected.");
                break;
        }
    }   
    internal static GameDifficulty ChooseDifficulty()
    {
        Console.WriteLine("Choose Your Game Difficulty");

        Console.WriteLine($@"
        Choose Your Game Difficulty:
        1 - Easy
        2 - Normal
        3 - Hard");
        Console.WriteLine("_____________");

        string? input = Console.ReadLine();
        GameDifficulty output;

        output = (GameDifficulty)int.Parse(input);

        return output;
    }
    internal void DivisionGame(GameDifficulty gameDifficulty)
    {
        var score = 0;

        int numberOfQuestions = Helpers.usersChooseNumberOfQuestions();

        GameTimer.StartTimer();

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            var mathNumbers = Helpers.GetDivisionNumbers(gameDifficulty);

            Console.WriteLine($"{mathNumbers.FirstNumber} / {mathNumbers.SecondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == mathNumbers.FirstNumber / mathNumbers.SecondNumber)
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

        GameTimer.StopTimer(out double timeTakenInSeconds);
        Console.WriteLine("You took {0:N1} seconds to complete", timeTakenInSeconds);
        Console.ReadLine();

        DataManager.AddToHistory(score, GameType.Division, gameDifficulty);
    }

    

    internal void MultiplicationGame(GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);
        var mathNumbers = new MathNumbers();

        var score = 0;

        int numberOfQuestions = Helpers.usersChooseNumberOfQuestions();

        GameTimer.StartTimer();

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

            mathNumbers.FirstNumber = random.Next(settings.minNum, settings.maxNum + 1);
            mathNumbers.SecondNumber = random.Next(settings.minNum, settings.maxNum + 1);

            Console.WriteLine($"{mathNumbers.FirstNumber} * {mathNumbers.SecondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == mathNumbers.FirstNumber * mathNumbers.SecondNumber)
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

        GameTimer.StopTimer(out double timeTakenInSeconds);
        Console.WriteLine("You took {0:N1} seconds to complete", timeTakenInSeconds);
        Console.ReadLine();

        DataManager.AddToHistory(score, GameType.Multiplication, gameDifficulty);
    }
    internal void SubtractionGame(GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);
        var mathNumbers = new MathNumbers();

        var score = 0;

        int numberOfQuestions = Helpers.usersChooseNumberOfQuestions();

        GameTimer.StartTimer();

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

            mathNumbers.FirstNumber = random.Next(settings.minNum, settings.maxNum + 1);
            mathNumbers.SecondNumber = random.Next(settings.minNum, settings.maxNum + 1);

            Console.WriteLine($"{mathNumbers.FirstNumber} - {mathNumbers.SecondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == mathNumbers.FirstNumber - mathNumbers.SecondNumber)
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

        GameTimer.StopTimer(out double timeTakenInSeconds);
        Console.WriteLine("You took {0:N1} seconds to complete", timeTakenInSeconds);
        Console.ReadLine();

        DataManager.AddToHistory(score, GameType.Subtraction, gameDifficulty);

    }
    internal void AdditionGame(GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);
        var mathNumbers = new MathNumbers();

        var score = 0;

        int numberOfQuestions = Helpers.usersChooseNumberOfQuestions();

        GameTimer.StartTimer();

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

            mathNumbers.FirstNumber = random.Next(settings.minNum, settings.maxNum + 1);
            mathNumbers.SecondNumber = random.Next(settings.minNum, settings.maxNum + 1);

            Console.WriteLine($"{mathNumbers.FirstNumber} + {mathNumbers.SecondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == mathNumbers.FirstNumber + mathNumbers.SecondNumber)
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
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the menu");
                Console.ReadLine();
            }
        }

        GameTimer.StopTimer(out double timeTakenInSeconds);
        Console.WriteLine("You took {0:N1} seconds to complete", timeTakenInSeconds);
        Console.ReadLine();

        DataManager.AddToHistory(score, GameType.Addition, gameDifficulty);
    }

    #endregion
}

