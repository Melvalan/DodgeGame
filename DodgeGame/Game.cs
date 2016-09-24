using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DodgeGame
{
    public class Game
    {
        // This is our constructor -- it gets run automatically when a new INSTANCE of Game is created.
        public Game()
        {
            //Instantiate a Unit that will represent the player.
            playerUnit = new PlayerUnit(10, 17, "@"); 

            // Instanciate the enemy
            enemyUnit = new EnemyUnit(20, 17, "X");

            stopwatch = new Stopwatch();
        }

        private Stopwatch stopwatch;

        private Unit playerUnit;
        private Unit enemyUnit;

        public void Run()
        {
            // We are happy to run at any framerate whatsoever, however -- do we need to know 
            // how much time each frame is taking.

            stopwatch.Start();
            long timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;

            while (true)
            {
                // The time since the last fram
                int deltaTimeMS = (int)(stopwatch.ElapsedMilliseconds - timeAtPreviousFrame);
                timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;

                // First Update all of our units
                playerUnit.Update(deltaTimeMS);
                enemyUnit.Update(deltaTimeMS);

                // Now that both units have moved, let's see if the player is colliding with an enemy. If so, then game over.
                if (playerUnit.IsCollidingWith(enemyUnit))
                {
                    // Then game over
                    GameOver();
                    return;
                }
               
                // Draw both units.
                playerUnit.Draw();
                enemyUnit.Draw();

                // Let's just do a TINY sleep to avoid runing at like... a billion FPS
                Thread.Sleep(5);
            }
        }

        void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
        }
    }
}
