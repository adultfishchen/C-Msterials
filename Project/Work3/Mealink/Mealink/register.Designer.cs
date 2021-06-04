
namespace Mealink
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registernew = new System.Windows.Forms.Button();
            this.favcuisine = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(400, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mealink";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(279, 129);
            this.email.Name = "email";
            this.email.PlaceholderText = "Your School Email";
            this.email.Size = new System.Drawing.Size(308, 27);
            this.email.TabIndex = 1;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(279, 172);
            this.username.Name = "username";
            this.username.PlaceholderText = "Username";
            this.username.Size = new System.Drawing.Size(308, 27);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(279, 220);
            this.password.Name = "password";
            this.password.PlaceholderText = "Password";
            this.password.Size = new System.Drawing.Size(308, 27);
            this.password.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mealink.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(309, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // registernew
            // 
            this.registernew.BackColor = System.Drawing.SystemColors.Highlight;
            this.registernew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registernew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registernew.Location = new System.Drawing.Point(279, 346);
            this.registernew.Name = "registernew";
            this.registernew.Size = new System.Drawing.Size(308, 33);
            this.registernew.TabIndex = 6;
            this.registernew.Text = "Register";
            this.registernew.UseVisualStyleBackColor = false;
            this.registernew.Click += new System.EventHandler(this.registernew_Click);
            // 
            // favcuisine
            // 
            this.favcuisine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.favcuisine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favcuisine.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favcuisine.ForeColor = System.Drawing.SystemColors.GrayText;
            this.favcuisine.FormattingEnabled = true;
            this.favcuisine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.favcuisine.Items.AddRange(new object[] {
            "Chinese",
            "West",
            "Multi-cultural"});
            this.favcuisine.Location = new System.Drawing.Point(283, 265);
            this.favcuisine.Name = "favcuisine";
            this.favcuisine.Size = new System.Drawing.Size(303, 27);
            this.favcuisine.TabIndex = 7;
            this.favcuisine.Text = "---choose---";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(279, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.favcuisine);
            this.Controls.Add(this.registernew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registernew;
        private System.Windows.Forms.ComboBox favcuisine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}