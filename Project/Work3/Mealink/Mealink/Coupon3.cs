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
    public partial class Coupon3 : Form
    {
        public Coupon3()
        {
            InitializeComponent();
        }

        //ok 按鈕的點擊事件
        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberCheck memC = new MemberCheck();
            memC.ShowDialog();
            this.Close();
        }

        //dissmiss 按鈕的點擊事件
        private void dismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.ShowDialog();
            this.Close();
        }
    }
}
