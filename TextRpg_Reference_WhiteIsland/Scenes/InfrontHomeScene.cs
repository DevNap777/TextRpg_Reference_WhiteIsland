using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg_Reference_WhiteIsland.Scenes
{
    public class InfrontHomeScene : Scene
    {
        TalkAbout TalkAbout = new TalkAbout();

        public override void RenderScene()
        {
            Console.WriteLine("19XX년 XX월 XX일");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          Enter...");
            Console.ReadLine();
            Console.Clear();
            TalkAbout.TalkInfrontHome();
        }

        public override void ChoiceScene()
        {
            
        }

        public override void ResultScene()
        {
            
        }

        public override void WaitScene()
        {
            
        }

        public override void NextScene()
        {
            
        }
    }
}
