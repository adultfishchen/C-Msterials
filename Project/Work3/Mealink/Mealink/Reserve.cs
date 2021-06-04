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
    public partial class reserve : Form
    {
        public reserve()
        {
            InitializeComponent();
        }

        //Reserve 按鈕的點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            //預約流程
            //預約的餐廳與預約的座位形式
            string resRest = restaurant.SelectedItem.ToString();
            int resN = Convert.ToInt32(guest.Value);
            this.Hide();
            ReserveSuccess resSuccess = new ReserveSuccess();
            //更改ReserveSuccess中Lable內容
            resSuccess.ChangeLabel("You've reserved " + resRest + " restaurant for " + resN + " people!!");
            resSuccess.ShowDialog();
            this.Close();


        }

        //存取numericupdown的值
        private void guest_ValueChanged(object sender, EventArgs e)
        {
            guest.ForeColor = Color.Black;
        }
    }
}

