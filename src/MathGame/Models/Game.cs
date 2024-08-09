// -------------------------------------------------------------------------------------------------
// MathGame.Models.Game
// -------------------------------------------------------------------------------------------------
// Data models for the game data.
// -------------------------------------------------------------------------------------------------
using MathGame.Enums;

namespace MathGame.Models;
public class Game
{
    #region Properties
    public DateTime Date {  get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
    public GameDifficulty Difficulty { get; set; }

    #endregion
}