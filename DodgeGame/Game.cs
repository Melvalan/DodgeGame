using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            // TEMPORARY - Let's try to set a fixed frame rate
            int desiredFPS = 30;
            int deltaTimeMS = 1000 / desiredFPS;

            while (true)
            {                
                // First Update all of our units
                playerUnit.Update();
                enemyUnit.Update();
               
                // Draw both units.
                playerUnit.Draw();
                enemyUnit.Draw();

                // Now we need to wait for the correct time for our FPS
                Thread.Sleep(deltaTimeMS);
            }
        }
    }
}
