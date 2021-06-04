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
    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Register 按鈕的點擊事件
        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register regis = new register();
            regis.ShowDialog();
            this.Close();
        }

        //reserve 按鈕的點擊事件
        private void reserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            reserve res = new reserve();
            res.ShowDialog();
            this.Close();
        }

        //game 按鈕的點擊事件
        private void game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pregame pregame = new Pregame();
            pregame.ShowDialog();
            this.Close();
        }

        //exit 按鈕的點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            //應用程式結束
            Application.Exit();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }

}

