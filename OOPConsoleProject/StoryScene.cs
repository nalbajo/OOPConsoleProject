using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class StoryScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("당신은 마을에서 가장 인정받고 있는 용사입니다.");
            Console.WriteLine("당신은 이 게임에서 두 가지를 선택 할 수 있습니다.");
            Console.WriteLine("이미 사람들의 인정을 받고 있는 당신은");
            Console.WriteLine("마을에서만 마음 편안히 있을 수 있고");
            Console.WriteLine("마을 밖으로 나가 탑을 탐험 할 수 있습니다.");
            Console.WriteLine("당신이 어떤 선택을 하든");
            Console.WriteLine("책임은 당신에게 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("▶ 아무 키나 눌러 넘어가기");
        }
        protected ConsoleKey input;
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Result()
        {
            Game.ChangeScene("Home");
        }

        public override void Update()
        {
            
        }
    }
}
