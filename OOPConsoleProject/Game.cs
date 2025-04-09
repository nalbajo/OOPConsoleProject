using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Game
    {

        private static Dictionary<string, Scene> sceneDic;   // 씬 관리
        private static Scene curScene;                       // 진행 중인 씬

        private static Player player;
        public static Player Player { get { return player; } }

        public static bool gameOver;

        public static void Start()
        {
            Console.CursorVisible = false;
            gameOver = false;

            // 플레이어
            player = new Player();
            player.Power = 1;
            player.Gold = 0;

            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Story", new StoryScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Town1", new Town1Scene());
            sceneDic.Add("Store",new StoreScene());
            sceneDic.Add("Store1", new Store1Scene());

            // 숲
            sceneDic.Add("Forest", new ForestScene());
            sceneDic.Add("Field", new FieldScene());

            // 탑
            sceneDic.Add("NorthTower", new NorthTower());
            sceneDic.Add("Floor1", new Floor1());

            // 던전
            sceneDic.Add("SouthDungeon", new SouthDungeon());
            sceneDic.Add("FloorB1", new FloorB1());



            curScene = sceneDic["Title"];

            Console.CursorVisible = false;
        }

        public static void PrintInfo()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("* 플레이어                   *");
            Console.WriteLine("* 힘 : {0}   소지금액 : {1}G *", player.Power, player.Gold);
            Console.WriteLine("******************************");
        }
        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }


        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        

        public static void End()
        {

        }
    }
}
