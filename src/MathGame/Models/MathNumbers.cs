namespace MathGame.Models;
public class MathNumbers
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    // Parameterless constructor
    public MathNumbers()
    {
        FirstNumber = 0;
        SecondNumber = 0;
    }
    public MathNumbers(int firstNumber, int secondNumber)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
    }
}
