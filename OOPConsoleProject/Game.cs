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

        public static bool gameOver;

        public static void Start()
        {
            gameOver = false;

            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Story", new StoryScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Town1", new Town1Scene());
            sceneDic.Add("Store",new StoreScene());
            sceneDic.Add("Store1", new Store1Scene());
            sceneDic.Add("Forest",new ForestScene());

            curScene = sceneDic["Title"];

            Console.CursorVisible = false;
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
