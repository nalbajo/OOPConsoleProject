namespace OOPConsoleProject
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*                            *");
            Console.WriteLine("*        마을을 지켜요       *");
            Console.WriteLine("*                            *");
            Console.WriteLine("******************************");
            Console.WriteLine("");
            Console.WriteLine("아무 키나 눌러 시작하세요!");
        }
        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
