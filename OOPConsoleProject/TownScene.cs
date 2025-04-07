using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            Util.Print("사람들로 북적이는 마을입니다.",ConsoleColor.White, 1000);
            Util.Print("많은 사람들이 당신을 보고 공손하게 인사합니다.", ConsoleColor.White, 1000);
            Util.Print("당신에게 말을 걸어오는 사람이 있습니다.", ConsoleColor.White, 1000);
            Util.Print("대화를 하시겠습니까?", ConsoleColor.White, 1000);
            Console.WriteLine("1. 대화하기");
            Console.WriteLine("2. 무시하기");
            Util.Print("숫자 키를 눌러 선택하기", ConsoleColor.DarkGray, 500);
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
                    Console.WriteLine("당신에게 말을 걸어온 사람은");
                    Console.WriteLine("당신에게 말을 걸어온 사람은");
                    break;
                case ConsoleKey.D2:
                    break;
            }
        }

        public override void Result()
        {
            
        }
    }
}
