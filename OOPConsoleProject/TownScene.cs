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
