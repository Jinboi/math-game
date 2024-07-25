using MathGame.Enums;

namespace MathGame.Models;
public class Game
{
    public DateTime Date {  get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
}