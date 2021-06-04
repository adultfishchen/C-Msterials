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
    public partial class login : Form
    {
        //MYSql資料庫驗證資訊欄位
        private MySqlConnection conn;
        private string server;
        private string database;
        private string user;
        private string pass;

        public login()
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

        //Login 按鈕的點擊事件
        private void log_Click(object sender, EventArgs e)
        {
            string uemail = email.Text;
            string upass = password.Text;

            //欄位格式驗證不合格
            if (validate_Login() != true)
            {
                MessageBox.Show("Please check your input in correct format!!");
            }
            //欄位格式驗證合格但為註冊過
            else if (validate_Login() && (HasRegister(uemail) == false))
            {
                this.Hide();
                Nonmember nonM = new Nonmember();
                nonM.ShowDialog();
                this.Close();
            }
            //欄位格式驗證合格且登入成功
            else if (validate_Login() && IsLogin(uemail, upass))
            {
                this.Hide();
                LoginSuccess logs = new LoginSuccess();
                logs.ShowDialog();
                this.Close();
            }
            //登入失敗
            else
            {
                   MessageBox.Show("Incorrect Password!");
                    return;    
            }
        }

        //判斷是否重複註冊
        private bool HasRegister(string email)
        {
            string query = $"SELECT * FROM member WHERE email ='{email}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

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

        //登入狀態查詢
        private bool IsLogin(string email, string password)
        {
            string query = $"SELECT * FROM member WHERE email ='{email}' AND password = '{password}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

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

        //forget password label 點擊事件
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPass rep = new ResetPass();
            rep.ShowDialog();
            this.Close();
        }

        //驗證欄位格式
        private bool validate_Login()
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
