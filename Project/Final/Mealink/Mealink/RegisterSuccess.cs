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
    public partial class RegisterSuccess : Form
    {
        public RegisterSuccess()
        {
            InitializeComponent();
        }

        private void welcomemes_Click(object sender, EventArgs e)
        {

        }

        //ok 按鈕的點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.ShowDialog();
            this.Close();

        }
    }
}
