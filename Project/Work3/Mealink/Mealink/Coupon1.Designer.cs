
namespace Mealink
{
    partial class Coupon1
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
            this.check = new System.Windows.Forms.Button();
            this.dismiss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mealink.Properties.Resources.coupon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.Highlight;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check.Location = new System.Drawing.Point(-2, 220);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(226, 45);
            this.check.TabIndex = 1;
            this.check.Text = "GET";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // dismiss
            // 
            this.dismiss.BackColor = System.Drawing.SystemColors.Highlight;
            this.dismiss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dismiss.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dismiss.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dismiss.Location = new System.Drawing.Point(223, 220);
            this.dismiss.Name = "dismiss";
            this.dismiss.Size = new System.Drawing.Size(228, 45);
            this.dismiss.TabIndex = 2;
            this.dismiss.Text = "DISMISS";
            this.dismiss.UseVisualStyleBackColor = false;
            this.dismiss.Click += new System.EventHandler(this.dismiss_Click);
            // 
            // Coupon1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 265);
            this.Controls.Add(this.dismiss);
            this.Controls.Add(this.check);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Coupon1";
            this.Text = "Coupon1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button dismiss;
    }
}