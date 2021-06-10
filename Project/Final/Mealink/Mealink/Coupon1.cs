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
    public partial class Coupon1 : Form
    {
        public Coupon1()
        {
            InitializeComponent();
        }

        //CHECK 按鈕的點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberCheck memC = new MemberCheck();
            memC.ShowDialog();
            this.Close();
        }

        // Not a Member按鈕的點擊事件
        private void dismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.ShowDialog();
            this.Close();
        }
    }
}
