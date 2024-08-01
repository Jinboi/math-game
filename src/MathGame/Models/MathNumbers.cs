namespace MathGame.Models;
public class MathNumbers
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public MathNumbers(int firstNumber, int secondNumber)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
    }
}
