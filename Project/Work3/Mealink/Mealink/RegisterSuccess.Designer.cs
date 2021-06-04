
namespace Mealink
{
    partial class RegisterSuccess
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suc_regis = new System.Windows.Forms.Label();
            this.welcomemes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mealink.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(42, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // suc_regis
            // 
            this.suc_regis.AutoSize = true;
            this.suc_regis.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suc_regis.ForeColor = System.Drawing.Color.LimeGreen;
            this.suc_regis.Location = new System.Drawing.Point(236, 19);
            this.suc_regis.Name = "suc_regis";
            this.suc_regis.Size = new System.Drawing.Size(229, 55);
            this.suc_regis.TabIndex = 1;
            this.suc_regis.Text = "Success!";
            // 
            // welcomemes
            // 
            this.welcomemes.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.welcomemes.AutoSize = true;
            this.welcomemes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomemes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.welcomemes.Location = new System.Drawing.Point(211, 102);
            this.welcomemes.Name = "welcomemes";
            this.welcomemes.Size = new System.Drawing.Size(291, 35);
            this.welcomemes.TabIndex = 2;
            this.welcomemes.Text = "Welcome to Mealink!";
            this.welcomemes.Click += new System.EventHandler(this.welcomemes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(531, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcomemes);
            this.Controls.Add(this.suc_regis);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterSuccess";
            this.Text = "RegisterSuccess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label suc_regis;
        public System.Windows.Forms.Label welcomemes;
        private System.Windows.Forms.Button button1;
    }
}