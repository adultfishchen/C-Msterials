using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //C#連接MYSql所需套件

namespace Mealink
{
    public partial class MemberCheck : Form
    {
        //MYSql資料庫驗證資訊欄位
        private MySqlConnection conn;
        private string server;
        private string database;
        private string user;
        private string pass;

        public MemberCheck()
        {
            //MYSql資料庫驗證資訊內容
            server = "localhost";
            database = "mealink";
            user = "root";
            pass = "00000000";

            string connString;
            connString = $"SERVER = {server};DATABASE = {database};UID = {user};PASSWORD={pass};";

            //建立連線
            conn = new MySqlConnection(connString);

            InitializeComponent();
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

        //CHECK 按鈕的點擊事件
        private void check_Click(object sender, EventArgs e)
        {
            string uemail = mEmail.Text;
            //欄位格式驗證不合格
            if (validate_MemberCheck() != true)
            {
                MessageBox.Show("Please check your input in correct format!");
            }
            //欄位格式驗證合格且資料存在
            else if (validate_MemberCheck() && IsExit(uemail))
            {
                //資料更新成功
                if (IsUpdate(uemail))
                {
                    this.Hide();
                    Update up = new Update();
                    up.ShowDialog();
                    this.Close();
                }
                //資料更新失敗
                else 
                {
                    MessageBox.Show("Sorry,update failed!");

                }

            }
            //查無相應資料列
            else
            {
                MessageBox.Show("Sorry,you do not have a membership!\n Miss the reward up!!");
                this.Hide();
                Nonmember nonM = new Nonmember();
                nonM.ShowDialog();
                this.Close();
            }
        }

        //確認資料存在
        private bool IsExit(string email)
        {
            string query = $"SELECT * FROM member WHERE email ='{email}';";

            try
            {
                //連線成功
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //讀取到資料
                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        //確認資料更新成功
        private bool IsUpdate(string email)
        {
            string query = $"UPDATE member SET couponAmount = couponAmount+1 WHERE email ='{email}' ;";

            try
            {
                //連線成功
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    //讀取到資料並更新
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        //資料庫連線驗證程序
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed!");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect!");
                        break;
                }
                return false;
            }
        }

        //驗證欄位格式
        private bool validate_MemberCheck()
        {
            bool rStatus = true;
            if (mEmail.Text == "")
            {
                errorProvider1.SetError(this.mEmail, "Can't be empty!");
                rStatus = false;
            }
            else if (checkMail(mEmail.Text) != true)
            {
                errorProvider1.SetError(this.mEmail, "Please enter your school email");
                rStatus = false;
            }
            else
            {
                errorProvider1.Clear();
                rStatus = true;

            }
            return rStatus;

        }

        //Not a member 按鈕的點擊事件
        private void nonmembership_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nonmember nonM = new Nonmember();
            nonM.ShowDialog();
            this.Close();
        }
    }
}
