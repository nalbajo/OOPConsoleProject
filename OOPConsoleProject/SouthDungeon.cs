namespace OOPConsoleProject
{
    public class SouthDungeon : Scene
    {
        public override void Render()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*   ■■■■■■■■■                *");
            Console.WriteLine("* ■■         ■■■■            *");
            Console.WriteLine("*■               ■■■■  ■■■■  *");
            Console.WriteLine("*    ■■■■■■■■        ■■    ■ *");
            Console.WriteLine("*   ■        ■               *");
            Console.WriteLine("*  ■          ■              *");
            Console.WriteLine("* ■            ■            *");
            Console.WriteLine("******************************");
            Console.WriteLine("남쪽 던전에 도착했습니다.");
            Console.WriteLine();
            Console.WriteLine("남쪽 던전의 음산한 기운이 계단을 타고 내려갑니다.");
            Util.Print("", ConsoleColor.DarkGray, 1000);
            Console.WriteLine("1. 던전 안으로 들어가기");
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
            Console.WriteLine("지하 1층으로 내려갑니다.");
            Util.Print("", ConsoleColor.White, 1000);
        }
        public override void Result()
        {
            Game.ChangeScene("FloorB1");
        }
    }
}
