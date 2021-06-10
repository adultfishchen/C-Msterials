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
    public partial class ResetPass : Form
    {
        //MYSql資料庫驗證資訊欄位
        private MySqlConnection conn;
        //database server IP
        private string server;
        //database name
        private string database;
        //MySQL username
        private string user;
        //MySQL password
        private string pass;

        public ResetPass()
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
            //將密碼欄位內容以'*'替換
            password.PasswordChar = '*';
        }

        //RESET 按鈕的點擊事件
        private void reset_Click(object sender, EventArgs e)
        {
            string uemail = email.Text;
            string npass = password.Text;

            //欄位格式驗證不合格
            if (validate_ResetPass() != true)
            {
                MessageBox.Show("Please check your input in correct format!!");
            }
            //欄位格式驗證合格且資料更新成功
            else if (validate_ResetPass() && IsUpdate(uemail, npass))
            {
                this.Hide();
                ResetSuccess resS = new ResetSuccess();
                resS.ShowDialog();
                this.Close();
            }
            //查無相符會員資料列，更新失敗
            else
            {
                this.Hide();
                Nonmember nonM = new Nonmember();
                nonM.ShowDialog();
                this.Close();
            }

        }

        //查詢資料庫更新狀態
        private bool IsUpdate(string email, string password)
        {
            string query = $"UPDATE member SET password = '{password}' WHERE email ='{email}' ;";

            try
            {
                //連線成功
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //讀取相應資料並更新
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

        //驗證欄位格式
        private bool validate_ResetPass()
        {
            bool rStatus = true;
            if (email.Text == "" && password.Text == "")
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (email.Text == "" && checkPass(password.Text) != true)
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (email.Text == "")
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.Clear();
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && password.Text == "")
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && checkPass(password.Text) != true)
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true)
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.Clear();
                rStatus = false;
            }
            else if (password.Text == "")
            {
                errorProvider1.Clear();
                errorProvider2.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (checkPass(password.Text) != true)
            {
                errorProvider1.Clear();
                errorProvider2.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                rStatus = true;

            }
            return rStatus;
        }
    }
}
