using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class HomeScene : Scene
    {
        public override void Render()
        {
            Util.Print("사람들의 호의로 많은 선물들과",ConsoleColor.White,1000);
            Util.Print("따뜻한 온기가 있는 집입니다.", ConsoleColor.White,1000);
            Console.WriteLine();
            Console.WriteLine("1. 집 안을 둘러본다.");
            Console.WriteLine("2. 집 밖으로 나간다.");
            Util.Print("숫자 키를 눌러 이동하기",ConsoleColor.DarkGray, 500);
            Console.WriteLine();
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
                    Util.Print("집 안은 사람들에 의해 관리되어 있는 것을 알 수 있었습니다.", ConsoleColor.White, 0);
                    Util.Print("부엌에 냉장고는 사람들이 챙겨준 음식들로 가득 차 있었습니다.", ConsoleColor.White, 0);
                    Util.Print("집 안은 다 둘러본 당신은 집 밖으로 나갑니다.", ConsoleColor.White, 0);
                    Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                    Console.ReadKey(true);
                    Result();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("집 밖, 마을로 이동합니다.");
                    Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                    Console.ReadKey(true);
                    Result();
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
                case ConsoleKey.D2:
                    Game.ChangeScene("Town");
                    break;
            }
            
        }

    }
}
