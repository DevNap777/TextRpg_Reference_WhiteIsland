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
            throw new NotImplementedException();
        }

        public override void ResultScene()
        {
            throw new NotImplementedException();
        }

        public override void WaitScene()
        {
            throw new NotImplementedException();
        }

        public override void NextScene()
        {
            throw new NotImplementedException();
        }
    }
}
