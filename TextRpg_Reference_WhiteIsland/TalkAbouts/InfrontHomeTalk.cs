using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg_Reference_WhiteIsland.TalkAbouts
{
    public class InfrontHomeTalk
    {
        public void TalkInfrontHome()
        {
            Utill.Print("끼익...", ConsoleColor.DarkGray, 1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("아 \"여사아치이인\"이잖아? 어쩐일이야?", ConsoleColor.DarkGray, 1000);
            Console.WriteLine();
            Console.WriteLine("                                     Enter...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("여사아치이인 : 어쩐일이긴, @#$@#& 같은 !@$! 뒤질라고 빨리 안나올래? 출발해야한다고!!");
            Console.WriteLine();
            Utill.Print("\"나아암사아치이인\" : 어... 그게....", ConsoleColor.White, 1000);
            Console.WriteLine();
        }
    }
}
