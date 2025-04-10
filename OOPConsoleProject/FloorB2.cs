using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class FloorB2 : Scene
    {
        public bool SouthDungeonFloorB2 = false;
        public override void Render()
        {
            if (SouthDungeonFloorB2 == true)
            {
                Console.WriteLine("지하 3층으로 갑니다.");
                Util.Print("", ConsoleColor.White, 1000);
                Game.ChangeScene("Floor3");
            }
            else
            {
                Console.WriteLine(" 아직 생성되지 않은 구역인 것 같다.");
                Console.WriteLine();
                Console.WriteLine("나가고 싶다면 BackSpace를 누르세요.");
            }

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
                case ConsoleKey.Backspace:
                    Console.WriteLine("탑 밖으로 나갑니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    Game.ChangeScene("Forest");
                    break;
            }
        }
        public override void Result()
        {
            
        }
    }
}
