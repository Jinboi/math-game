// -------------------------------------------------------------------------------------------------
// MathGame.DataControl.DataManager
// -------------------------------------------------------------------------------------------------
// The data controller for the console application.
// -------------------------------------------------------------------------------------------------

using MathGame.Enums;
using MathGame.Models;

namespace MathGame.DataControl;
public class DataManager
{
    #region Fields
    public static List<Game> games = new List<Game>
    {        
        //Providing sample game data history
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 , Difficulty = GameDifficulty.Easy},
    };
    #endregion
    #region Methods: Public
    public static void AddToHistory(int gameScore, GameType gameType, GameDifficulty gameDifficulty)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType,
            Difficulty = gameDifficulty
        });
    }
    public static void PrintGames()
    {
        var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 08, 09)).OrderByDescending(x => x.Score);

        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("---------------------------");
        foreach (var game in gamesToPrint)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts - {game.Difficulty} mode");
        }
        Console.WriteLine("---------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }

    #endregion
}

