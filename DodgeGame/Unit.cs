using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    public class Unit
    {
        public int x;
        private int y;
        private string unitGraphic = "@";

        public void SetPosition( int x, int y)
        {
            if (x < 0 || x >= Console.WindowWidth &&
                y < 0 && y >= Console.WindowHeight)
            {
                // Freak out and put some kind of error message
                throw new Exception("Invalid X coordinate passed.");
            }

            // If we get here, everything is awesome.
            this.x = x;
            this.y = y;

            // Instead of failing silently, consider two other possibilities:

            // OPTION 1: Try to "fix" the input. i.e. something like:
            // if(x < 0)
            // {
            //     x = 0;
            // }

            // OPTION 2: Fail LOUDLY
            // if(x < 0)
            // {
                // Freak out and put some kind of error message
                // throw new Exception("Invalid X coordinate passed.");
            // }
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        // This draws the unit on the screen.
        public void Draw()
        {
            // This is an instance method, so if we refer to fields like x and y
            // we will be using the values that belong to this instance and this 
            // instance only!
            Console.SetCursorPosition( this.x, this.y );
            Console.Write( this.unitGraphic );
        }

    }
}
