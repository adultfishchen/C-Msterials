
namespace Mealink
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.slogan = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.slogan.ForeColor = System.Drawing.Color.Coral;
            this.slogan.Location = new System.Drawing.Point(145, 9);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(641, 68);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "Welcome to Mealink!!";
            this.slogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.slogan.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(32, 135);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(384, 23);
            this.title.TabIndex = 2;
            this.title.Text = "Do you desire to broaden your friendship ?";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.BackgroundImage = global::Mealink.Properties.Resources.register_now1;
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.register.Location = new System.Drawing.Point(32, 379);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(134, 40);
            this.register.TabIndex = 3;
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // game
            // 
            this.game.BackgroundImage = global::Mealink.Properties.Resources.play_game_button;
            this.game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game.ForeColor = System.Drawing.Color.White;
            this.game.Location = new System.Drawing.Point(513, 379);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(134, 40);
            this.game.TabIndex = 4;
            this.game.UseVisualStyleBackColor = true;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // reserve
            // 
            this.reserve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reserve.BackgroundImage = global::Mealink.Properties.Resources.reserve_now_button;
            this.reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reserve.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reserve.Location = new System.Drawing.Point(261, 379);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(134, 40);
            this.reserve.TabIndex = 5;
            this.reserve.UseVisualStyleBackColor = false;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mealink.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(451, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Do you wnat to enjoy a great meal?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(120, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Do you want to gain more coupons?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(32, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Join us now!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(261, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Achieve all what you wants!";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Mealink.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(721, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 62);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.game);
            this.Controls.Add(this.register);
            this.Controls.Add(this.title);
            this.Controls.Add(this.slogan);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

