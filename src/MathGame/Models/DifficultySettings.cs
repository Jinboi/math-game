// -------------------------------------------------------------------------------------------------
// MathGame.Models.DifficultySettings
// -------------------------------------------------------------------------------------------------
// Data models for min and max numbers based on the game difficulty settings.
// -------------------------------------------------------------------------------------------------

using MathGame.Enums;

namespace MathGame.Models;
public class DifficultySettings
{
    #region Properties
    public int minNum { get; }
    public int maxNum { get; }

    #endregion
    #region Constructors
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

    #endregion
}

