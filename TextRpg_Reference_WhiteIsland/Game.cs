﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg_Reference_WhiteIsland.Scenes;

namespace TextRpg_Reference_WhiteIsland
{
    /// Game class는 처음부터 끝까지 사용할 class 이므로 static으로 생성
    public static class Game
    {
        /// <summary>
        /// 게임에 필요한 정보들 생성 
        /// </summary>
        /// 게임 오버가 되기 전까지는 게임 계속 실행
        public static bool gameOver;

        /// Scene들이 많이 있으므로 Dictionary로 관리
        private static Dictionary<string, Scene> sceneDic;

        /// <summary>
        /// Scene을 담을 수 있는 변수 선언
        /// </summary>
        private static Scene curScene;

        /// <summary>
        /// 게임 시작 
        /// </summary>
        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("InfrontHome", new InfrontHomeScene());

            curScene = sceneDic["Title"];
        }

        /// <summary>
        /// 게임 종료
        /// </summary>
        public static void End()
        {

        }

        /// <summary>
        /// 게임 동작
        /// </summary>
        public static void Run()
        {
            // 게임오버가 아니라면? 계속 플레이할 수 있게
            // 현재의 Scene을 계속 플레이하도록 해야 함.
            while (gameOver == false)
            {
                Console.Clear();
                curScene.RenderScene();
                Console.WriteLine();
                curScene.ChoiceScene();
                curScene.InputScene();
                Console.WriteLine();
                curScene.ResultScene();
                Console.WriteLine();
                curScene.WaitScene();
                curScene.NextScene();
            }
        }

        /// <summary>
        /// sceneName을 통해 Scene 변경
        /// </summary>
        /// <param name="sceneName"></param>
        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void GameOver(string reasone)
        {
            Console.WriteLine("/////..././/././/////.//...///...////");
            Console.WriteLine("..                                 //");
            Console.WriteLine("//             YOU DIE             ..");
            Console.WriteLine("..                                 //");
            Console.WriteLine("/..//..././/././/..///.//...///...///");
            Console.WriteLine();
            Console.WriteLine(reasone);

            gameOver = true;
        }
    }
}
