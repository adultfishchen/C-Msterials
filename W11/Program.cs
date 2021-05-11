using System;
using System.IO;

namespace W11
{
    class LibraryDealer
    {
        private string LibraryPath;
        public LibraryDealer(string path)
        {
            this.LibraryPath = path;
            if (LibraryPath[LibraryPath.Length-1]!='\\')
            {// MacOS的路徑應該要把 \\ => 改成 /
                LibraryPath+='\\';
            }
        }
        public string Txt2AsciiString(string filename)
        {// 讀檔案回傳字串
            return File.ReadAllText(this.LibraryPath + filename);
        }
        public void Ascii2Txt(string filename)
        {// 讀字串寫成檔案
            if(!File.Exists(this.LibraryPath+filename))
            {
                Console.WriteLine("{0} does not exist.\nFile will been created.", filename);
            }
            Console.WriteLine("Input \"-1\" as the end of the AsciiArt.\nPaste your AsciiArt below:");
            using(StreamWriter EchoPath = File.CreateText(this.LibraryPath+filename))
            {// 將貼到Terminal上的AsciiArt寫入
                while(true) {
                    string line = Console.ReadLine();
                    if (line == "-1") break;
                    EchoPath.WriteLine(line);
                }
                Console.WriteLine("Your AsciiArt has been saved at {0}", this.LibraryPath+filename);
            }
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Easy();
            Medium();
            Hard();
            Console.ReadLine();
        }
        static void Easy()
        {
            LibraryDealer ld = new LibraryDealer(@"D:\C#\C-Msterials\W11\AsciiArt");
            Token peko = new Token(ld.Txt2AsciiString("1.txt"), "N_Ghy");
            peko.ShowInfo();
        }
        
        static void Medium()
        {
            LibraryDealer ld = new LibraryDealer(@"D:\C#\C-Msterials\W11\AsciiArt");
            Token peko = new Token(ld.Txt2AsciiString("1.txt"), "N_Ghy");
            Token miko = new Token(ld.Txt2AsciiString("2.txt"), "O_Ghy");
            // ---
            Console.WriteLine("{0}'s status is", peko.Name);
            peko.status.ShowStatus();
            Console.WriteLine("--------------------");
            Console.WriteLine("{0}'s status is", miko.Name);
            miko.status.ShowStatus();
            Console.WriteLine("--------------------");
            BigWar(peko, miko);
            // Because classes are reference types, someone's Hp becomes to 0 now.
            void BigWar(Token P1, Token P2)
            {// PekoMiko Daisensou
                /* 是說關於RPG中，物件間的對戰，
                 * 同學可以盡情發揮創意，
                 * 利用添加不同的properties給物件，
                 * 來自創各種遊戲的戰鬥系統。
                 * 例如：Status若再加入int spd 代表腳色的速度能力值，
                 * 那我們這邊BigWar函式，就可以根據物件.status.spd決定誰先攻。
                 */
                while(true)
                {
                    P2.Defence(P1.Attack());
                    if(P2.status.Hp <= 0)
                    {
                        Console.WriteLine("K.O.\n{0}\n{1} is winner", P1.Art, P1.Name);
                        break;
                    }
                    Console.WriteLine();
                    P1.Defence(P2.Attack());
                    if(P1.status.Hp <= 0)
                    {
                        Console.WriteLine("K.O.\n{0}\n{1} is winner", P2.Art, P2.Name);
                        break;
                    }
                    Console.WriteLine("--------------------");
                }
            }// Big War
        }

        static void Hard()
        {
            LibraryDealer ld = new LibraryDealer(@"D:\C#\C-Msterials\W11\AsciiArt");
            Enemy boss = new Enemy(ld.Txt2AsciiString("1.txt"), "N_Ghy", "Hello, my fans!");
            //Enemy boss = new Enemy(ArtLibrary.Squirtle, "Squirtle", "傑尼傑尼!");
            boss.ShowInfo();
        }
    }
}