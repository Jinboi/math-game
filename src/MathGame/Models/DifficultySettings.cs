using MathGame.Enums;

namespace MathGame.Models;
public class DifficultySettings
{
    #region Constructors
    public DifficultySettings(GameDifficulty gameDifficulty)
    {

        switch (gameDifficulty)
        {
            case GameDifficulty.Easy:
                AdditionNumberMin = 1;
                AdditionNumberMax = 9;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(gameDifficulty));  
        }
    }

    #endregion

    #region Properties
    public int AdditionNumberMin { get; }
    public int AdditionNumberMax { get; }

    #endregion
}