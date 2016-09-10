using System; // We need the standard .NET library for many things
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    class DodgeGameMain
    {
        static void Main()
        {
            // Create a new game
            Game game = new Game();

            // Run the game
            game.Run();

            // When we get here, the game is over.

            // Program END 
            // Do some clean-up

            //Set cursor to bottom-most row
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ReadLine();

        }
    }
}
