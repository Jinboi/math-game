﻿// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.Views.Menu
// -------------------------------------------------------------------------------------------------
// The menu for the console application.
// -------------------------------------------------------------------------------------------------

using MathGame.ConsoleApplication.Models;
using MathGame.DataControl;
using MathGame.Enums;

namespace MathGame.ConsoleApplication.Views;
internal class Menu
{
    #region Constructors

    GameEngine gameEngine = new();

    #endregion
    #region Methods:Public
    public void ShowMenu(string name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine("_____________");
        Console.WriteLine($"Hello, {name.ToUpper()}. It's {date.DayOfWeek}. Time to play! \n");
        Console.WriteLine("Press any key to show menu");
        Console.ReadLine();
        Console.WriteLine("\n");

        bool isGameOn = true;
        do
        {
            Console.Clear();
            Console.WriteLine($@"
                    What game to play? Choose:
                    V - View history
                    A - Addition
                    S - Subtraction
                    M - Multiplication
                    D - Division
                    R - Random
                    Q - Quit the program");
            Console.WriteLine("_____________");

            var gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    DataManager.PrintGames();
                    break;
                case "a":
                    gameEngine.PlayGame(GameType.Addition);
                    break;
                case "s":
                    gameEngine.PlayGame(GameType.Subtraction);
                    break;
                case "m":
                    gameEngine.PlayGame(GameType.Multiplication);
                    break;
                case "d":
                    gameEngine.PlayGame(GameType.Division);
                    break;
                case "r":
                    gameEngine.PlayGame(GameType.Random);
                    break;
                case "q":
                    Console.WriteLine("Goodbye my friend");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (isGameOn);
    }
    #endregion
}
