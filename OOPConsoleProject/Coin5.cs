using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Coin5 : Gold
    {
        public Coin5(Vector2 position) : base('C', position)
        {
            i = 5;
        }
    }
}
