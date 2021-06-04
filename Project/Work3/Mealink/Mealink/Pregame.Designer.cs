
namespace Mealink
{
    partial class Pregame
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
            this.go = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mealink.Properties.Resources.warning;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.SystemColors.Highlight;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.go.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.go.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go.Location = new System.Drawing.Point(-1, 193);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(228, 73);
            this.go.TabIndex = 1;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.Highlight;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.Location = new System.Drawing.Point(223, 193);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(228, 73);
            this.home.TabIndex = 2;
            this.home.Text = "BACK";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Only member can obtaion rewards!\r\nConfirm your membership!!";
            // 
            // Pregame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.go);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pregame";
            this.Text = "Pregame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label1;
    }
}