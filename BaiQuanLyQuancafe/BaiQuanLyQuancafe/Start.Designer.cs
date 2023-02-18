namespace BaiQuanLyQuancafe
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.Sound_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.Exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.Exit_button, "Exit_button");
            this.Exit_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.Start_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Start_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.Start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.Start_button, "Start_button");
            this.Start_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Start_button.Name = "Start_button";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Sound_button
            // 
            this.Sound_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.Sound_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Sound_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.Sound_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.Sound_button, "Sound_button");
            this.Sound_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Sound_button.Name = "Sound_button";
            this.Sound_button.UseVisualStyleBackColor = false;
            this.Sound_button.Click += new System.EventHandler(this.Sound_button_Click);
            // 
            // Start
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.Sound_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Exit_button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.TransparencyKey = System.Drawing.Color.Moccasin;
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Sound_button;
    }
}

