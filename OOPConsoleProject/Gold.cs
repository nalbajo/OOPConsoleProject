using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Gold : GameObject
    {
        public int i;
        public Gold(char symbol, Vector2 position) : base(ConsoleColor.Yellow, symbol, position, true)
        {

        }

        public override void Interact(Player player)
        {
            Game.Player.Gold += i;
        }
    }
}
