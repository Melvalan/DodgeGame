using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    public class Game
    {
        public Game()
        {
            //Instantiate a Unit that will represent the player.
            playerUnit = new PlayerUnit(10, 5, "@"); 

            // Instanciate the enemy
            enemyUnit = new EnemyUnit(20, 17, "X");
        }

        private Unit playerUnit;
        private Unit enemyUnit;

        public void Run()
        {
            while (true)
            {
                // First Update all of our units
                playerUnit.Update();
                enemyUnit.Update();

                // Clear the old screen!
                Console.Clear();

                // Draw both units.
                playerUnit.Draw();
                enemyUnit.Draw();
            }
        }
    }
}
