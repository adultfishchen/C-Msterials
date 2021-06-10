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
    public partial class Nonmember : Form
    {
        public Nonmember()
        {
            InitializeComponent();
        }

        //Register now 按鈕的點擊事件
        private void regis_Click(object sender, EventArgs e)
        {
            this.Hide();
            register res = new register();
            res.ShowDialog();
            this.Close();
        }

        //back to Home 按鈕的點擊事件
        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.ShowDialog();
            this.Close();
        }
    }
}
