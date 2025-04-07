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
            Console.WriteLine("사람들의 호의로 많은 물건들과");
            Console.WriteLine("따뜻한 온기가 있는 집입니다.");
            Console.WriteLine("");
        }
        protected ConsoleKey input;
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Result()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
