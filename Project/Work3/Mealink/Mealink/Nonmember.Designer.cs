
namespace Mealink
{
    partial class Nonmember
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
            this.label1 = new System.Windows.Forms.Label();
            this.regis = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mealink.Properties.Resources.sorry;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(185, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "you have no right to start this function without having a membership!!";
            // 
            // regis
            // 
            this.regis.BackColor = System.Drawing.SystemColors.Highlight;
            this.regis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regis.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regis.Location = new System.Drawing.Point(-1, 254);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(401, 73);
            this.regis.TabIndex = 2;
            this.regis.Text = "Register Now!";
            this.regis.UseVisualStyleBackColor = false;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.Highlight;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.Location = new System.Drawing.Point(393, 254);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(401, 73);
            this.home.TabIndex = 3;
            this.home.Text = "Back to Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Nonmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 325);
            this.Controls.Add(this.home);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nonmember";
            this.Text = "Nonmember";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.Button home;
    }
}