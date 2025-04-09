using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Fight : Scene
    {

        public override void Render()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("********************");
            Console.WriteLine("{0}");
            Console.WriteLine("1. 때린다");
            Console.WriteLine("2. 도망간다");
        }

        protected ConsoleKey input;
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            
        }
    }
}
