﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    public class Unit
    {
        public Unit(int x, int y, string unitGraphic)
        {
            this.UnitGraphic = unitGraphic;
            this.X = x;
            this.Y = y;
        }

        public int X // The way the rest of the program interacts with X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0 || value >= Console.WindowWidth)
                {
                    throw new Exception("Invalid X coordinate passed");
                }
                _x = value;
            }
        }
        private int _x; // Where the value of x is actually stored

        public int Y;

        public string UnitGraphic;

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        // This draws the unit on the screen.
        public void Draw()
        {
            // This is an instance method, so if we refer to fields like x and y
            // we will be using the values that belong to this instance and this 
            // instance only!
            Console.SetCursorPosition( this.X, this.Y );
            Console.Write( this.UnitGraphic );
        }

    }
}
