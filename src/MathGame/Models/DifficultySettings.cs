using MathGame.Enums;

namespace MathGame.Models;
public class DifficultySettings
{
    public DifficultySettings(GameDifficulty gameDifficulty)
    {
        switch (gameDifficulty)
        {
            case GameDifficulty.Easy:
                minNum = 1;
                maxNum = 9;
                break;
            case GameDifficulty.Normal:
                minNum = 1;
                maxNum = 99;
                break;
            case GameDifficulty.Hard:
                minNum = 1;
                maxNum = 999;
                break;
            default:
                Console.WriteLine("Invalid Input");
                return;
        }
    }    
    public int minNum { get; }
    public int maxNum { get; }
}

