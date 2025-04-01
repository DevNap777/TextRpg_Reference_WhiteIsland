using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg_Reference_WhiteIsland
{
    /// 게임의 모든 Scene들을 담고 있을 부모 클래스
    /// 추상 클래스로 받은 후 자식 클래스에서 세부 내용 생성 예정
    public abstract class Scene
    {
        /// <summary>
        /// Scene에 대해 자식 클래스에서만 사용할 수 있도록 protected 걸어주기
        /// </summary>
        protected ConsoleKey input;

        /// <summary>
        /// Scene 상황 설명
        /// </summary>
        public abstract void RenderScene();

        /// <summary>
        /// Scene 선택지 제시
        /// </summary>
        public abstract void ChoiceScene();

        /// <summary>
        /// Scene 선택지 입력 대기
        /// Input은 모든 게임에서 사용할 요소이기 때문에 부모 클래스에서 구현
        /// </summary>
        public void InputScene()
        {
            input = Console.ReadKey(true).Key;
        }

        /// <summary>
        /// Scene 선택에 따른 결과 출력
        /// </summary>
        public abstract void ResultScene();

        /// <summary>
        /// 다음 Scene으로 넘어가기 위한 입력 대기
        /// </summary>
        public abstract void WaitScene();

        /// <summary>
        /// 다음 Scene 상황으로 전환
        /// </summary>
        public abstract void NextScene();
    }
}
