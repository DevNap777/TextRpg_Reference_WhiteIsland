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
            Console.WriteLine("아 \"OOO\"이잖아? 어쩐일이야?", ConsoleColor.DarkGray, 1000);
            Console.WriteLine();
            Console.WriteLine("                                     Enter...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("OOO : 어쩐일이긴, @#$@#& 같은 !@$! 뒤질라고 빨리 안나올래? 출발해야한다고!!");
            Console.WriteLine();
            Utill.Print("\"아버지가방에들어간다\" : 어... 그게....", ConsoleColor.White, 1000);
            Console.WriteLine();
            Console.WriteLine("                                     Enter...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
