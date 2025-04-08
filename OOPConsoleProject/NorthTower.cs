using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class NorthTower : Scene
    {
        

        
        public override void Render()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*  @@    @   @         @@ @  *");
            Console.WriteLine("*     @      @ @@  @@@ @ @@  *");
            Console.WriteLine("*           @     @@@    ㅣ  *");
            Console.WriteLine("*               ㅣ    -- ㅣ  *");
            Console.WriteLine("*               ㅣ -  - -ㅣ  *");
            Console.WriteLine("*               ㅣ----  -ㅣ  *");
            Console.WriteLine("*               ㅣ   --- ㅣ  *");
            Console.WriteLine("*               ㅣ--   - ㅣ  *");
            Console.WriteLine("*               ㅣ ㅁ    ㅣ  *");
            Console.WriteLine("******************************");
            Console.WriteLine("북쪽 탑에 도착했습니다.");
            Console.WriteLine();
            Console.WriteLine("북쪽 탑의 자태가 구름 뚫고 올라갑니다.");
            Util.Print("", ConsoleColor.DarkGray, 1000);
            Console.WriteLine("1. 탑 안으로 들어가기");
            Console.WriteLine("2. 돌아가기");
            Util.Print("숫자 키를 눌러 이동하기", ConsoleColor.DarkGray, 0);
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
                        Console.WriteLine("탑을 오릅니다.");
                        Util.Print("", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("숲으로 돌아갑니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
            }
            
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Floor1");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Forest");
                    break;
            }
            
        }
    }
}
