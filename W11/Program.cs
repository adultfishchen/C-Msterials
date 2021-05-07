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
            if (LibraryPath[LibraryPath.Length - 1] != '\\')
            {// MacOS的路徑應該要把 \\ => 改成 /
                LibraryPath += '\\';
            }
        }
        public string Txt2AsciiString(string filename)
        {// 讀檔案回傳字串
            return File.ReadAllText(this.LibraryPath + filename);
        }
        public void Ascii2Txt(string filename)
        {// 讀字串寫成檔案
            if (!File.Exists(this.LibraryPath + filename))
            {
                Console.WriteLine("{0} does not exist.\nFile will been created.", filename);
            }
            Console.WriteLine("Input \"-1\" as the end of the AsciiArt.\nPaste your AsciiArt below:");
            using (StreamWriter EchoPath = File.CreateText(this.LibraryPath + filename))
            {// 將貼到Terminal上的AsciiArt寫入
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "-1") break;
                    EchoPath.WriteLine(line);
                }
                Console.WriteLine("Your AsciiArt has been saved at {0}", this.LibraryPath + filename);
            }
        }
    }

    class Token
    {   // Token can be regarded as all character's  base(such as Player, NPC, enemy...)
        protected string art, name;
        public Status status;
        protected Random rnd;
        public Token()
        {// Constructors
            this.art = "";
            this.name = "";
            this.status = new Status();
            rnd = new Random();
        }
        public Token(string Art, string Name)
        {// Constructors
            this.art = Art;
            this.name = Name;
            this.status = new Status();
            rnd = new Random();
        }
        public string Art
        {// Auto-implemented property:
            get { return art; }
            set { art = value; }
        }
        public string Name
        {// Auto-implemented property:
            get { return name; }
            set { name = value; }
        }
        public virtual void ShowInfo()
        {// Method
            Console.WriteLine("{0}\nName: {1}", this.art, this.name);
            this.status.ShowStatus();
        }
        public int Attack()
        {
            return 18;
        }
        public void Defence(int AttackPoint)
        {
            AttackPoint = 27;
        }
    }

    class Status
    {
        private int hp;
        private int atk;
        private int def;
        private int luc;
        private Random rnd;
        public Status()
        {// Constructors
            rnd = new Random();
            this.hp = rnd.Next() % 50 + 50;
            this.atk = rnd.Next() % 100 + 200;
            this.def = rnd.Next() % 30 + 1;
            this.luc = rnd.Next() % 100 + 1;
        }
        public int Hp
        {// Auto-implemented property:
            get { return this.hp; }
            set { this.hp = value; }
        }
        public int Atk
        {// Auto-implemented readonly property:
            get { return this.atk; }
        }
        public int Def
        {// Auto-implemented readonly property:
            get { return this.def; }
        }
        public int Luc
        {// Auto-implemented readonly property:
            get { return this.luc; }
        }
        public void ShowStatus()
        {// Auto-implemented readonly property:
            Console.WriteLine("  HP:{0, 3}\n ATK:{1, 3}\n DEF:{2, 3}\n LUC:{3, 3}", this.hp, this.atk, this.def, this.luc);
        }
    }// Status

    class Enemy : Token
    {// Inherit
        public Enemy()
        {// DIY
        }
        public Enemy(string Art, string Name, string Quote)
        {// DIY
        }
        public override void ShowInfo()
        {// DIY, or create another
        }
    }

    class Program
    {
        static void easy()
        {
            string path = @"D:\C#\C-Msterials\W11\AsciiArt";
            LibraryDealer ld = new LibraryDealer(path);
            string name = "Ghy";
            Token BSMF = new Token(ld.Txt2AsciiString("1.txt"), name);
            BSMF.ShowInfo();
        }

        static void middle()
        {
            string path = @"D:\C#\C-Msterials\W11\AsciiArt";
            LibraryDealer ld = new LibraryDealer(path);
            string name1 = "O-Ghy";
            Token BSMF1 = new Token(ld.Txt2AsciiString("1.txt"), name1);
            Console.WriteLine("{0}'s status is");
            BSMF1.status.ShowStatus();
            Console.WriteLine("-----------------------------------");
            string name2 = "N-Ghy";
            Token BSMF2 = new Token(ld.Txt2AsciiString("2.txt"), name2);
            BSMF2.status.ShowStatus();
            Console.WriteLine("-----------------------------------");
            while(BSMF1.status.Hp>0 && BSMF2.status.Hp>0)
            {
                BSMF1.Attack();
                BSMF2.Defence(BSMF1.Attack(),BSMF2.Name);
                BSMF2.status.Hp -= BSMF1.Attack();
                BSMF2.status.ShowStatus();

                Console.WriteLine("{0} made a critical hit!!")
                BSMF1.Attack();
                BSMF2.Defence(BSMF1.Attack(),BSMF2.Name);
                BSMF2.status.Hp -= BSMF1.Attack();
                BSMF2.status.ShowStatus();
            }
        } 
        
        static void Main(string[] args)
        {
            easy();
            Console.WriteLine();
            middle();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadLine();

        }
    }
}
