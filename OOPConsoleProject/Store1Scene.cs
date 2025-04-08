using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Store1Scene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("상점으로 들어왔습니다.");
            Console.WriteLine("구매하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 마력이 깃든 지팡이 : 15 G");
            Console.WriteLine("2. 검은 기운의 수리검 : 10 G");
            Console.WriteLine("3. 진짜 쓸모없는 종이묶인 막대기 : 5 G");
            Console.WriteLine();
            
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
