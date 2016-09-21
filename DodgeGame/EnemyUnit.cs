using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    public class EnemyUnit : Unit
    {
        // This is just a generic enemy unit that moves from the right side of the screen to the left and then disappears

        public EnemyUnit(int x, int y, string unitGraphic) : base(x, y, unitGraphic)
        {

        }

        public override void Update()
        {
            // Do AI here!

            // These enemies simply move from the right side of the screen, to the left. If they go out of bounds, then we delete ourselves... how does that work?

            // Move one to the left, but only if we can still move to the left
            if (X > 0)
            {
                X = X - 1;
            }
            else
            {
                // We are at our move limit. So... do something?
            }

            // Now that the AI calculation is done, let's call out base class' Update function in case it has any important work to do.
            base.Update();
        }
    }
}
