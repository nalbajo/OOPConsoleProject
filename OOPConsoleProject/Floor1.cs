using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOPConsoleProject
{
    public class Floor1 : Scene
    {
        static void PrintMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }
        static void Start(char[,] map)
        {
            map = new char[8, 8] 
            {
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' '}
            };
        }
        public static void Map(char[,] map)
        {
            PrintMap(map);
        }
        public override void Render()
        {
            Console.WriteLine("탑 1층입니다.");

        }

        public override void Input()
        {

        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            
        }
    }
}
