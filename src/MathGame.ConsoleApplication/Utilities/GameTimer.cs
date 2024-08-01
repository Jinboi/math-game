using System.Diagnostics;

namespace MathGame.ConsoleApplication.Utilities;
internal static class GameTimer
{
    private static Stopwatch stopwatch = new Stopwatch();
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
}
