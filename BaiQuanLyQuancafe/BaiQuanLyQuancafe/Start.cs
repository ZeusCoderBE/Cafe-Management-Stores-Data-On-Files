using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiQuanLyQuancafe
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Sound_button_Click(null,null);
        }

        private void Start_Load(object sender, EventArgs e)
        {
                
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn Có Chắc Chắn Thoát Không ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Start_button_Click(object sender, EventArgs e)
        { 
            Login login = new Login();
            login.Show();
        }
        int check = 1;
        PlaySound ps=new PlaySound();
        private void Sound_button_Click(object sender, EventArgs e)
        {
            if(check==1)
            {
                ps.OpenMediaFile("5BEST.mp3");
                ps.PlayMediaFile(true);
                Sound_button.Text = "Sound Off";
                check = 0;
            }
            else
            {
                ps.ClosePlayer();
                Sound_button.Text = "Sound On";
                check = 1;
            }
        }
    }
}
