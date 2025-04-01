using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg_Reference_WhiteIsland.TalkAbouts;

namespace TextRpg_Reference_WhiteIsland.Scenes
{
    public class HomeScene : Scene
    {
        HomeTalk HomeTalk = new HomeTalk();

        public override void RenderScene()
        {
            HomeTalk.TalkHome();
        }

        public override void ChoiceScene()
        {
            Console.WriteLine("1. 집 밖으로 나간다.");
            Console.WriteLine("2. 더 잔다.");
        }

        public override void ResultScene()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("누구지...? 밖으로 나가보자");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("평생... 잠이나 쳐 자세요...");
                    Console.WriteLine("BAD ENDING");
                    Console.ResetColor();
                    return;

            }
        }

        public override void WaitScene()
        {
            Console.WriteLine("                        Enter...");
            Console.ReadLine();
        }

        public override void NextScene()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("InfrontHome");
                    break;
            }
        }
    }
}
