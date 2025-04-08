namespace OOPConsoleProject
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            Util.Print("사람들로 북적이는 마을입니다.", ConsoleColor.White, 1000);
            Util.Print("많은 사람들이 당신을 보고 공손하게 인사합니다.", ConsoleColor.White, 1000);
            Util.Print("당신에게 말을 걸어오는 사람이 있습니다.", ConsoleColor.White, 1000);
            Util.Print("대화를 하시겠습니까?", ConsoleColor.White, 1000);
            Console.WriteLine();
            Console.WriteLine("1. 대화하기");
            Console.WriteLine("2. 무시하기");
            Util.Print("숫자 키를 눌러 선택하기", ConsoleColor.DarkGray, 500);
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
                    Console.WriteLine("당신에게 말을 걸어온 사람은");
                    Console.WriteLine("마을에서 당신을 가장 좋아하는 아이였습니다.");
                    Console.WriteLine("아이는 당신의 손에 꼬깃꼬깃한 종이를 쥐어줍니다.");
                    Util.Print("종이에 적힌 내용은",ConsoleColor.White,500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("하루가 가기전에 북쪽 탑과 남쪽 탑을 한 층씩 꼭 클리어");
                    Console.ResetColor();
                    Console.WriteLine("해달라는 것이었습니다.");
                    Console.WriteLine("종이를 본 당신은 마을 밖, 숲으로 나갑니다.");
                    Util.Print("▶ 아무 키나 눌러 넘어가기", ConsoleColor.DarkGray, 1000);
                    Console.ReadKey(true);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("아이가 손을 꼬옥 쥔 채 당신을 올려다봅니다.");
                    Console.WriteLine("당신은 말을 걸어온 아이를 무시했습니다.");
                    Console.WriteLine();
                    Console.WriteLine("1. 마을 밖으로 이동한다.");
                    Console.WriteLine("2. 마을 안을 둘러본다.");
                    ConsoleKey input2 = Console.ReadKey(true).Key;
                    switch (input2)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("마을 밖, 숲으로 나갑니다.");
                            Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                            Console.ReadKey(true);
                            Game.ChangeScene("Forest");

                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine("마을 안에는 상점이 있습니다.");
                            Console.WriteLine("상점으로 들어갑니다.");
                            Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                            Console.ReadKey(true);
                            Game.ChangeScene("Store");
                            break;
                        default:
                            Console.WriteLine("올바른 숫자를 입력해주세요.");
                            break;
                    }
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
                    Game.ChangeScene("Forest");
                    break;
            }
        }
    }
}
