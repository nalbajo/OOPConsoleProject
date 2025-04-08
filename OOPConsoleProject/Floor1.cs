namespace OOPConsoleProject
{
    public class Floor1 : Scene
    {
        public bool NorthTowerFloor1 = false;


        public override void Render()
        {
            if (NorthTowerFloor1 == true)
            {
                Console.WriteLine("지상 2층으로 갑니다.");
                Util.Print("", ConsoleColor.White, 1000);
                Game.ChangeScene("Floor2");
            }
            else
            {
                Console.WriteLine("탑 1층입니다.");
                Console.WriteLine("퍼즐의 방입니다. 문제를 보고 풀어내면 됩니다.");
                Console.WriteLine();
                Console.WriteLine("◀ △ ▼ ▶ ◁ ▲ △");
                Console.WriteLine("채워진 곳은 곧장가고 빈 곳은 반대로 돌아가라.");
            }
        }
        protected ConsoleKey input;
        protected ConsoleKey input8;
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.LeftArrow:
                    Console.Write("←");
                    ConsoleKey input2 = Console.ReadKey(true).Key;
                    switch (input2)
                    {
                        case ConsoleKey.DownArrow:
                            Console.Write("↓");
                            ConsoleKey input3 = Console.ReadKey(true).Key;
                            switch (input3)
                            {
                                case ConsoleKey.DownArrow:
                                    Console.Write("↓");
                                    ConsoleKey input4 = Console.ReadKey(true).Key;
                                    switch (input4)
                                    {
                                        case ConsoleKey.RightArrow:
                                            Console.Write("→");
                                            ConsoleKey input5 = Console.ReadKey(true).Key;
                                            switch (input5)
                                            {
                                                case ConsoleKey.RightArrow:
                                                    Console.Write("→");
                                                    ConsoleKey input6 = Console.ReadKey(true).Key;
                                                    switch (input6)
                                                    {
                                                        case ConsoleKey.UpArrow:
                                                            Console.Write("↑");
                                                            ConsoleKey input7 = Console.ReadKey(true).Key;
                                                            switch (input7)
                                                            {
                                                                case ConsoleKey.DownArrow:
                                                                    Console.WriteLine("↓");
                                                                    Console.WriteLine("정답입니다!");
                                                                    NorthTowerFloor1 = true;
                                                                    Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                                                                    Console.ReadKey(true);
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("1. 탑 2층으로 올라가기");
                                                                    Console.WriteLine("2. 탑에서 나가기");
                                                                    Util.Print("▶ 숫자 키를 눌러 이동하기", ConsoleColor.DarkGray, 0);
                                                                    Console.WriteLine();
                                                                    ConsoleKey input8 = Console.ReadKey(true).Key;
                                                                    switch (input8)
                                                                    {
                                                                        case ConsoleKey.D1:
                                                                            Console.WriteLine("탑 2층으로 올라갑니다.");
                                                                            Util.Print("", ConsoleColor.White, 1000);
                                                                            Game.ChangeScene("Floor2");
                                                                            break;
                                                                        case ConsoleKey.D2:
                                                                            Console.WriteLine("탑 밖으로 나갑니다.");
                                                                            Util.Print("", ConsoleColor.White, 1000);
                                                                            Game.ChangeScene("Forest");
                                                                            break;
                                                                        default:
                                                                            Console.WriteLine("올바른 숫자를 입력해주세요.");
                                                                            break;
                                                                    }
                                                                    break;
                                                                default:
                                                                    Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                                                                    break;
                                                            }
                                                            break;
                                                        default:
                                                            Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                                                            break;
                                                    }
                                                    break;
                                                default:
                                                    Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                                                    break;
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("틀렸습니다. 다시 입력하세요.");
                    break;
            }

        }

        public override void Result()
        {


        }
    }
}
