// -------------------------------------------------------------------------------------------------
// MathGame.ConsoleApplication.Program
// -------------------------------------------------------------------------------------------------
// The insertion point of the console application.
// -------------------------------------------------------------------------------------------------

using MathGame.ConsoleApplication.Utilities;
using MathGame.ConsoleApplication.Views;

namespace MathGame.ConsoleApplication
{
    internal class Program
    {
        #region Methods: Private Static
        private static void Main(string[] args)
        {
            var menu = new Menu();
            var date = DateTime.UtcNow;

            var games = new List<string>();

            string name = Helpers.GetName();

            menu.ShowMenu(name, date);
        }

        #endregion
    }
}
