using MathGame.Enums;
using MathGame.Models;

namespace MathGame.DataControl;
public class DataManager
{
    public static List<Game> games = new List<Game>
    {
        
        //Providing Sample Game History Data

        /*
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },

        */
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 , Difficulty = GameDifficulty.Easy},

        
    };
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
}

