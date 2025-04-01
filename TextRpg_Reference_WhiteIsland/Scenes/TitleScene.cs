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
