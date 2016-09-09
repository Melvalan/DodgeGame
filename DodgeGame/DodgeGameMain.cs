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

            //Instantiate a Unit that will represent the player.
            Unit playerUnit = new Unit();
            playerUnit.SetPosition(-10, 5);

            // Instanciate the enemy
            Unit enemyUnit = new Unit();
            enemyUnit.SetPosition(20,17);

            // Draw both units.
            enemyUnit.Draw();
            playerUnit.Draw();

            // Program END 
            // Do some clean-up

            //Set cursor to bottom-most row
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ReadLine();

        }
    }
}
