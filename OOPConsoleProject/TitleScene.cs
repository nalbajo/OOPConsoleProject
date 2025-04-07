namespace OOPConsoleProject
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*                            *");
            Console.WriteLine("*       마을의 용사에요      *");
            Console.WriteLine("*                            *");
            Console.WriteLine("******************************");
            Console.WriteLine("");
            Console.WriteLine("▶ 아무 키나 눌러 시작하세요!");
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
