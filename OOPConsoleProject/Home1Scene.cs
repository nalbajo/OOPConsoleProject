using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Home1Scene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("집으로 돌아왔습니다.");
            Console.WriteLine("따뜻한 온기가 당신을 맞이합니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 침대에 누워 하루를 보낸다.");
            Console.WriteLine("2. 집 밖으로 나간다.");
            Console.WriteLine();
            Util.Print("숫자 키를 눌러 이동하기", ConsoleColor.DarkGray, 0);
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
                    Console.WriteLine("당신은 포근한 침대에 눕습니다.");
                    Console.WriteLine("스스륵 잠이 들어 하루를 보냅니다.");
                    //Todo : 타워와 탑을 한 층씩 클리어 했다면 다음 진행 아니라면 게임오버
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine(" 집 밖으로 나가 마을로 이동합니다.");
                    break;
                default:
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                    break;
            }
        }
        public override void Result()
        {
            //todo : 이거 해야함
        }
    }
}
