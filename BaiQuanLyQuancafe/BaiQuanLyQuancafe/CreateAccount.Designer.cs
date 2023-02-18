namespace BaiQuanLyQuancafe
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.name_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.repass_label = new System.Windows.Forms.Label();
            this.Fullname_label = new System.Windows.Forms.Label();
            this.sdt_label = new System.Windows.Forms.Label();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.nameac_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.repass_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Dk_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name_label.ForeColor = System.Drawing.Color.Yellow;
            this.name_label.Image = ((System.Drawing.Image)(resources.GetObject("name_label.Image")));
            this.name_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.name_label.Location = new System.Drawing.Point(88, 308);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(279, 38);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Tên Tài Khoản          ";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pass_label.ForeColor = System.Drawing.Color.Yellow;
            this.pass_label.Image = ((System.Drawing.Image)(resources.GetObject("pass_label.Image")));
            this.pass_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.pass_label.Location = new System.Drawing.Point(88, 403);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(289, 38);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Mật Khẩu                  ";
            this.pass_label.Click += new System.EventHandler(this.pass_label_Click);
            // 
            // repass_label
            // 
            this.repass_label.AutoSize = true;
            this.repass_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repass_label.ForeColor = System.Drawing.Color.Yellow;
            this.repass_label.Image = ((System.Drawing.Image)(resources.GetObject("repass_label.Image")));
            this.repass_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.repass_label.Location = new System.Drawing.Point(93, 489);
            this.repass_label.Name = "repass_label";
            this.repass_label.Size = new System.Drawing.Size(286, 38);
            this.repass_label.TabIndex = 2;
            this.repass_label.Text = "Xác Nhận Mật Khẩu ";
            this.repass_label.Click += new System.EventHandler(this.repass_label_Click);
            // 
            // Fullname_label
            // 
            this.Fullname_label.AutoSize = true;
            this.Fullname_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Fullname_label.ForeColor = System.Drawing.Color.Yellow;
            this.Fullname_label.Image = ((System.Drawing.Image)(resources.GetObject("Fullname_label.Image")));
            this.Fullname_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Fullname_label.Location = new System.Drawing.Point(86, 126);
            this.Fullname_label.Name = "Fullname_label";
            this.Fullname_label.Size = new System.Drawing.Size(282, 38);
            this.Fullname_label.TabIndex = 3;
            this.Fullname_label.Text = "Họ và Tên                 ";
            this.Fullname_label.Click += new System.EventHandler(this.Fullname_label_Click);
            // 
            // sdt_label
            // 
            this.sdt_label.AutoSize = true;
            this.sdt_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sdt_label.ForeColor = System.Drawing.Color.Yellow;
            this.sdt_label.Image = ((System.Drawing.Image)(resources.GetObject("sdt_label.Image")));
            this.sdt_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sdt_label.Location = new System.Drawing.Point(86, 214);
            this.sdt_label.Name = "sdt_label";
            this.sdt_label.Size = new System.Drawing.Size(288, 38);
            this.sdt_label.TabIndex = 4;
            this.sdt_label.Text = "Số Điện Thoại           ";
            this.sdt_label.Click += new System.EventHandler(this.sdt_label_Click);
            // 
            // phone_box
            // 
            this.phone_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phone_box.Location = new System.Drawing.Point(473, 212);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(295, 38);
            this.phone_box.TabIndex = 6;
            // 
            // nameac_box
            // 
            this.nameac_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nameac_box.Location = new System.Drawing.Point(473, 308);
            this.nameac_box.Name = "nameac_box";
            this.nameac_box.Size = new System.Drawing.Size(295, 38);
            this.nameac_box.TabIndex = 7;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pass_box.Location = new System.Drawing.Point(473, 403);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(295, 38);
            this.pass_box.TabIndex = 8;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // repass_box
            // 
            this.repass_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repass_box.Location = new System.Drawing.Point(473, 489);
            this.repass_box.Name = "repass_box";
            this.repass_box.Size = new System.Drawing.Size(295, 38);
            this.repass_box.TabIndex = 9;
            this.repass_box.UseSystemPasswordChar = true;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name_box.Location = new System.Drawing.Point(473, 124);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(295, 38);
            this.name_box.TabIndex = 10;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng Ký Tài Khoản";
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
            this.Exit_button.TabIndex = 12;
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Dk_button
            // 
            this.Dk_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dk_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Dk_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Dk_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dk_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Dk_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Dk_button.Location = new System.Drawing.Point(295, 561);
            this.Dk_button.Name = "Dk_button";
            this.Dk_button.Size = new System.Drawing.Size(223, 62);
            this.Dk_button.TabIndex = 13;
            this.Dk_button.Text = "Đăng Ký";
            this.Dk_button.UseVisualStyleBackColor = true;
            this.Dk_button.Click += new System.EventHandler(this.Dk_button_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 664);
            this.Controls.Add(this.Dk_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.repass_box);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.nameac_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.sdt_label);
            this.Controls.Add(this.Fullname_label);
            this.Controls.Add(this.repass_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.name_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label repass_label;
        private System.Windows.Forms.Label Fullname_label;
        private System.Windows.Forms.Label sdt_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Dk_button;
        public System.Windows.Forms.TextBox phone_box;
        public System.Windows.Forms.TextBox nameac_box;
        public System.Windows.Forms.TextBox pass_box;
        public System.Windows.Forms.TextBox repass_box;
        public System.Windows.Forms.TextBox name_box;
    }
}