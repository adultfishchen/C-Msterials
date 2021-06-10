using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mealink
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        //立即抽獎點擊事件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //亂數產生器
            Random r = new Random();
            //隨機產生最大值(獎)為5到最小值(獎)為0之間的數字，並給予相應優惠獎項
            int numGet = r.Next() % (5 - 0 + 1);
            switch (numGet)
            {
                //未中獎
                case 0:
                    this.Hide();
                    Coupon0 co = new Coupon0();
                    co.ShowDialog();
                    this.Close();
                    break;
                //一獎
                case 1:
                    this.Hide();
                    Coupon1 c1 = new Coupon1();
                    c1.ShowDialog();
                    this.Close();
                    break;
                //二獎
                case 2:
                    this.Hide();
                    Coupon2 c2 = new Coupon2();
                    c2.ShowDialog();
                    this.Close();
                    break;
                //三獎
                case 3:
                    this.Hide();
                    Coupon3 c3 = new Coupon3();
                    c3.ShowDialog();
                    this.Close();
                    break;
                //四獎
                case 4:
                    this.Hide();
                    Coupon4 c4 = new Coupon4();
                    c4.ShowDialog();
                    this.Close();
                    break;
                //五獎
                case 5:
                    this.Hide();
                    Coupon5 c5 = new Coupon5();
                    c5.ShowDialog();
                    this.Close();
                    break;
            }


        }
    }
}
