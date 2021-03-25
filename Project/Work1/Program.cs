using System;
using System.Text.RegularExpressions; //正規表示式所需Collection

namespace Work1
{
    //全域變數類別，方便函式修改數值。函式執行時不需再傳值。
    public static class Global
    {
        public static string email = " ";
        public static string pass = " ";
        public static string name = " ";
        public static string favCuisine = " ";
        //3間餐廳的3種座位型態數量限制
        public static int wins1 = 2;
        public static int aisle1 = 2;
        public static int booth1 = 2;
        public static int wins2 = 2;
        public static int aisle2 = 2;
        public static int booth2 = 2;
        public static int wins3 = 2;
        public static int aisle3 = 2;
        public static int booth3 = 2;

    }
    class Program
    {
        //註冊/登入函式
        static void login()
        {
            // string email, pass, name, favCuisine = " ";
            bool vMail = false, vPass = false;
            Console.WriteLine("Please enter your school email :　");
            Global.email = Console.ReadLine();
            string[] cheMail = Global.email.Split('@');

            //驗證信箱domain
            while (true)
            {
                vMail = checkMail(Global.email);

                switch (vMail)
                {
                    case true:
                        Console.WriteLine("Please set your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. : ");
                        Global.pass = Console.ReadLine();
                        vPass = checkPass(Global.pass);
                        break;
                    case false:
                        Console.WriteLine("Please re-enter your school email :　");
                        Global.email = Console.ReadLine();
                        cheMail = Global.email.Split('@');
                        vMail = checkMail(Global.email);
                        continue;
                }
                Global.name = cheMail[0];
                break;
            }

            //驗證密碼設置
            while (vMail == true)
            {
                switch (vPass)
                {

                    case true:
                        Console.WriteLine("Register succeed!");
                        break;
                    case false:
                        Console.WriteLine("Please reset your password (Must contain capital letter, lowercase letter, number and sign. At least 10 characters. : ");
                        Global.pass = Console.ReadLine();
                        vPass = checkPass(Global.pass);
                        continue;
                }
                break;
            }


            Console.WriteLine("Welcome {0} ! Hope you have a good experience throught our website.", Global.name);
            Console.WriteLine("Do you want to change your name? (y/n) : ");
            string cN = Console.ReadLine();
            while (true)
            {
                if (cN.ToLower() == "yes" || cN.ToLower() == "y")
                {
                    Console.WriteLine("Please enter your name : ");
                    Global.name = Console.ReadLine();
                    Console.WriteLine("Which is your favorite cuisine, {0}? (A.Chi、B.West、C.Multi-cultural) : ", Global.name);
                    string fChoice = Console.ReadLine();
                    while (Global.favCuisine == " ")
                    {
                        switch (fChoice.ToUpper())
                        {
                            case "A":
                                Global.favCuisine = "Chinese";
                                break;
                            case "B":
                                Global.favCuisine = "West";
                                break;

                            case "C":
                                Global.favCuisine = "Multi-cultural";
                                break;
                            default:
                                Console.WriteLine("Error!Enter character in [A-C]~");
                                Console.WriteLine("Please choose your favorite cuisine again, {0} ! (A.Chi、B.West、C.Multi-cultural) : ", Global.name);
                                fChoice = Console.ReadLine();
                                continue;
                        }
                        Console.WriteLine("Great, {0}!! Your favorite cuisine is {1}", Global.name, Global.favCuisine);
                        break;
                    }
                }
                else if (cN.ToLower() == "no" || cN.ToLower() == "n")
                {
                    Global.name = cheMail[0];
                    Console.WriteLine("Which is your favorite cuisine, {0}? (A.Chi B.West C.Multi-cultural) : ", Global.name);
                    string fChoice = Console.ReadLine();
                    while (Global.favCuisine == " ")
                    {
                        switch (fChoice.ToUpper())
                        {
                            case "A":
                                Global.favCuisine = "Chinese";
                                break;
                            case "B":
                                Global.favCuisine = "West";
                                break;

                            case "C":
                                Global.favCuisine = "Multi-cultural";
                                break;
                            default:
                                Console.WriteLine("Error!Enter character in [A-C]~");
                                Console.WriteLine("Please choose your favorite cuisine again, {0} ! (A.Chi、B.West、C.Multi-cultural) : ", Global.name);
                                fChoice = Console.ReadLine();
                                continue;
                        }
                        Console.WriteLine("Great, {0}!! Your favorite cuisine is {1}", Global.name, Global.favCuisine);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Error!Enter y/n");
                    Console.WriteLine("Do you want to change your name? (y/n) :");
                    cN = Console.ReadLine();
                    continue;
                }
                break;
            }

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
        static void reserve()
        {
            switch (Global.favCuisine)
            {
                case "Chinese":
                    Console.WriteLine("Hello, {0}! Your favorite cuisine is {1}, we recommend restaurant 1 for you!!", Global.name, Global.favCuisine);
                    break;
                case "West":
                    Console.WriteLine("Hello, {0}! Your favorite cuisine is {1}, we recommend restaurant 2 for you!!", Global.name, Global.favCuisine);
                    break;
                case "Multi-cultural":
                    Console.WriteLine("Hello, {0}! Your favorite cuisine is {1}, we recommend restaurant 3 for you!!", Global.name, Global.favCuisine);
                    break;

            }

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
                            if (pNum > 0 && pNum <= 3 && Global.wins1 != 0)
                            {
                                Global.wins1--;
                                sType = "Windowsides";
                                Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                            }
                            //4~6人(含)安排走道位子
                            else if (pNum > 3 && pNum <= 6 && Global.aisle1 != 0)
                            {
                                Global.aisle1--;
                                sType = "Aislesides";
                                Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                            }
                            //6~10人(含)安排包廂
                            else if (pNum > 6 && pNum <= 10 && Global.booth1 != 0)
                            {
                                Global.booth1--;
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
                            if (pNum > 0 && pNum <= 3 && Global.wins2 != 0)
                            {
                                Global.wins2--;
                                sType = "Windowsides";
                                Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                            }
                            else if (pNum > 3 && pNum <= 6 && Global.aisle2 != 0)
                            {
                                Global.aisle2--;
                                sType = "Aislesides";
                                Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                            }
                            else if (pNum > 6 && pNum <= 10 && Global.booth2 != 0)
                            {
                                Global.booth2--;
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
                            if (pNum > 0 && pNum <= 3 && Global.wins3 != 0)
                            {
                                Global.wins3--;
                                sType = "Windowsides";
                                Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                            }
                            else if (pNum > 3 && pNum <= 6 && Global.aisle3 != 0)
                            {
                                Global.aisle3--;
                                sType = "Aislesides";
                                Console.WriteLine("Reservation succeed! You reserve a {0} in {1} .", sType, resRest);
                            }
                            else if (pNum > 6 && pNum <= 10 && Global.booth3 != 0)
                            {
                                Global.booth3--;
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
        }


        //遊戲函式
        // static void game()
        // {

        // }

        //主程式
        static void Main(string[] args)
        {
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
                            login();
                            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            reserve();
                            Console.WriteLine("What you want to do ? (1. Register/Login 2. Reservation 3. Game 0. Logout) : ");
                            choice = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            //game();
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

