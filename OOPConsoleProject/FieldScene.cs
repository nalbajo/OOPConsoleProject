using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class FieldScene : Scene
    {
        private ConsoleKey input;

        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;

        public FieldScene()
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
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Forest", 'F', new Vector2(1, 1)));

            Game.PlayerPos.position = new Vector2(1, 1);
            Game.PlayerPos.map = map;
        }

        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
            Game.PlayerPos.Print();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }



        public override void Update()
        {
            Game.PlayerPos.Move(input);
        }
        
        public override void Result()
        {

        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
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
