using System;
using System.Text.RegularExpressions; //正規表示式所需Collection

namespace Work1
{
    //Member類別，確保資料的安全性與準確性
    public class Member
    {
        private string email = " ";
        private string pass = " ";
        private string name = " ";
        private string favCuisine = " ";

        public Member(string email, string pass, string name, string favCuisine)
        {
            this.email = email;
            this.pass = pass;
            this.name = name;
            this.favCuisine = favCuisine;
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Pass
        {
            set { pass = value; }
            get { return pass; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string FavCuisine
        {
            set { favCuisine = value; }
            get { return favCuisine; }
        }
    }

    //Res1、Res2、Res3類別，確保各餐廳的座位數量的準確性
    class Res1
    {
        private int wins;
        private int aisle;
        private int booth;

        public Res1()
        {
            this.wins = 2;
            this.aisle = 2;
            this.booth = 2;
        }

        public int Wins
        {
            set { wins = value; }
            get { return wins; }
        }

        public int Aisle
        {
            set { aisle = value; }
            get { return aisle; }
        }

        public int Booth
        {
            set { booth = value; }
            get { return booth; }
        }
    }

    class Res2
    {
        private int wins;
        private int aisle;
        private int booth;

        public Res2()
        {
            this.wins = 2;
            this.aisle = 2;
            this.booth = 2;
        }

        public int Wins
        {
            set { wins = value; }
            get { return wins; }
        }

        public int Aisle
        {
            set { aisle = value; }
            get { return aisle; }
        }

        public int Booth
        {
            set { booth = value; }
            get { return booth; }
        }
    }

    class Res3
    {
        private int wins;
        private int aisle;
        private int booth;

        public Res3()
        {
            this.wins = 2;
            this.aisle = 2;
            this.booth = 2;
        }

        public int Wins
        {
            set { wins = value; }
            get { return wins; }
        }

        public int Aisle
        {
            set { aisle = value; }
            get { return aisle; }
        }

        public int Booth
        {
            set { booth = value; }
            get { return booth; }
        }
    }

    class Program
    {
        //註冊/登入函式
        static void login(Member[] m)
        {
            string email, pass, name, favCuisine = " ";
            bool vMail = false, vPass = false;
            int Uid;
            Console.Write("Please enter your school email :　");
            email = Console.ReadLine();
            string[] cheMail = email.Split('@');

            while (true)
            {
                //驗證信箱domain
                vMail = checkMail(email);
                if (vMail == true)
                {
                    //判斷是否已註冊過，未註冊過，進行密碼設置
                    checkRegis(m, email, out Uid);
                    while (Uid == 0)
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            if (m[i].Email == " ")
                            {
                                Console.WriteLine("Please set your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. : ");
                                pass = Console.ReadLine();
                                vPass = checkPass(pass);
                                name = cheMail[0];
                                //驗證密碼設置
                                while (vMail)
                                {
                                    switch (vPass)
                                    {
                                        case true:
                                            Console.WriteLine("Register succeed!");
                                            m[i].Name = name;
                                            m[i].Pass = pass;
                                            break;
                                        case false:
                                            Console.WriteLine("Please reset your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. : ");
                                            pass = Console.ReadLine();
                                            vPass = checkPass(pass);
                                            continue;
                                    }
                                    break;
                                }
                                Console.WriteLine("Welcome {0} ! Hope you have a good experience throught our website.", m[i].Name);
                                Console.Write("Do you want to change your name? (y/n) : ");
                                string cN = Console.ReadLine();
                                while (true)
                                {
                                    if (cN.ToLower() == "yes" || cN.ToLower() == "y")
                                    {
                                        Console.Write("Please enter your name : ");
                                        name = Console.ReadLine();
                                        m[i].Name = name;
                                        Console.Write("Which is your favorite cuisine, {0}? (A.Chi、B.West、C.Multi-cultural) : ", m[i].Name);
                                        string fChoice = Console.ReadLine();
                                        while (favCuisine == " ")
                                        {
                                            switch (fChoice.ToUpper())
                                            {
                                                case "A":
                                                    favCuisine = "Chinese";
                                                    m[i].FavCuisine = favCuisine;
                                                    break;
                                                case "B":
                                                    favCuisine = "West";
                                                    m[i].FavCuisine = favCuisine;
                                                    break;
                                                case "C":
                                                    favCuisine = "Multi-cultural";
                                                    m[i].FavCuisine = favCuisine;
                                                    break;
                                                default:
                                                    Console.WriteLine("Error!Enter character in [A-C]~");
                                                    Console.Write("Please choose your favorite cuisine again, {0} ! (A.Chi、B.West、C.Multi-cultural) : ", m[i].Name);
                                                    fChoice = Console.ReadLine();
                                                    continue;
                                            }
                                            Console.WriteLine("Great, {0}!! Your favorite cuisine is {1}", m[i].Name, m[i].FavCuisine);
                                            m[i] = new Member(email, pass, name, favCuisine);
                                            break;
                                        }
                                        break;
                                    }
                                    else if (cN.ToLower() == "no" || cN.ToLower() == "n")
                                    {
                                        Console.Write("Which is your favorite cuisine, {0}? (A.Chi B.West C.Multi-cultural) : ", m[i].Name);
                                        string fChoice = Console.ReadLine();
                                        while (favCuisine == " ")
                                        {
                                            switch (fChoice.ToUpper())
                                            {
                                                case "A":
                                                    m[i].FavCuisine = "Chinese";
                                                    break;
                                                case "B":
                                                    m[i].FavCuisine = "West";
                                                    break;

                                                case "C":
                                                    m[i].FavCuisine = "Multi-cultural";
                                                    break;
                                                default:
                                                    Console.WriteLine("Error!Enter character in [A-C]~");
                                                    Console.Write("Please choose your favorite cuisine again, {0} ! (A.Chi、B.West、C.Multi-cultural) : ", m[i].Name);
                                                    fChoice = Console.ReadLine();
                                                    continue;
                                            }
                                            Console.WriteLine("Great, {0}!! Your favorite cuisine is {1}", m[i].Name, m[i].FavCuisine);
                                            m[i] = new Member(email, name, pass, favCuisine);
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error!Enter y/n");
                                        Console.Write("Do you want to change your name? (y/n) :");
                                        cN = Console.ReadLine();
                                        continue;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }

                    while (Uid != 0)
                    {
                        //已註冊過，進行密碼重設或登入
                        Console.WriteLine("You've been our member,{0}!", m[Uid].Name);
                        while (true)
                        {
                            //詢問是否記得密碼
                            Console.Write("Do you remember your password? (y/n): ");
                            string Uselec = Console.ReadLine();
                            if (Uselec.ToLower() == "yes" || Uselec.ToLower() == "y")
                            {
                                int k = 3;
                                //考量資安問題，3次密碼錯誤，強制重設
                                while (k > 0)
                                {
                                    Console.WriteLine("Please enter your password: ");
                                    string Upass = Console.ReadLine();
                                    if (m[Uid].Pass == Upass)
                                    {
                                        Console.WriteLine("Login successfully, {0}!", m[Uid].Name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong password, please try again!", m[Uid].Name);
                                        continue;
                                    }
                                }
                                Console.WriteLine("You've failed at logining for three times! For security, you need to reset password!");
                                Console.WriteLine("Please set your new password: ");
                                string Unpass = Console.ReadLine();
                                if (checkPass(Unpass))
                                {
                                    Console.WriteLine("Reset password successfully!");
                                    m[Uid].Pass = Unpass;
                                }
                                break;
                            }
                            //忘記密碼，進行重設
                            else if (Uselec.ToLower() == "no" || Uselec.ToLower() == "n")
                            {
                                Console.WriteLine("Please set your new password: ");
                                string Unpass = Console.ReadLine();
                                if (checkPass(Unpass))
                                {
                                    Console.WriteLine("Reset password successfully!");
                                    m[Uid].Pass = Unpass;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error!Enter y/n");
                                Console.Write("Do you remember your password? (y/n) :");
                                Uselec = Console.ReadLine();
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    Console.Write("Please re-enter your school email :　");
                    email = Console.ReadLine();
                    cheMail = email.Split('@');
                    vMail = checkMail(email);
                    continue;
                }
            }
        }

        //判斷是否重複註冊
        static void checkRegis(Member[] m, string mail, out int Uid)
        {
            for (int i = 0; i < 30; i++)
            {
                if (m[i].Email == mail)
                {
                    Uid = i;
                    break;
                }
            }
            Uid = 0;

        }
        //信箱確認函式
        static bool checkMail(string mail)
        {
            if (Regex.IsMatch(mail, @"^[\w0-9\.-]*@ntust\.edu\.tw$") == true || Regex.IsMatch(mail, @"^[\w0-9\.-]*@ntu\.edu\.tw$") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //密碼設置驗證函式
        static bool checkPass(string p)
        {
            if (Regex.IsMatch(p, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\W).{10,}$") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //訂位函式
        static void reserve(Member[] m, Res1 r1, Res2 r2, Res3 r3)
        {
            int Uid;
            Console.Write("Do you have a membership? (Y/N): ");
            string UcheMem = Console.ReadLine();

            while (true)
            {
                //擁有會員身分
                if (UcheMem.ToLower() == "yes" || UcheMem.ToLower() == "y")
                {
                    //提供會員名稱
                    Console.WriteLine("Please tell us your registered email?");
                    string Uacc = Console.ReadLine();
                    while (true)
                    {
                        if (checkMail(Uacc) == true)
                        {
                            checkRegis(m, Uacc, out Uid);
                            while (Uid != 0)
                            {
                                switch (m[Uid].FavCuisine)
                                {
                                    case "Chinese":
                                        Console.WriteLine("Hello, {0}! Your favorite cuisine is {1}, we recommend restaurant 1 for you!!", m[Uid].Name, m[Uid].FavCuisine);
                                        break;
                                    case "West":
                                        Console.WriteLine("Hello, {0}! Your favorite cuisine is {1}, we recommend restaurant 2 for you!!", m[Uid].Name, m[Uid].FavCuisine);
                                        break;
                                    case "Multi-cultural":
                                        Console.WriteLine("Hello, {0}! Your favorite cuisine is {1}, we recommend restaurant 3 for you!!", m[Uid].Name, m[Uid].FavCuisine);
                                        break;
                                }
                                //預約流程
                                while (true)
                                {
                                    Console.WriteLine("Please choose a restaurant you like from the following list(1. Chinese Food 2. West Food 3. Multi-cultural Food) :");
                                    int resN = int.Parse(Console.ReadLine());
                                    //預約的餐廳與預約的座位形式
                                    string resRest, sType;
                                    while (true)
                                    {
                                        if (resN >= 1 && resN <= 3)
                                        {
                                            switch (resN)
                                            {
                                                case 1:
                                                    resRest = "Chinese Food";
                                                    Console.WriteLine("How many people will visit?");
                                                    int pNum = int.Parse(Console.ReadLine());
                                                    //3人(含)安排窗邊位子
                                                    if (pNum > 0 && pNum <= 3 && r1.Wins != 0)
                                                    {
                                                        r1.Wins--;
                                                        sType = "Windowsides";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    //4~6人(含)安排走道位子
                                                    else if (pNum > 3 && pNum <= 6 && r1.Aisle != 0)
                                                    {
                                                        r1.Aisle--;
                                                        sType = "Aislesides";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    //6~10人(含)安排包廂
                                                    else if (pNum > 6 && pNum <= 10 && r1.Booth != 0)
                                                    {
                                                        r1.Booth--;
                                                        sType = "Booth";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    //超過10人，不可預約
                                                    else if (pNum > 10)
                                                    {
                                                        Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                    }
                                                    //所要預訂的形式已滿
                                                    else
                                                    {
                                                        Console.WriteLine("Sorry, our restaurant is full!");
                                                    }
                                                    break;

                                                case 2:
                                                    resRest = "West Food";
                                                    Console.WriteLine("How many people will visit?");
                                                    pNum = int.Parse(Console.ReadLine());
                                                    if (pNum > 0 && pNum <= 3 && r2.Wins != 0)
                                                    {
                                                        r2.Wins--;
                                                        sType = "Windowsides";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    else if (pNum > 3 && pNum <= 6 && r2.Aisle != 0)
                                                    {
                                                        r2.Aisle--;
                                                        sType = "Aislesides";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    else if (pNum > 6 && pNum <= 10 && r2.Booth != 0)
                                                    {
                                                        r2.Booth--;
                                                        sType = "Booth";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    else if (pNum > 10)
                                                    {
                                                        Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Sorry, our restaurant is full!");
                                                    }
                                                    break;

                                                case 3:
                                                    resRest = "Multi-cultural Food";
                                                    Console.WriteLine("How many people will visit?");
                                                    pNum = int.Parse(Console.ReadLine());
                                                    if (pNum > 0 && pNum <= 3 && r3.Wins != 0)
                                                    {
                                                        r3.Wins--;
                                                        sType = "Windowsides";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    else if (pNum > 3 && pNum <= 6 && r3.Aisle != 0)
                                                    {
                                                        r3.Aisle--;
                                                        sType = "Aislesides";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    else if (pNum > 6 && pNum <= 10 && r3.Booth != 0)
                                                    {
                                                        r3.Booth--;
                                                        sType = "Booth";
                                                        Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                    }
                                                    else if (pNum > 10)
                                                    {
                                                        Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Sorry, our restaurant is full!");
                                                    }
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please re-choose a restaurant you like from the following list(1. Chinese Food 2. West Food 3. Multi-cultural Food) :");
                                            resN = int.Parse(Console.ReadLine());
                                            continue;
                                        }
                                        break;
                                    }
                                    break;
                                }
                                break;
                            }

                            while (Uid == 0)
                            {
                                Console.Write("Oops...You have never been our membership! Do you want to register and obtain more discount,now? (y/n): ");
                                string Udes = Console.ReadLine();
                                if (Udes.ToLower() == "yes" || Udes.ToLower() == "y")
                                {
                                    login(m);
                                    break;
                                }
                                else if (Udes.ToLower() == "no" || Udes.ToLower() == "n")
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Please choose a restaurant you like from the following list(1. Chinese Food 2. West Food 3. Multi-cultural Food) :");
                                        int resN = int.Parse(Console.ReadLine());
                                        //預約的餐廳與預約的座位形式
                                        string resRest, sType;
                                        while (true)
                                        {
                                            if (resN >= 1 && resN <= 3)
                                            {
                                                switch (resN)
                                                {
                                                    case 1:
                                                        resRest = "Chinese Food";
                                                        Console.WriteLine("How many people will visit?");
                                                        int pNum = int.Parse(Console.ReadLine());
                                                        //3人(含)安排窗邊位子
                                                        if (pNum > 0 && pNum <= 3 && r1.Wins != 0)
                                                        {
                                                            r1.Wins--;
                                                            sType = "Windowsides";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        //4~6人(含)安排走道位子
                                                        else if (pNum > 3 && pNum <= 6 && r1.Aisle != 0)
                                                        {
                                                            r1.Aisle--;
                                                            sType = "Aislesides";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        //6~10人(含)安排包廂
                                                        else if (pNum > 6 && pNum <= 10 && r1.Booth != 0)
                                                        {
                                                            r1.Booth--;
                                                            sType = "Booth";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        //超過10人，不可預約
                                                        else if (pNum > 10)
                                                        {
                                                            Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                        }
                                                        //所要預訂的形式已滿
                                                        else
                                                        {
                                                            Console.WriteLine("Sorry, our restaurant is full!");
                                                        }
                                                        break;

                                                    case 2:
                                                        resRest = "West Food";
                                                        Console.WriteLine("How many people will visit?");
                                                        pNum = int.Parse(Console.ReadLine());
                                                        if (pNum > 0 && pNum <= 3 && r2.Wins != 0)
                                                        {
                                                            r2.Wins--;
                                                            sType = "Windowsides";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        else if (pNum > 3 && pNum <= 6 && r2.Aisle != 0)
                                                        {
                                                            r2.Aisle--;
                                                            sType = "Aislesides";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        else if (pNum > 6 && pNum <= 10 && r2.Booth != 0)
                                                        {
                                                            r2.Booth--;
                                                            sType = "Booth";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        else if (pNum > 10)
                                                        {
                                                            Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Sorry, our restaurant is full!");
                                                        }
                                                        break;

                                                    case 3:
                                                        resRest = "Multi-cultural Food";
                                                        Console.WriteLine("How many people will visit?");
                                                        pNum = int.Parse(Console.ReadLine());
                                                        if (pNum > 0 && pNum <= 3 && r3.Wins != 0)
                                                        {
                                                            r3.Wins--;
                                                            sType = "Windowsides";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        else if (pNum > 3 && pNum <= 6 && r3.Aisle != 0)
                                                        {
                                                            r3.Aisle--;
                                                            sType = "Aislesides";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        else if (pNum > 6 && pNum <= 10 && r3.Booth != 0)
                                                        {
                                                            r3.Booth--;
                                                            sType = "Booth";
                                                            Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                        }
                                                        else if (pNum > 10)
                                                        {
                                                            Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Sorry, our restaurant is full!");
                                                        }
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please re-choose a restaurant you like from the following list(1. Chinese Food 2. West Food 3. Multi-cultural Food) :");
                                                resN = int.Parse(Console.ReadLine());
                                                continue;
                                            }
                                            break;
                                        }
                                        break;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Error!Enter y/n");
                                    Console.Write("Do you want to register and obtain more discount,now? (y/n): ");
                                    Udes = Console.ReadLine();
                                    continue;
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please re-enter your registered email!");
                            Uacc = Console.ReadLine();
                            continue;
                        }
                    }
                }
                //沒有會員
                else if (UcheMem.ToLower() == "no" || UcheMem.ToLower() == "n")
                {
                    //請求註冊
                    Console.WriteLine("Do you want to register and obtain more discount,now? (y/n): ");
                    string Udes = Console.ReadLine();
                    while (true)
                    {
                        if (Udes.ToLower() == "yes" || Udes.ToLower() == "y")
                        {
                            login(m);
                            break;
                        }
                        else if (Udes.ToLower() == "no" || Udes.ToLower() == "n")
                        {
                            while (true)
                            {
                                Console.WriteLine("Please choose a restaurant you like from the following list(1. Chinese Food 2. West Food 3. Multi-cultural Food) :");
                                int resN = int.Parse(Console.ReadLine());
                                //預約的餐廳與預約的座位形式
                                string resRest, sType;
                                while (true)
                                {
                                    if (resN >= 1 && resN <= 3)
                                    {
                                        switch (resN)
                                        {
                                            case 1:
                                                resRest = "Chinese Food";
                                                Console.WriteLine("How many people will visit?");
                                                int pNum = int.Parse(Console.ReadLine());
                                                //3人(含)安排窗邊位子
                                                if (pNum > 0 && pNum <= 3 && r1.Wins != 0)
                                                {
                                                    r1.Wins--;
                                                    sType = "Windowsides";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                //4~6人(含)安排走道位子
                                                else if (pNum > 3 && pNum <= 6 && r1.Aisle != 0)
                                                {
                                                    r1.Aisle--;
                                                    sType = "Aislesides";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                //6~10人(含)安排包廂
                                                else if (pNum > 6 && pNum <= 10 && r1.Booth != 0)
                                                {
                                                    r1.Booth--;
                                                    sType = "Booth";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                //超過10人，不可預約
                                                else if (pNum > 10)
                                                {
                                                    Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                }
                                                //所要預訂的形式已滿
                                                else
                                                {
                                                    Console.WriteLine("Sorry, our restaurant is full!");
                                                }
                                                break;

                                            case 2:
                                                resRest = "West Food";
                                                Console.WriteLine("How many people will visit?");
                                                pNum = int.Parse(Console.ReadLine());
                                                if (pNum > 0 && pNum <= 3 && r2.Wins != 0)
                                                {
                                                    r2.Wins--;
                                                    sType = "Windowsides";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                else if (pNum > 3 && pNum <= 6 && r2.Aisle != 0)
                                                {
                                                    r2.Aisle--;
                                                    sType = "Aislesides";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                else if (pNum > 6 && pNum <= 10 && r2.Booth != 0)
                                                {
                                                    r2.Booth--;
                                                    sType = "Booth";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                else if (pNum > 10)
                                                {
                                                    Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Sorry, our restaurant is full!");
                                                }
                                                break;

                                            case 3:
                                                resRest = "Multi-cultural Food";
                                                Console.WriteLine("How many people will visit?");
                                                pNum = int.Parse(Console.ReadLine());
                                                if (pNum > 0 && pNum <= 3 && r3.Wins != 0)
                                                {
                                                    r3.Wins--;
                                                    sType = "Windowsides";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                else if (pNum > 3 && pNum <= 6 && r3.Aisle != 0)
                                                {
                                                    r3.Aisle--;
                                                    sType = "Aislesides";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                else if (pNum > 6 && pNum <= 10 && r3.Booth != 0)
                                                {
                                                    r3.Booth--;
                                                    sType = "Booth";
                                                    Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                                                }
                                                else if (pNum > 10)
                                                {
                                                    Console.WriteLine("Sorry, our restaurant can contain only ten people each table at most.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Sorry, our restaurant is full!");
                                                }
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please re-choose a restaurant you like from the following list(1. Chinese Food 2. West Food 3. Multi-cultural Food) :");
                                        resN = int.Parse(Console.ReadLine());
                                        continue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //輸入格式錯誤
                            Console.Write("Error!Enter y/n");
                            Console.Write("Do you remember your password? (y/n) :");
                            Udes = Console.ReadLine();
                            continue;
                        }
                    }
                }
                else
                {
                    //輸入格式錯誤
                    Console.Write("Error!Enter y/n");
                    Console.Write("Do you remember your password? (y/n) :");
                    UcheMem = Console.ReadLine();
                    continue;
                }
                break;
            }
        }

        //遊戲函式
        // static void game()
        // {

        // }

        //主程式
        static void Main(string[] args)
        {
            //儲存所有會員資料
            Member[] m = new Member[30];
            for (int a = 0; a < 30; a++)
            {
                m[a] = new Member(" ", " ", " ", " ");
            }
            Res1 r1 = new Res1();
            Res2 r2 = new Res2();
            Res3 r3 = new Res3();
            Console.WriteLine("Welcome to Mealink!!");
            Console.WriteLine();
            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
            int choice = int.Parse(Console.ReadLine());
            while (true)
            {
                if (choice > 0 && choice <= 3)
                {
                    switch (choice)
                    {
                        case 1:
                            login(m);
                            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            reserve(m, r1, r2, r3);
                            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            //game(m);
                            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                            choice = int.Parse(Console.ReadLine());
                            break;

                    }
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Thanks for your visiting !! Have a good day!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number in [0-3]!!");
                    Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                    choice = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}

