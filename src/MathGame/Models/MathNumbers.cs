// -------------------------------------------------------------------------------------------------
// MathGame.Models.MathNumbers
// -------------------------------------------------------------------------------------------------
// Setting up first number and second number.
// -------------------------------------------------------------------------------------------------

namespace MathGame.Models;
public class MathNumbers
{
    #region Properties
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    #endregion
    #region Constructors

    //Parameterless MathNumbers constructors
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
    #endregion
}
