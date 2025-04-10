namespace OOPConsoleProject
{
    public class FightB1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*                       *");
            Console.WriteLine("*        -----          *");
            Console.WriteLine("*      --     --        *");
            Console.WriteLine("*     -  ○ _ ○   -      *");
            Console.WriteLine("*     --        -       *");
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 도망간다.");

            Game.PrintInfo();

            Game.Player.Inventory.PrintAll();
        }

        protected ConsoleKey input;

        public bool SouthDungeonFloorB1 { get; private set; }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("공격합니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("도망갑니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
            }
        }
        public override void Result()
        {

            switch (input)
            {
                case ConsoleKey.D1:
                    if (0 <= Game.Player.Power)
                    {
                        Console.WriteLine("공격에 성공했습니다.");
                        Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                        Console.ReadKey(true);
                        Console.WriteLine("슬라임을 잡았습니다.");
                        Util.Print("▶ 아무 키나 눌러 계속하기", ConsoleColor.DarkGray, 0);
                        Console.ReadKey(true);
                        SouthDungeonFloorB1 = true;     // 참조 어떻게..?
                        Game.ChangeScene("FloorB1");
                    }
                    else
                    {
                        Console.WriteLine("공격에 실패했습니다.");
                        Console.WriteLine("슬라임은 공격성이 없어 공격하지 않습니다.");
                        input = Console.ReadKey(true).Key;
                    }
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("FloorB1");
                    break;
            }
        }
    }
}
