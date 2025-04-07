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

        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }

        private static void Start()
        {
            gameOver = false;

            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title",new TitleScene());

            curScene = sceneDic["Title"];
        }

        

        private static void End()
        {

        }
    }
}
