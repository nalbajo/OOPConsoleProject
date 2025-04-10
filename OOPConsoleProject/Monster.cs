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
        public int hp;
        public int power;
        public Monster(char symbol, Vector2 position, bool isOnce) : base(ConsoleColor.DarkRed, symbol, position, isOnce)
        {

        }

        public override void Interact(Player player)
        {
            Console.WriteLine();
            Console.WriteLine($"{name}입니다.");
            Console.WriteLine($"{description}");
            Console.WriteLine($"체력은 {hp}입니다.");
            Console.WriteLine($"공격력은 {power}입니다.");
            Console.WriteLine();
            Util.Print("▶ 아무 키나 눌러 넘어가기", ConsoleColor.DarkGray, 0);
            Console.ReadKey();
            Console.WriteLine();
            Game.ChangeScene("FightB1");
        }
    }
}
