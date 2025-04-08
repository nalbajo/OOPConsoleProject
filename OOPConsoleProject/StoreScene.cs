using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class StoreScene : Scene
    {

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("상점으로 들어왔습니다.");
            Console.WriteLine("상인은 당신에게 말을 겁니다.");
            Console.WriteLine();
            Console.WriteLine("1. 인사한다.");
            Console.WriteLine("2. 상점을 둘러본다.");
            Console.WriteLine("3. 나간다.");
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
                    Console.WriteLine();
                    Console.WriteLine("당신은 상인에게 인사했습니다.");
                    Console.WriteLine("상인은 반갑게 당신을 맞이해줍니다.");
                    Util.Print("아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                    Console.ReadKey(true);
                    Util.Print("상인은 당신에게 요즘 마을의 아이가 행동이 이상하다고 말합니다.", ConsoleColor.White, 500);
                    Util.Print("당신은 무슨 말인지 이해하지 못합니다.", ConsoleColor.White, 500);
                    Console.WriteLine();
                    Util.Print("키를 눌러 다시 고르기",ConsoleColor.DarkGray, 0);
                    input = Console.ReadKey(true).Key;
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.WriteLine("상점 안에는 많은 물건들이 늘어져 있었습니다.");
                    Console.WriteLine("무엇을 구매하시겠습니까?");
                    Console.WriteLine();
                    Console.WriteLine("1. 마력이 깃든 지팡이 : 15 G");
                    Console.WriteLine("2. 검은 기운의 수리검 : 10 G");
                    Console.WriteLine("3. 진짜 쓸모없는 종이묶인 막대기 : 5 G");
                    Console.WriteLine();
                    Console.WriteLine("당신은 돈이 없어 아무것도 살 수 없습니다.");
                    Console.WriteLine();
                    Util.Print("키를 눌러 다시 고르기", ConsoleColor.DarkGray, 0);
                    input = Console.ReadKey(true).Key;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.WriteLine("상점 밖으로 나갑니다.");
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
                case ConsoleKey.D3:
                    Game.ChangeScene("Town1");
                    break;
            }
            
        }

    }
}
