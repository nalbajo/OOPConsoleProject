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
            Console.WriteLine("사람들로 북적이는 마을입니다.");
            Console.WriteLine("많은 사람들이 당신을 보고 공손하게 인사합니다.");
            Console.WriteLine("당신에게 말을 걸어오는 사람이 있습니다.");
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
