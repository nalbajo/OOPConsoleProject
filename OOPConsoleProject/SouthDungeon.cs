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
            Util.Print("▶ 아무 키나 눌러 넘어가기", ConsoleColor.White, 2000);
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
