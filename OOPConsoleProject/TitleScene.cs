namespace OOPConsoleProject
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******************************");
            Console.WriteLine("*                            *");
            Console.WriteLine("*       마을의 용사에요      *");
            Console.WriteLine("*                            *");
            Console.WriteLine("******************************");
            Console.ResetColor();
            Util.Print("",ConsoleColor.White, 1000);
            Util.Print("▶ 아무 키나 눌러 시작하세요!",ConsoleColor.White, 1000);
        }
        protected ConsoleKey input;
        public override void Input()
        {
            Console.ReadKey(true);
        }
        public override void Update() { }
        public override void Result()
        {
            Game.ChangeScene("Story");
        }


    }
}
