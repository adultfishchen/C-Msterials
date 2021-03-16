/*
*function1 : if .. else if ... applied to character test
*function2 : if .. else if ... applied to grade convertion 
*function3 : if .. else if ... applied to Body Mass Judge
*function4 : while loop applied to calculate the amount of rice
*function5 : simple guess game
*function6 : Find the designated 費氏值
*function7 : 判斷是否為質數
*/

using System;

namespace Problem1
{
    class Program
    {
        static void function1()
        {
            Console.WriteLine("公司聚餐，飯桌上擺著一道你最愛吃的菜，離你挺遠，");
            Console.WriteLine("就算你伸長了胳膊也夾不到，這時你會怎麼辦呢？");
            Console.WriteLine("這個問題可以測試你面對喜歡的人反應如何哦！");
            Console.WriteLine("1.放棄！自己的形象重要");
            Console.WriteLine("2.請接近那菜的人幫你夾");
            Console.WriteLine("3.為了肚子，站起來");
            Console.WriteLine("4.跟靠近那菜的人換座位");
            Console.WriteLine("請輸入你的決定：");
            int answer = int.Parse(Console.ReadLine());

            Console.WriteLine("答案分析：");

            if (answer == 1)
            {
                Console.WriteLine("選擇1：「放棄！自己的形象重要」。");
                Console.WriteLine("生活中你比較低調，少言寡語的，");
                Console.WriteLine("面對喜歡的人也沒有勇氣說出來。");
                Console.WriteLine("過於羞怯與自卑總讓你與愛失之交臂！");
                Console.WriteLine("TAKE IT EASY!其實你有很多的優點，");
                Console.WriteLine("或許對方早就在悄悄地關注你了，");
                Console.WriteLine("為什麼不說出你的真實感覺呢？");
            }
            else if (answer == 2)
            {
                Console.WriteLine("選擇2：「請接近那菜的人幫你夾」。");
                Console.WriteLine("就開始行動了。你凡事都小心謹慎，不慌不忙，");
                Console.WriteLine("再經過深謀遠慮後，等到一切盡在你的掌控中。"); ;
                Console.WriteLine("你的城府有夠深，哈哈！想想如此這般的謹慎細緻，");
                Console.WriteLine("你的愛情征途豈有不一帆風順，馬到成功之理呢！");
            }
            else if (answer == 3)
            {
                Console.WriteLine("選擇3：「為了肚子，站起來」。");
                Console.WriteLine("你這個人“侵略性”較強，只要是自己喜歡的人，");
                Console.WriteLine("定會不惜一切代價爭取到手。");
                Console.WriteLine("你認為愛就該讓對方知道，且拿出實際行動，");
                Console.WriteLine("不過你的表達方式容易被誤解為太過霸氣，");
                Console.WriteLine("所以有時候結果會令你相當的失望！");
            }
            else if (answer == 4)
            {
                Console.WriteLine("選擇4：「跟靠近那菜的人換座位」。");
                Console.WriteLine("你是個很有主見的人，善於運用計謀，");
                Console.WriteLine("可以輕易俘獲目標，而且做事乾淨利落不拖泥帶水，");
                Console.WriteLine("讓身邊的人佩服不已。不過有時候也會過於自信，");
                Console.WriteLine("要知道強中自有強中 手，");
                Console.WriteLine("如果你遇到一個比你還老練的人，就糗了哦！");
            }
        }
        
        static void function2()
        {
            Console.WriteLine("Pleasr enter your original score.");
                    int score = int.Parse(Console.ReadLine());
                    if (score > 100 || score < 70)
                        Console.WriteLine("Out of range!!");
                    else if (score >= 90)
                        Console.WriteLine("A+");
                    else if (score >= 85)
                        Console.WriteLine("A");
                    else if (score >= 80)
                        Console.WriteLine("A-");
                    else if (score >= 77)
                        Console.WriteLine("B+");
                    else if (score >= 73)
                        Console.WriteLine("B");
                    else if (score >= 70)
                        Console.WriteLine("B-");
        }

        static void function3()
        {
            Console.WriteLine("請輸入你的身高(公尺)");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("請輸入你的體重(公斤)");
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);

            string comment;
            if (bmi >= 35)
                comment = "重度肥胖";
            else if (bmi >= 30)
                comment = "中度肥胖";
            else if (bmi >= 27)
                comment = "輕度肥胖";
            else if (bmi >= 24)
                comment = "過重";
            else if (bmi >= 18.5)
                comment = "正常範圍";
            else
                comment = "體重過輕";

            Console.WriteLine("你的BMI指數為:" + bmi);
            Console.WriteLine("診斷結果: " + comment);
        }

        static void function4()
        {
            int total = 0;//米粒總數
            int num = 0;//第幾格
            while (total < 1000000)
            {
                num++;
                total += (int)Math.Pow(2, num - 1); //第i格要放 2的i-1次方粒米
            }

            Console.WriteLine("放到第 {0} 格時，會超過100萬粒", num);
        }

        static void function5()
        {
            int try_times = 0;
            int answer = 33; // 隨意設定
            // 也可以用亂數產生器產生謎底如下
            // Random rand = new Random();
            // int answer = rand.Next()%100;

            int quess;

            Console.WriteLine("請在0~99中猜一個數字");
            do
            {
                quess = int.Parse(Console.ReadLine());
                try_times++;
                if (quess == answer)
                {
                    Console.WriteLine("Bingo! 你總共猜了{0}次", try_times);
                }
                else if (quess > answer && quess <= 99) //考慮有效範圍
                {
                    Console.WriteLine("太大了!");
                }
                else if (quess < answer && quess >= 0) //考慮有效範圍
                {
                    Console.WriteLine("太小了!");
                }
                else
                {
                    Console.WriteLine("你猜的數字超出範圍了!");
                }

            }
            while (answer != quess);  //如果還沒猜中，則迴圈要一直執行
        }

        static void function6()
        {
            int input = 0;
            int f0 = 0, f1 = 1, fi = 0;
            Console.WriteLine("請輸入要費氏數列中的第幾個數");
            input = int.Parse(Console.ReadLine());

            if (input <= 1)
            {
                for (int i = 0; i < input; i++)
                    fi = f1 + f0;
            }
            else
            {
                for (int i = 1; i < input; i++)
                {
                    fi = f1 + f0;
                    f0 = f1;
                    f1 = fi;
                }
            }
            Console.WriteLine("第" + input + "個費氏數是" + fi);
        }

        static void function7()
        {
            Console.Write("輸入較小正整數 low: ");
            int low = int.Parse(Console.ReadLine());
            Console.Write("輸入較大正整數 high: ");
            int high = int.Parse(Console.ReadLine());
            int i = 1;
            int j = 1;
            int k = 0;

            for (i = low; i <= high; ++i)
            {
                bool isPrime = true;
                double n = Math.Round(Math.Sqrt(i), 0);
                k = (int)n;
                for (j = 2; j <= k; ++j)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("  " + i);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            function1();
            Console.WriteLine();
            function2();
            Console.WriteLine();
            function3();
            Console.WriteLine();
            function4();
            Console.WriteLine();
            function5();
            Console.WriteLine();
            function6();
            Console.WriteLine();
            function7();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();



        }
    }
}
