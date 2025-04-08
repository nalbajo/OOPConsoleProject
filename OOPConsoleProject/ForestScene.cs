namespace OOPConsoleProject
{
    public class ForestScene : Scene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("당신은 마을 밖, 숲으로 나왔습니다.");
            Console.WriteLine("세 갈래 길이 있습니다.");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 북쪽 탑으로 가기");
            Console.WriteLine("2. 숲 깊은 곳으로 가기");
            Console.WriteLine("3. 남쪽 던전으로 가기");
            Console.WriteLine("4. 마을로 돌아가기");
            Console.WriteLine();
            Util.Print("숫자 키를 눌러 이동하기", ConsoleColor.DarkGray, 0);
            Console.WriteLine();
        }
        protected ConsoleKey input;
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("북쪽 탑으로 이동합니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("숲 안쪽으로 들어갑니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("남쪽 던전으로 이동합니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("마을로 돌아갑니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
                default:
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                    break;
            }
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("NorthTower");
                    break;
                case ConsoleKey.D2:
                    //Todo : 숲 안쪽으로 전환
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("SouthDungeon");
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Town1");
                    break;
            }
        }


    }
}
