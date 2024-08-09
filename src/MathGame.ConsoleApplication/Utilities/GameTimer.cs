// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.Utilities.GameTimer
// -------------------------------------------------------------------------------------------------
// Provides timer related features needed in the game engine.
// -------------------------------------------------------------------------------------------------

using System.Diagnostics;

namespace MathGame.ConsoleApplication.Utilities;
internal static class GameTimer
{
    #region Fields

    private static Stopwatch stopwatch = new Stopwatch();

    #endregion
    #region Methods: Public
    public static void StartTimer()
    {
        stopwatch.Reset();
        stopwatch.Start();
    }
    public static void StopTimer(out double timeTakenInSeconds)
    {
        stopwatch.Stop();
        timeTakenInSeconds = stopwatch.Elapsed.TotalSeconds;
    }
    public static void DisplayCountdown()
    {
        Console.Clear();

        Console.WriteLine("Game Starting in...");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.Clear();
    }

    #endregion
}
