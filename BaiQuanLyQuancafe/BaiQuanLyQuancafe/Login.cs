using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace BaiQuanLyQuancafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BackGround_box_Click(object sender, EventArgs e)
        {

        }
        string output = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng, Vui Lòng Nhập Lại";
        public  static  PrivateInfor Infor = new PrivateInfor();

        private void Login_button_Click(object sender, EventArgs e)
        {
            int t = 0;
            string accounts = "account.txt";
            string[] lines;
            lines = File.ReadAllLines(accounts);
            for (int i = 0; i <lines.Length-1; i++)
            {
                if (String.Compare(lines[i],account_textbox.Text) == 0 && String.Compare(lines[i+1], password_textbox.Text) == 0)
                {
                    GenCha green = new GenCha();
                    green.Show();
                    account_textbox.Clear();
                    password_textbox.Clear();
                    Infor.name_textbox.Text = lines[i - 2];
                    Infor.phonenumber_textbox.Text = lines[i-1];
                    t = 1;
                    Close();
                    break;
                }
            }
            if(t==0)
            {
                MessageBox.Show(output, "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        int checkpass = 1;

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Createaccount_label_Click(object sender, EventArgs e)
        {
            CreateAccount cr = new CreateAccount();
            cr.Show();
            Close();
        }
        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void showpass_old_Click(object sender, EventArgs e)
        {
            if (checkpass == 1)
            {
                password_textbox.UseSystemPasswordChar = false;
                showpass_old.Image = new Bitmap(Application.StartupPath + "/Resources/1.jpg");
                checkpass = 0;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
                showpass_old.Image = new Bitmap(Application.StartupPath + "/Resources/2.jpg");
                checkpass = 1;
            }
        }
    }
}
