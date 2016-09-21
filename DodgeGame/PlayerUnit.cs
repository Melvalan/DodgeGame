using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    public class PlayerUnit : Unit
    {
        public PlayerUnit(int x, int y, string unitGraphic) : base(x, y, unitGraphic)
        {

        }

        override public void Update()
        {
            // When the PLAYER's update function gets called, we would like to execute this INSTEAD of our
            // parent class' Update. In other words, we want to OVERRIDE the parent.

            // Has the user pressed a key? 
            if(Console.KeyAvailable == true)
            {
                // If so, let's MOVE based on that key input.

                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                    case ConsoleKey.NumPad8:
                        Y = Y - 1;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                    case ConsoleKey.NumPad2:
                        Y = Y + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                    case ConsoleKey.NumPad4:
                        X = X - 1;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                    case ConsoleKey.NumPad6:
                        X = X + 1;
                        break;
                }

                // After "break" we end up here.
            }
            
            base.Update();
        }
    }
}
