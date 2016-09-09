using System; // We need the standard .NET library for many things
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGameMain
{
    class DodgeGameMain
    {
        static void Main()
        {

            Unit playerUnit = new Unit();

            Console.SetCursorPosition(playerUnit.x, playerUnit.y);
            Console.Write(playerUnit.unitGraphic);

            Console.ReadLine();

        }
    }
}
