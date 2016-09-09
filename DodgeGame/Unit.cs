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
        public int y;
        public string unitGraphic;

        // This draws the unit on the screen.
        public void Draw()
        {
            // This is an instance method, so if we refer to fields like x and y
            // we will be using the values that belong to this instance and this 
            // instance only!
            Console.SetCursorPosition(x, y);
            Console.Write(unitGraphic);
        }
    }
}
