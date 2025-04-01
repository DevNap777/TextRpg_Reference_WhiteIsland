using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg_Reference_WhiteIsland.TalkAbouts;

namespace TextRpg_Reference_WhiteIsland.Scenes
{
    public class InfrontHomeScene : Scene
    {
        HomeTalk HomeTalk = new HomeTalk();

        public override void RenderScene()
        {
            HomeTalk.TalkHome();

            Console.WriteLine("1. 집 밖으로 나간다.");
            Console.WriteLine("2. 더 잔다.");
        }

        public override void ChoiceScene()
        {
            
        }

        public override void ResultScene()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("누구지.. 밖으로 나가보자");
                    break;
                case ConsoleKey.D2:
                    Game.GameOver("평생... 잠이나 쳐 자세요...");
                    break;

            }
        }

        public override void WaitScene()
        {
            
        }

        public override void NextScene()
        {
            
        }
    }
}
