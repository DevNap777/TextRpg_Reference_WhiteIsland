using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg_Reference_WhiteIsland.TalkAbouts;

namespace TextRpg_Reference_WhiteIsland
{
    public class InfrontHomeScene : Scene
    {
        InfrontHomeTalk infrontHomeTalk = new InfrontHomeTalk();
        public override void RenderScene()
        {
            infrontHomeTalk.TalkInfrontHome();
        }

        public override void ChoiceScene()
        {
            Console.WriteLine("1. 출발한다");
            Console.WriteLine("2. 들어가서 다시 잔다.");
            Console.WriteLine("3. 욕 먹은게 빡친다.");
        }

        public override void ResultScene()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Utill.Print("아... 알았어 잠깐만 기다려줘!", ConsoleColor.White, 1000);
                    Utill.Print("자 이제 출발할까!?", ConsoleColor.White, 1000);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Utill.Print("뚜둑.. 뚜둑.....", ConsoleColor.DarkRed, 1400);
                    Utill.Print("퍽...! 퍽....!", ConsoleColor.DarkRed, 1400);
                    Utill.Print("이 @#$$@#&& 같은... 게... 내..말을 안ㄷ....ㅡㄹ..어..?", ConsoleColor.DarkRed, 1400);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("BAD ENDING");
                    Console.ResetColor();
                    return;
                case ConsoleKey.D3:
                    /// TODO : 뻘 짓 말고 바꿔야 함.
                    Console.Clear();
                    Utill.Print(".... 흐음...", ConsoleColor.DarkRed, 1400);
                    Utill.Print("틱.. 철컥..", ConsoleColor.DarkRed, 1000);
                    Console.Clear();
                    Utill.Print("\a 탕! 탕!!", ConsoleColor.DarkRed, 1400);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("후루 후루 후루~");
                    Console.WriteLine();
                    Console.WriteLine("탕탕 후루루루루");
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
                /// TODO : 항구 씬 추가
                case ConsoleKey.D1:
                    //Game.ChangeScene();
                    break;
            }
        }
    }
}
