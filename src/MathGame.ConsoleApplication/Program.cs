// -------------------------------------------------------------------------------------------------
// MathGame.Program
// -------------------------------------------------------------------------------------------------
// Add some description
// -------------------------------------------------------------------------------------------------
using MathGame.Models;

namespace MathGame.ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var menu = new Menu();
            var date = DateTime.UtcNow;

            var games = new List<string>();

            string name = Helpers.GetName();

            menu.ShowMenu(name, date);
        }
    }
}
