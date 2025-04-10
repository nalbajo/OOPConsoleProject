using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class FloorB1 : Scene
    {
        public bool SouthDungeonFloorB1;
        private ConsoleKey input;
       
        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;

        public FloorB1()
        {
            mapData = new string[]
            {
                "##########",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "##########"
            };
            map = new bool[10, 10];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Forest", 'F', new Vector2(1, 1)));
            gameObjects.Add(new Slime(new Vector2(5, 7)));

            Game.Player.position = new Vector2(1, 1);
            Game.Player.map = map;
        }
        public override void Render()
        {
            if (SouthDungeonFloorB1 == true)
            {
                Console.WriteLine("지하 2층으로 갑니다.");
                Util.Print("", ConsoleColor.White, 1000);
                Game.ChangeScene("FloorB2");
            }
            else
            {
                PrintMap();
                Console.WriteLine("던전 지하 1층입니다.");
                foreach (GameObject go in gameObjects)
                {
                    go.Print();
                }
                Game.Player.Print();

                Console.SetCursorPosition(0, map.GetLength(0) + 2);

                Game.PrintInfo();
                Console.WriteLine();
                Game.Player.Inventory.PrintAll();
            }
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }


        public override void Update()
        {
            Game.Player.Action(input);
        }

        public override void Result()
        {
            foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position)
                {
                    go.Interact(Game.Player);
                    if (go.isOnce == true)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }
        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
