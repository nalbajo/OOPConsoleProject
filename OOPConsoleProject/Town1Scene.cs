using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Town1Scene : Scene
    {

        public override void Render()
        {
            Console.WriteLine("마을입니다.");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 집으로 이동하기");
            Console.WriteLine("2. 상점으로 이동하기");
            Console.WriteLine("3. 숲으로 나가기");
        }
        protected ConsoleKey input;
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("집으로 이동합니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("상점으로 이동합니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("마을 밖, 숲으로 이동합니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                default:
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                    break;
            }
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Home1");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Store1");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Forest");
                    break;
                default:
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                    break;
            }
        }
    }
}
