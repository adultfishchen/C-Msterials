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
        private int couponAmount = 0;

        public Member(string email, string pass, string name, string favCuisine,int couponAmount)
        {
            this.email = email;
            this.pass = pass;
            this.name = name;
            this.favCuisine = favCuisine;
            this.couponAmount = couponAmount;
        }

        //email設置與取得
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        //password設置與取得
        public string Pass
        {
            set { pass = value; }
            get { return pass; }
        }

        //name設置與取得
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //favcusine設置與取得
        public string FavCuisine
        {
            set { favCuisine = value; }
            get { return favCuisine; }
        }

        //couponAmount設置與取得
        public int CouponAmount
        {
            set { couponAmount = value; }
            get { return couponAmount; }
        }
    }

    //Res1、Res2、Res3類別，確保各餐廳的座位數量的準確性
    class Res1
    {
        private int wins;
        private int aisle;
        private int booth;

        //3種座位形式各2桌
        public Res1()
        {
            this.wins = 2;
            this.aisle = 2;
            this.booth = 2;
        }

        //Win形式數量更動與取得
        public int Wins
        {
            set { wins = value; }
            get { return wins; }
        }

        //Aisle形式數量更動與取得
        public int Aisle
        {
            set { aisle = value; }
            get { return aisle; }
        }

        //booth形式數量更動與取得
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

        //3種座位形式各2桌
        public Res2()
        {
            this.wins = 2;
            this.aisle = 2;
            this.booth = 2;
        }

        //Win形式數量更動與取得
        public int Wins
        {
            set { wins = value; }
            get { return wins; }
        }

        //Aisle形式數量更動與取得
        public int Aisle
        {
            set { aisle = value; }
            get { return aisle; }
        }

        //Booth形式數量更動與取得
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

        //3種座位形式各2桌
        public Res3()
        {
            this.wins = 2;
            this.aisle = 2;
            this.booth = 2;
        }

        //Win形式數量更動與取得
        public int Wins
        {
            set { wins = value; }
            get { return wins; }
        }

        //Aisle形式數量更動與取得
        public int Aisle
        {
            set { aisle = value; }
            get { return aisle; }
        }

        //Booth形式數量更動與取得
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
            int Uid = 0;
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
                    Uid = checkRegis(m, email, Uid);
                    //不曾註冊
                    while (Uid == -1)
                    {
                        //尋找無資料位置進行資料的儲存
                        for (int i = 0; i < 30; i++)
                        {
                            if (m[i].Email == " ")
                            {
                                Console.WriteLine("Please set your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. : ");
                                pass = Console.ReadLine();
                                vPass = checkPass(pass);
                                m[i].Email = email;
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
                                            m[i] = new Member(email, pass, name, favCuisine,m[i].CouponAmount);
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
                                            m[i] = new Member(email, pass, name, favCuisine,m[i].CouponAmount);
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

                    while (Uid != -1)
                    {
                        //已註冊過
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
                                    else if (m[Uid].Pass != Upass && k > 1)
                                    {
                                        Console.WriteLine("Wrong password, please try again!", m[Uid].Name);
                                        k--;
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You've failed at logining for three times! For security, you need to reset password!");
                                        Console.WriteLine("Please reset your new password: ");
                                        string Unpass = Console.ReadLine();
                                        if (checkPass(Unpass))
                                        {
                                            Console.WriteLine("Reset password successfully!");
                                            m[Uid].Pass = Unpass;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please reset your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. :");
                                            Unpass = Console.ReadLine();
                                            continue;
                                        }
                                    }
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
                            //輸入格是錯誤，請求重新輸入
                            else
                            {
                                Console.WriteLine("Error!Enter y/n");
                                Console.Write("Do you remember your password? (y/n) :");
                                Uselec = Console.ReadLine();
                                continue;
                            }
                        }
                        break;
                    }
                }
                //輸入格是錯誤，請求重新輸入
                else
                {
                    Console.Write("Please re-enter your school email :　");
                    email = Console.ReadLine();
                    cheMail = email.Split('@');
                    vMail = checkMail(email);
                    continue;
                }
                break;
            }
        }

        //判斷是否重複註冊函式
        static int checkRegis(Member[] m, string mail, int Uid)
        {
            for (int i = 0; i < 30; i++)
            {
                //已註冊過，回傳資料index
                if (m[i].Email == mail)
                {
                    Uid = i;
                    break;
                }
                else
                {
                    Uid = -1;
                }
            }
            return Uid;
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
            int Uid = 0;
            //詢問是否擁有會員身分
            Console.Write("Do you have a membership? (y/n) : ");
            string UcheMem = Console.ReadLine();

            while (true)
            {
                //回覆有會員資格
                if (UcheMem.ToLower() == "yes" || UcheMem.ToLower() == "y")
                {
                    //請求提供會員註冊信箱
                    Console.WriteLine("Please tell us your registered email?");
                    string Uacc = Console.ReadLine();
                    while (true)
                    {
                        if (checkMail(Uacc) == true)
                        {
                            Uid = checkRegis(m, Uacc, Uid);
                            while (Uid != -1)
                            {
                                //已註冊過，進行密碼驗證或重設
                                Console.WriteLine("You've been our member,{0}!", m[Uid].Name);
                                while (true)
                                {
                                    int k = 3;
                                    //考量資安問題，3次密碼錯誤，強制重設
                                    while (k > 0)
                                    {
                                        //請求確認密碼
                                        Console.Write("Please check your password: ");
                                        string Ucheck = Console.ReadLine();
                                        if (m[Uid].Pass == Ucheck)
                                        {
                                            Console.WriteLine("Login successfully, {0}!", m[Uid].Name);
                                            break;
                                        }
                                        else if (m[Uid].Pass != Ucheck && k > 1)
                                        {
                                            Console.WriteLine("Wrong password, please try again!", m[Uid].Name);
                                            k--;
                                            continue;
                                        }
                                        else
                                        {
                                            //密碼重設
                                            Console.WriteLine("You've failed at logining for three times! For security, you need to reset password!");
                                            Console.WriteLine("Please reset your new password: ");
                                            string Unpass = Console.ReadLine();
                                            if (checkPass(Unpass))
                                            {
                                                Console.WriteLine("Reset password successfully!");
                                                m[Uid].Pass = Unpass;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please reset your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. :");
                                                Unpass = Console.ReadLine();
                                                continue;
                                            }
                                        }
                                    }

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
                                break;
                            }

                            //不曾註冊
                            while (Uid == -1)
                            {
                                //詢問是否註冊，以獲取更多優惠
                                Console.Write("Oops...You have never been our membership! Do you want to register and obtain more discount,now? (y/n): ");
                                string Udes = Console.ReadLine();
                                //是，進行註冊程序
                                if (Udes.ToLower() == "yes" || Udes.ToLower() == "y")
                                {
                                    login(m);
                                    break;
                                }
                                //否，進行訂位程序
                                else if (Udes.ToLower() == "no" || Udes.ToLower() == "n")
                                {
                                    while (true)
                                    {
                                        //預約流程
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
                                //輸入格是錯誤，請求重新輸入
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
                        //輸入格是錯誤，請求重新輸入
                        else
                        {
                            Console.WriteLine("Please re-enter your registered email!");
                            Uacc = Console.ReadLine();
                            continue;
                        }
                    }
                }
                //回覆沒有會員資格
                else if (UcheMem.ToLower() == "no" || UcheMem.ToLower() == "n")
                {
                    //詢問是否註冊以會取更多優惠
                    Console.WriteLine("Do you want to register and obtain more discount,now? (y/n): ");
                    string Udes = Console.ReadLine();
                    while (true)
                    {
                        //是，進入註冊程序
                        if (Udes.ToLower() == "yes" || Udes.ToLower() == "y")
                        {
                            login(m);
                            break;
                        }
                        //否，進入訂位程序
                        else if (Udes.ToLower() == "no" || Udes.ToLower() == "n")
                        {
                            while (true)
                            {
                                //預約流程
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
                        }
                        //輸入格式錯誤，請求重新輸入
                        else
                        {
                            Console.Write("Error!Enter y/n");
                            Console.Write("Do you remember your password? (y/n) :");
                            Udes = Console.ReadLine();
                            continue;
                        }
                        break;
                    }
                    break;
                }
                //輸入格式錯誤，請求重新輸入
                else
                {
                    Console.Write("Error!Enter y/n");
                    Console.Write("Do you have a membership? (y/n) : ");
                    UcheMem = Console.ReadLine();
                    continue;
                }
                break;
            }
        }

        //簡易抽獎小遊戲函式
        static void game(Member[] m)
        {
            while (true)
            {
                int Uid = 0;
                Random r = new Random();
                //詢問是否有會員身分
                Console.WriteLine("Have you been a member already?(y/n): ");
                string Umem = Console.ReadLine();

                //回覆有
                if (Umem.ToLower() == "yes" || Umem.ToLower() == "y")
                {
                    //請求提供註冊信箱
                    Console.Write("Please enter your registered email : ");
                    string Umail = Console.ReadLine();
                    while (true)
                    {
                        if (checkMail(Umail) == true)
                        {
                            Uid = checkRegis(m, Umail, Uid);
                            //查無會員資料，詢問是否註冊
                            while (Uid == -1)
                            {
                                Console.WriteLine("Sorry, you've never gottten our membership!");
                                Console.WriteLine("Do you want to register now, in order to obtain more discount?(y/n): ");
                                string Uche = Console.ReadLine();
                                while (true)
                                {
                                    //回覆是，進行註冊程序
                                    if (Uche.ToLower() == "yes" || Uche.ToLower() == "y")
                                    {
                                        login(m);
                                        break;
                                    }
                                    //回覆否，跳出程序
                                    else if (Uche.ToLower() == "no" || Uche.ToLower() == "n")
                                    {
                                        Console.WriteLine("Sorry, you can't start this function without having a membership!!");
                                        break;
                                    }
                                    //輸入格是錯誤，請求重新輸入
                                    else
                                    {
                                        Console.WriteLine("Error!Enter y/n");
                                        Console.Write("Do you want to register now, in order to obtain more discount?(y/n):");
                                        Uche = Console.ReadLine();
                                        continue;
                                    }
                                }
                                break;
                            }
                            //確認有會員資格，開始抽獎
                            while (Uid != -1)
                            {
                                Console.WriteLine("Ready to play? Press any key to start: ");
                                Console.ReadKey();
                                //隨機產生最大值(獎)為5到最小值(獎)為0之間的數字，並給予相應優惠獎項
                                int numGet = r.Next() % (5 - 0 + 1);
                                
                                switch (numGet)
                                {
                                    //未中獎
                                    case 0:
                                        Console.WriteLine("Miss it ... ");
                                        break;
                                    //一獎
                                    case 1:
                                        Console.WriteLine("Congratulations! Win $1 discount coupon,which is applicab;e to all restaurants!");
                                        Console.WriteLine("Save this Screenshot, and show waiters/waitresses to exchange this discount!");
                                        m[Uid].CouponAmount++;
                                        break;
                                    //二獎
                                    case 2:
                                        Console.WriteLine("Congratulations! Win $10 discount coupon,which is applicab;e to all restaurants!");
                                        Console.WriteLine("Save this Screenshot, and show waiters/waitresses to exchange this discount!");
                                        m[Uid].CouponAmount++;
                                        break;
                                    //三獎
                                    case 3:
                                        Console.WriteLine("Congratulations! Win $50 discount coupon,which is applicab;e to all restaurants!");
                                        Console.WriteLine("Save this Screenshot, and show waiters/waitresses to exchange this discount!");
                                        m[Uid].CouponAmount++;
                                        break;
                                    //四獎
                                    case 4:
                                        Console.WriteLine("Congratulations! Win a discount coupon with claiming $300 rebate for every $1000 spent!");
                                        Console.WriteLine("Save this Screenshot, and show waiters/waitresses to exchange this discount!");
                                        m[Uid].CouponAmount++;
                                        break;
                                    //五獎
                                    case 5:
                                        Console.WriteLine("Congratulations! Win a discount coupon with claiming $300 rebate for every $1000 spent!");
                                        Console.WriteLine("Save this Screenshot, and show waiters/waitresses to exchange this discount!");
                                        m[Uid].CouponAmount++;
                                        break;
                                }
                                break;
                            }
                            break;
                        }
                        //輸入格是錯誤，請求重新輸入
                        else
                        {
                            Console.WriteLine("Wrong email address format, please re-enter your registered email: ");
                            Umail = Console.ReadLine();
                            continue;
                        }
                    }
                    break;
                }
                //回覆無會員，詢問是否註冊
                else if (Umem.ToLower() == "no" || Umem.ToLower() == "n")
                {
                    Console.WriteLine("Sorry, you can't start this function without having a membership!!");
                    Console.WriteLine("Do you want to register now, in order to obtain more discount?(y/n): ");
                    string Uche = Console.ReadLine();
                    while (true)
                    {
                        //回覆是，進行註冊程序
                        if (Uche.ToLower() == "yes" || Uche.ToLower() == "y")
                        {
                            login(m);
                            break;
                        }
                        //回覆否，跳出程序
                        else if (Uche.ToLower() == "no" || Uche.ToLower() == "n")
                        {
                            Console.WriteLine("Sorry, you can't start this function without having a membership!!");
                            break;
                        }
                        //輸入格是錯誤，請求重新輸入
                        else
                        {
                            Console.WriteLine("Error!Enter y/n");
                            Console.Write("Do you want to register now, in order to obtain more discount?(y/n):");
                            Uche = Console.ReadLine();
                            continue;
                        }
                    }
                    break;
                }
                //輸入格是錯誤，請求重新輸入
                else
                {
                    Console.WriteLine("Error!Enter y/n");
                    Console.Write("Have you been a member already?(y/n):");
                    Umem = Console.ReadLine();
                    continue;
                }
            }
        }

        //主程式
        static void Main(string[] args)
        {
            //生成會員陣列以儲存會員資料
            Member[] m = new Member[30];
            for (int a = 0; a < 30; a++)
            {
                m[a] = new Member(" ", " ", " ", " ",0);
            }
            //生成餐廳instance
            Res1 r1 = new Res1();
            Res2 r2 = new Res2();
            Res3 r3 = new Res3();
            Console.WriteLine("Welcome to Mealink!!");
            Console.WriteLine();
            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
            int choice = int.Parse(Console.ReadLine());
            while (true)
            {
                //根據輸入內容，執行相對應程序
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
                            game(m);
                            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                            choice = int.Parse(Console.ReadLine());
                            break;

                    }
                }
                //輸入為0，結束主程式
                else if (choice == 0)
                {
                    Console.WriteLine("Thanks for your visiting !! Have a good day!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                }
                //輸入格式錯誤，請求重新輸入
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

