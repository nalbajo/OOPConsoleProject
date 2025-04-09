using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Monster : GameObject
    {
        public string name;
        public string description;
        public int power;
        public Monster(char symbol, Vector2 position) : base(ConsoleColor.DarkRed, symbol, position, true)
        {

        }

        public override void Interact(Player player)
        {
            Game.ChangeScene("Fight");
        }
    }
}
