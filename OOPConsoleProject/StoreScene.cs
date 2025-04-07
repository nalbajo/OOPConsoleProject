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
            Console.ReadKey(true);
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:

                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.D3:

                    break;
                default:
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                    break;
            }
        }
        public override void Result()
        {
            
        }

    }
}
