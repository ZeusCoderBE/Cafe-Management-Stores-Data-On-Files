namespace BaiQuanLyQuancafe
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BackGround_box = new System.Windows.Forms.PictureBox();
            this.Account_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.account_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Createaccount_label = new System.Windows.Forms.Label();
            this.showpass_old = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpass_old)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround_box
            // 
            this.BackGround_box.Image = ((System.Drawing.Image)(resources.GetObject("BackGround_box.Image")));
            this.BackGround_box.Location = new System.Drawing.Point(13, 148);
            this.BackGround_box.Margin = new System.Windows.Forms.Padding(4);
            this.BackGround_box.Name = "BackGround_box";
            this.BackGround_box.Size = new System.Drawing.Size(255, 264);
            this.BackGround_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround_box.TabIndex = 0;
            this.BackGround_box.TabStop = false;
            this.BackGround_box.Click += new System.EventHandler(this.BackGround_box_Click);
            // 
            // Account_label
            // 
            this.Account_label.AutoSize = true;
            this.Account_label.BackColor = System.Drawing.Color.Yellow;
            this.Account_label.Font = new System.Drawing.Font("Constantia", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Account_label.ForeColor = System.Drawing.Color.Yellow;
            this.Account_label.Image = ((System.Drawing.Image)(resources.GetObject("Account_label.Image")));
            this.Account_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Account_label.Location = new System.Drawing.Point(328, 165);
            this.Account_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Account_label.Name = "Account_label";
            this.Account_label.Size = new System.Drawing.Size(236, 54);
            this.Account_label.TabIndex = 2;
            this.Account_label.Text = "Tài Khoản";
            this.Account_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.BackColor = System.Drawing.Color.Yellow;
            this.Password_label.Font = new System.Drawing.Font("Constantia", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password_label.ForeColor = System.Drawing.Color.Yellow;
            this.Password_label.Image = ((System.Drawing.Image)(resources.GetObject("Password_label.Image")));
            this.Password_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Password_label.Location = new System.Drawing.Point(337, 298);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(227, 54);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Mật Khẩu";
            this.Password_label.Click += new System.EventHandler(this.Password_label_Click);
            // 
            // account_textbox
            // 
            this.account_textbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.account_textbox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.account_textbox.ForeColor = System.Drawing.Color.Black;
            this.account_textbox.Location = new System.Drawing.Point(615, 165);
            this.account_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.account_textbox.Name = "account_textbox";
            this.account_textbox.Size = new System.Drawing.Size(450, 56);
            this.account_textbox.TabIndex = 4;
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password_textbox.ForeColor = System.Drawing.Color.Black;
            this.password_textbox.Location = new System.Drawing.Point(615, 298);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(450, 57);
            this.password_textbox.TabIndex = 5;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.White;
            this.Login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Login_button.Location = new System.Drawing.Point(810, 413);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(220, 77);
            this.Login_button.TabIndex = 6;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.White;
            this.Exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_button.BackgroundImage")));
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(1, 0);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 67);
            this.Exit_button.TabIndex = 8;
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Createaccount_label
            // 
            this.Createaccount_label.AutoSize = true;
            this.Createaccount_label.BackColor = System.Drawing.Color.Tan;
            this.Createaccount_label.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Createaccount_label.ForeColor = System.Drawing.Color.Yellow;
            this.Createaccount_label.Image = ((System.Drawing.Image)(resources.GetObject("Createaccount_label.Image")));
            this.Createaccount_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Createaccount_label.Location = new System.Drawing.Point(419, 547);
            this.Createaccount_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Createaccount_label.Name = "Createaccount_label";
            this.Createaccount_label.Size = new System.Drawing.Size(598, 41);
            this.Createaccount_label.TabIndex = 9;
            this.Createaccount_label.Text = "Bạn chưa có tài khoản ? Đăng kí tại đây !";
            this.Createaccount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Createaccount_label.Click += new System.EventHandler(this.Createaccount_label_Click);
            // 
            // showpass_old
            // 
            this.showpass_old.Image = ((System.Drawing.Image)(resources.GetObject("showpass_old.Image")));
            this.showpass_old.Location = new System.Drawing.Point(1107, 293);
            this.showpass_old.Name = "showpass_old";
            this.showpass_old.Size = new System.Drawing.Size(77, 62);
            this.showpass_old.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showpass_old.TabIndex = 19;
            this.showpass_old.TabStop = false;
            this.showpass_old.Click += new System.EventHandler(this.showpass_old_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 650);
            this.Controls.Add(this.showpass_old);
            this.Controls.Add(this.Createaccount_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.account_textbox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Account_label);
            this.Controls.Add(this.BackGround_box);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpass_old)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround_box;
        private System.Windows.Forms.Label Account_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label Createaccount_label;
        public System.Windows.Forms.TextBox account_textbox;
        public System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.PictureBox showpass_old;
    }
}