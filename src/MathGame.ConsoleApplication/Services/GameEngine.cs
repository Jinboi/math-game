// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.Services.GameEngine
// -------------------------------------------------------------------------------------------------
// Provides Division, Multiplication, Subtraction, and Addition game engines/logics.
// -------------------------------------------------------------------------------------------------

using MathGame.ConsoleApplication.Utilities;
using MathGame.Enums;
using MathGame.DataControl;
using MathGame.Models;

namespace MathGame.ConsoleApplication.Models;
internal class GameEngine
{
    #region Fields

    private Random random = new Random();
    private int score;
    private int numberOfQuestions;

    #endregion
    #region Methods: Internal
    internal void PlayGame(GameType gameType)
    {
        Console.Clear();

        Console.WriteLine($"Game Type: {gameType}");
        Console.ReadLine();

        var gameDifficulty = ChooseDifficulty();

        Console.Clear();

        Console.WriteLine($"Game Difficulty: {gameDifficulty}");
        Console.ReadLine();     

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

            case GameType.Random:
                RandomGame(gameDifficulty);
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
        InitializeGame();

        DivisionGameLogic(numberOfQuestions, ref score, gameDifficulty);

        DisplayGameResult();

        DataManager.AddToHistory(score, GameType.Division, gameDifficulty);
    }
    internal void MultiplicationGame(GameDifficulty gameDifficulty)
    {
        InitializeGame();

        MultiplicationGameLogic(numberOfQuestions, ref score, gameDifficulty);

        DisplayGameResult();

        DataManager.AddToHistory(score, GameType.Multiplication, gameDifficulty);
    }    
    internal void SubtractionGame(GameDifficulty gameDifficulty)
    {
        InitializeGame();

        SubtractionGameLogic(numberOfQuestions, ref score, gameDifficulty);

        DisplayGameResult();

        DataManager.AddToHistory(score, GameType.Subtraction, gameDifficulty);
    }   
    internal void AdditionGame(GameDifficulty gameDifficulty)
    {
        InitializeGame();

        AdditionGameLogic(numberOfQuestions, ref score, gameDifficulty);

        DisplayGameResult();

        DataManager.AddToHistory(score, GameType.Addition, gameDifficulty);
    }    
    internal void RandomGame(GameDifficulty gameDifficulty)
    {
        InitializeGame();

        RandomGameLogic(numberOfQuestions, ref score, gameDifficulty);

        DisplayGameResult();

        DataManager.AddToHistory(score, GameType.Random, gameDifficulty);
    }

    #endregion
    #region Methods: Private
    private void InitializeGame()
    {
        score = 0;
        numberOfQuestions = Helpers.usersChooseNumberOfQuestions();

        GameTimer.DisplayCountdown();
        GameTimer.StartTimer();
    }
    private void DisplayGameResult()
    {
        Console.WriteLine($"Game over. Your final score is {score}");
        GameTimer.StopTimer(out double timeTakenInSeconds);
        Console.WriteLine("You took {0:N1} seconds to complete", timeTakenInSeconds);
        Console.ReadLine();
    }
    private void DivisionGameLogic(int numberOfQuestions, ref int score, GameDifficulty gameDifficulty)
    {
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            var mathNumbers = GetDivisionNumbers(gameDifficulty);

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
        }
    }
    private MathNumbers GetDivisionNumbers(GameDifficulty gameDifficulty)
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
    private void MultiplicationGameLogic(int numberOfQuestions, ref int score, GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            var mathNumbers = new MathNumbers
            {
                FirstNumber = random.Next(settings.minNum, settings.maxNum + 1),
                SecondNumber = random.Next(settings.minNum, settings.maxNum + 1)
            };

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
        }
    }
    private void SubtractionGameLogic(int numberOfQuestions, ref int score, GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            var mathNumbers = new MathNumbers
            {
                FirstNumber = random.Next(settings.minNum, settings.maxNum + 1),
                SecondNumber = random.Next(settings.minNum, settings.maxNum + 1)
            };

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
        }
    }
    private void AdditionGameLogic(int numberOfQuestions, ref int score, GameDifficulty gameDifficulty)
    {
        var settings = new DifficultySettings(gameDifficulty);
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            var mathNumbers = new MathNumbers
            {
                FirstNumber = random.Next(settings.minNum, settings.maxNum + 1),
                SecondNumber = random.Next(settings.minNum, settings.maxNum + 1)
            };

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
        }
    }
    private void RandomGameLogic(int numberOfQuestions, ref int score, GameDifficulty gameDifficulty)
    {
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            int operationIndex = random.Next(1, 5);
            string operation = operationIndex switch
            {
                1 => "Addition",
                2 => "Subtraction",
                3 => "Multiplication",
                4 => "Division",
                _ => "Invalid"
            };

            switch (operation)
            {
                case "Addition":
                    AdditionGameLogic(1, ref score, gameDifficulty);
                    break;
                case "Subtraction":
                    SubtractionGameLogic(1, ref score, gameDifficulty);
                    break;
                case "Multiplication":
                    MultiplicationGameLogic(1, ref score, gameDifficulty);
                    break;
                case "Division":
                    DivisionGameLogic(1, ref score, gameDifficulty);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
    #endregion
}

