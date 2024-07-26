// -------------------------------------------------------------------------------------------------
// MathGame.Models.Game
// -------------------------------------------------------------------------------------------------
// Data models that will be used in the console application.
// -------------------------------------------------------------------------------------------------
using MathGame.Enums;

namespace MathGame.Models;
public class Game
{
    #region Properties
    public DateTime Date {  get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }

    #endregion
}