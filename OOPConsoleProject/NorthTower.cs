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
            Util.Print("▶ 아무 키나 눌러 넘어가기", ConsoleColor.White, 2000);
        }

        protected ConsoleKey input;
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update() { }
        public override void Result()
        {
            Game.ChangeScene("Floor1");
        }
    }
}
