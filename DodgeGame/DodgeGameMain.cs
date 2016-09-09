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

            // Set data for this player's Unit
            playerUnit.unitGraphic = "@";
            playerUnit.x = 10;
            playerUnit.y = 5;

            Unit enemyUnit = new Unit();

            // Instanciate the enemy
            enemyUnit.unitGraphic = "X";
            enemyUnit.x = 20;
            enemyUnit.y = 17;

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
