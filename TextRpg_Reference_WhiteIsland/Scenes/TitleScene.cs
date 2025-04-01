using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg_Reference_WhiteIsland.Scenes
{
    public class TitleScene : Scene
    {
        public override void RenderScene()
        {
            Console.WriteLine("/////..././/././/////.//...///...////");
            Console.WriteLine("//             하얀 섬             ..");
            Console.WriteLine("..           White IsLand          //");
            Console.WriteLine("/..//..././/././/..///.//...///...///");
            Console.WriteLine();
        }
        public override void ChoiceScene()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Exit");
        }

        public override void ResultScene()
        {
            
        }

        public override void WaitScene()
        {
            
        }
        public override void NextScene()
        {
            switch (input)
            {
                /// TODO : 게임 시작 시, 집 앞 장면으로 이동
                case ConsoleKey.D1:
                    Game.ChangeScene("InfrontHome");
                    break;
            }

        }
    }
}
