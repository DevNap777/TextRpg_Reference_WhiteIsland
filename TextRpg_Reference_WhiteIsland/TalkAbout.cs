using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg_Reference_WhiteIsland
{
    /// <summary>
    /// 캐릭터들 간의 대화를 담을 부모 클래스 생성
    /// 추상 클래스임. 자식 클래스에서 재정의
    /// </summary>
    public abstract class TalkAbout
    {
        public abstract void TalkHome();
    }
}
