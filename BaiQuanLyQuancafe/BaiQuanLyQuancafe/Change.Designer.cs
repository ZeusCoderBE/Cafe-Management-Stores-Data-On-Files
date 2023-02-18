namespace BaiQuanLyQuancafe
{
    partial class Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change));
            this.Save_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.newpass_textbox = new System.Windows.Forms.TextBox();
            this.renewpass_textbox = new System.Windows.Forms.TextBox();
            this.oldpassword_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.repass_label = new System.Windows.Forms.Label();
            this.changep_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.showpass_old = new System.Windows.Forms.PictureBox();
            this.shownew_password = new System.Windows.Forms.PictureBox();
            this.showrenew_password = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showpass_old)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shownew_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showrenew_password)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.SystemColors.Control;
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.ForeColor = System.Drawing.Color.Red;
            this.Save_button.Location = new System.Drawing.Point(829, 476);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(162, 60);
            this.Save_button.TabIndex = 0;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password_textbox.Location = new System.Drawing.Point(463, 172);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(380, 49);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // newpass_textbox
            // 
            this.newpass_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newpass_textbox.Location = new System.Drawing.Point(463, 281);
            this.newpass_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.newpass_textbox.Name = "newpass_textbox";
            this.newpass_textbox.Size = new System.Drawing.Size(380, 49);
            this.newpass_textbox.TabIndex = 2;
            this.newpass_textbox.UseSystemPasswordChar = true;
            // 
            // renewpass_textbox
            // 
            this.renewpass_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.renewpass_textbox.Location = new System.Drawing.Point(463, 387);
            this.renewpass_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.renewpass_textbox.Name = "renewpass_textbox";
            this.renewpass_textbox.Size = new System.Drawing.Size(380, 49);
            this.renewpass_textbox.TabIndex = 3;
            this.renewpass_textbox.UseSystemPasswordChar = true;
            // 
            // oldpassword_label
            // 
            this.oldpassword_label.AutoSize = true;
            this.oldpassword_label.BackColor = System.Drawing.Color.DimGray;
            this.oldpassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.oldpassword_label.ForeColor = System.Drawing.Color.Yellow;
            this.oldpassword_label.Location = new System.Drawing.Point(53, 175);
            this.oldpassword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldpassword_label.Name = "oldpassword_label";
            this.oldpassword_label.Size = new System.Drawing.Size(354, 42);
            this.oldpassword_label.TabIndex = 4;
            this.oldpassword_label.Text = "Mật khẩu cũ           ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.DimGray;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password_label.ForeColor = System.Drawing.Color.Yellow;
            this.password_label.Location = new System.Drawing.Point(53, 284);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(352, 42);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Mật khẩu mới         ";
            // 
            // repass_label
            // 
            this.repass_label.AutoSize = true;
            this.repass_label.BackColor = System.Drawing.Color.DimGray;
            this.repass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repass_label.ForeColor = System.Drawing.Color.Yellow;
            this.repass_label.Location = new System.Drawing.Point(53, 394);
            this.repass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repass_label.Name = "repass_label";
            this.repass_label.Size = new System.Drawing.Size(357, 42);
            this.repass_label.TabIndex = 6;
            this.repass_label.Text = "Xác nhận mật khẩu";
            // 
            // changep_label
            // 
            this.changep_label.AutoSize = true;
            this.changep_label.BackColor = System.Drawing.Color.DimGray;
            this.changep_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.changep_label.ForeColor = System.Drawing.Color.Red;
            this.changep_label.Location = new System.Drawing.Point(308, 9);
            this.changep_label.Name = "changep_label";
            this.changep_label.Size = new System.Drawing.Size(438, 54);
            this.changep_label.TabIndex = 7;
            this.changep_label.Text = "Thay Đổi Mật Khẩu";
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
            this.Exit_button.Location = new System.Drawing.Point(0, -4);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 67);
            this.Exit_button.TabIndex = 9;
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // showpass_old
            // 
            this.showpass_old.Image = ((System.Drawing.Image)(resources.GetObject("showpass_old.Image")));
            this.showpass_old.Location = new System.Drawing.Point(883, 169);
            this.showpass_old.Name = "showpass_old";
            this.showpass_old.Size = new System.Drawing.Size(64, 52);
            this.showpass_old.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showpass_old.TabIndex = 10;
            this.showpass_old.TabStop = false;
            this.showpass_old.Click += new System.EventHandler(this.showpass_old_Click_1);
            // 
            // shownew_password
            // 
            this.shownew_password.Image = ((System.Drawing.Image)(resources.GetObject("shownew_password.Image")));
            this.shownew_password.Location = new System.Drawing.Point(883, 281);
            this.shownew_password.Name = "shownew_password";
            this.shownew_password.Size = new System.Drawing.Size(64, 49);
            this.shownew_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shownew_password.TabIndex = 15;
            this.shownew_password.TabStop = false;
            this.shownew_password.Click += new System.EventHandler(this.shownew_password_Click);
            // 
            // showrenew_password
            // 
            this.showrenew_password.Image = ((System.Drawing.Image)(resources.GetObject("showrenew_password.Image")));
            this.showrenew_password.Location = new System.Drawing.Point(883, 387);
            this.showrenew_password.Name = "showrenew_password";
            this.showrenew_password.Size = new System.Drawing.Size(64, 49);
            this.showrenew_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showrenew_password.TabIndex = 16;
            this.showrenew_password.TabStop = false;
            this.showrenew_password.Click += new System.EventHandler(this.showrenew_password_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 549);
            this.Controls.Add(this.showrenew_password);
            this.Controls.Add(this.shownew_password);
            this.Controls.Add(this.showpass_old);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.changep_label);
            this.Controls.Add(this.repass_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.oldpassword_label);
            this.Controls.Add(this.renewpass_textbox);
            this.Controls.Add(this.newpass_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.Save_button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Informaiton";
            this.Load += new System.EventHandler(this.Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showpass_old)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shownew_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showrenew_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox newpass_textbox;
        private System.Windows.Forms.TextBox renewpass_textbox;
        private System.Windows.Forms.Label oldpassword_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label repass_label;
        private System.Windows.Forms.Label changep_label;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox showpass_old;
        private System.Windows.Forms.PictureBox shownew_password;
        private System.Windows.Forms.PictureBox showrenew_password;
    }
}