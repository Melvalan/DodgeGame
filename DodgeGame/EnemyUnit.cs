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

            // Now that the AI calculation is done, let's call out base class' Update function in case it has any important work to do.
            base.Update();
        }
    }
}
