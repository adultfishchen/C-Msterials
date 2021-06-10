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
    public partial class register : Form
    {
        //MYSql資料庫驗證資訊欄位
        private MySqlConnection conn;
        private string server;
        private string database;
        private string user;
        private string pass;

        public register()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Register 按鈕的點擊事件
        private void registernew_Click(object sender, EventArgs e)
        {
            string uemail = email.Text;
            string upass = password.Text;
            string name = username.Text;
            string favCuisine = favcuisine.SelectedItem.ToString();
            int couponAmount = 0;

            //欄位格式驗證不合格
            if (validate_Register() != true)
            {
                MessageBox.Show("Please check your input in correct format!!");
            }

            //欄位格式驗證合格但已註冊過
            else if (validate_Register() && HasRegister(uemail))
            {
                this.Hide();
                MemberLogin memL = new MemberLogin();
                memL.ShowDialog();
                this.Close();
            }
            //欄位格式驗證合格，未註冊過且資料更新成功
            else if (validate_Register() && (HasRegister(uemail) == false) && (Register(uemail, upass, name, favCuisine, couponAmount) != false))
            {
                this.Hide();
                RegisterSuccess resS = new RegisterSuccess();
                resS.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration process failed!");
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

        //註冊並將資料寫入資料庫
        private bool Register(string email, string password, string username, string favCuisine, int couponAmount)
        {
            string query = $"INSERT INTO member (email, password, name, favCuisine, couponAmount) VALUES('{email}','{password}','{username}','{favCuisine}','{couponAmount}');"; 
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
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

        //驗證欄位格式
        private bool validate_Register()
        {
            bool rStatus = true;
            if (email.Text == "" && username.Text == "" && password.Text == "")
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && username.Text == "" && password.Text == "")
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (email.Text == "" && username.Text == "" && checkPass(password.Text) != true)
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && username.Text == "" && checkPass(password.Text) != true)
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && username.Text == "")
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.Clear();
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && password.Text == "")
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.Clear();
                errorProvider3.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (username.Text == "" && checkPass(password.Text) != true)
            {
                errorProvider1.Clear();
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (email.Text == "" && checkPass(password.Text) != true)
            {
                errorProvider1.SetError(this.email, "Can't be empty!!");
                errorProvider2.Clear();
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true && checkPass(password.Text) != true)
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.Clear();
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (email.Text == "" && username.Text == "")
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.Clear();
                rStatus = false;

            }
            else if (username.Text == "" && password.Text == "")
            {
                errorProvider1.Clear();
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (email.Text == "" && password.Text == "")
            {
                errorProvider1.SetError(this.email, "Can't be empty!");
                errorProvider2.Clear();
                errorProvider3.SetError(this.password, "Can't be empty!!");
                rStatus = false;
            }
            else if (checkMail(email.Text) != true)
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
                errorProvider2.Clear();
                errorProvider3.Clear();
                rStatus = false;
            }
            else if (checkPass(password.Text) != true)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
                rStatus = false;
            }
            else if (username.Text == "")
            {
                errorProvider1.Clear();
                errorProvider2.SetError(this.username, "Can't be empty!!");
                errorProvider3.Clear();
                rStatus = false;
            }
            else if (email.Text == "")
            {
                errorProvider1.SetError(this.username, "Can't be empty!!");
                errorProvider2.Clear();
                errorProvider3.Clear();
                rStatus = false;
            }
            else if (password.Text == "")
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.SetError(this.username, "Can't be empty!!");
                rStatus = false;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                rStatus = true;

            }
            return rStatus;
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        //login 按鈕的點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
            this.Close();
        }

        private void email_Leave(object sender, EventArgs e)
        {
            string mail = email.Text;
            if(checkMail(mail) == false)
            {
                errorProvider1.SetError(this.email, "Please enter your school email");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            string pass = password.Text;
            if(checkPass(pass) == false)
            {
                errorProvider3.SetError(this.password, "Must contain capital letter, lowercase letter, number and sign. At least 10 characters.");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
    }
}
