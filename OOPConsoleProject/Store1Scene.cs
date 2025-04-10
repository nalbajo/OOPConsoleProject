using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Store1Scene : Scene
    {

        public int Wand = 15;
        public int shuriken = 10;
        public int bar = 5;


        public override void Render()
        {
            WeaponBuilder wandBuilder = new WeaponBuilder();
            wandBuilder
                .SetName("마력이 깃든 지팡이")
                .SetDescription("엄청난 마력이 들어있는 지팡이이다.")
                .SetPower(5);

            Weapon weapon0 = wandBuilder.Build();

            WeaponBuilder shurikenBuilder = new WeaponBuilder();
            shurikenBuilder
                .SetName("검은 기운의 수리검")
                .SetDescription("불길한 기운이 가득 찬 수리검이다.")
                .SetPower(3);

            Weapon weapon1 = shurikenBuilder.Build();

            WeaponBuilder barBuilder = new WeaponBuilder();
            barBuilder
                .SetName("진짜 쓸모없는 종이 묶인 막대기")
                .SetDescription("막대가 곱게 묶여있는 종이이다.")
                .SetPower(1);

            Weapon weapon2 = barBuilder.Build();

            Console.WriteLine("상점으로 들어왔습니다.");
            Console.WriteLine("구매하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine($"1. {weapon0.name}\t{weapon0.description}\t 공격력 20 : 15 G");
            // 공격력 표시는 일부러 해놓음. 플레이어가 구매 했을 때, 플레이어는 마력이 없어 지팡이로 때리는 방식으로 공격할 예정
            Console.WriteLine($"2. {weapon1.name}\t{weapon1.description}\t 공격력 {weapon1.power} : 10 G");
            Console.WriteLine($"3. {weapon2.name}\t{weapon2.description}\t 공격력 {weapon2.power} : 5 G");
            Console.WriteLine("4. 아무것도 사지 않고 나간다.");
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
                    if (Wand > Game.Player.Gold)
                    {
                        Console.WriteLine("돈이 부족하여 구매할 수 없습니다.");
                    }
                    else
                    {
                        Game.Player.Gold -= 15;
                        Console.WriteLine("골드를 사용하여 구매합니다.");
                    }
                        break;
                case ConsoleKey.D2:
                    if (shuriken > Game.Player.Gold)
                    {
                        Console.WriteLine("돈이 부족하여 구매할 수 없습니다.");
                    }
                    else
                    {
                        Game.Player.Gold -= 10;
                        Console.WriteLine("골드를 사용하여 구매합니다.");
                    }
                    break;
                case ConsoleKey.D3:
                    if (bar > Game.Player.Gold)
                    {
                        Console.WriteLine("돈이 부족하여 구매할 수 없습니다.");

                    }
                    else
                    {
                        Game.Player.Gold -= 5;
                        Console.WriteLine("골드를 사용하여 구매합니다.");
                    }
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("상점을 나갑니다.");
                    Util.Print("", ConsoleColor.White, 1000);
                    break;
            }

        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Wand > Game.Player.Gold)
                    {
                        Console.WriteLine("돈이 부족하여 구매할 수 없습니다.");
                    }
                    else
                    {
                        Game.Player.Gold -= 15;
                        Console.WriteLine("골드를 사용하여 구매합니다.");
                    }
                    break;
                case ConsoleKey.D2:
                    if (shuriken > Game.Player.Gold)
                    {
                        Console.WriteLine("돈이 부족하여 구매할 수 없습니다.");
                    }
                    else
                    {
                        Game.Player.Gold -= 10;
                        Console.WriteLine("골드를 사용하여 구매합니다.");
                    }
                    break;
                case ConsoleKey.D3:
                    if (bar > Game.Player.Gold)
                    {
                        Console.WriteLine("돈이 부족하여 구매할 수 없습니다.");

                    }
                    else
                    {
                        Game.Player.Gold -= 5;
                        Console.WriteLine("골드를 사용하여 구매합니다.");
                    }
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Town1");
                    break;
            }
        }
    }
}
