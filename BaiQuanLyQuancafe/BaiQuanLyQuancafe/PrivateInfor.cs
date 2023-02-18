using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Security.Policy;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaiQuanLyQuancafe
{
    public partial class PrivateInfor : Form
    {
        public PrivateInfor()
        {
            InitializeComponent();
        }
        static List<Information> a = new List<Information>();
        private void PrivateInfor_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Hide();
        }
        string output = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng, Vui Lòng Nhập Lại";
        static string[] lines;
        static int t = 0;
        private void Save_button_Click(object sender, EventArgs e)
        {
            string accounts = "account.txt";
            lines = File.ReadAllLines(accounts);
            string[] x = new string[] { };
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 5 == 4)
                {
                    CreateAccount.inf = new Information(lines[i - 4], lines[i - 3], lines[i - 2], lines[i - 1], lines[i]);
                    a.Add(CreateAccount.inf);
                }
            }
            for (int k = 0; k < lines.Length; k++)
            {
                if (String.Compare(lines[k], accoun_textbox.Text) == 0 && String.Compare(lines[k + 1], pass_textbox.Text) == 0 && String.Compare(lines[k + 2], changere_textbox.Text) == 0)
                {
                    t = 1;
                    goto jump;
                }
            }
            if (t == 0)
            {
                MessageBox.Show(output, "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
        jump:
            File.WriteAllLines(accounts, x);
            for (int i=0;i<a.Count; i++)
            {
                if (String.Compare(a[i].Account, accoun_textbox.Text) == 0 && String.Compare(a[i].Password, pass_textbox.Text) == 0 && String.Compare(a[i].Repassword, changere_textbox.Text) == 0)
                {
                    a[i].Name = name_textbox.Text;
                    a[i].Phonenumber = phonenumber_textbox.Text;
                }
                string[] k = new string[] { a[i].Name, a[i].Phonenumber, a[i].Account, a[i].Password, a[i].Repassword };
                File.AppendAllLines(accounts, k);
            }
            MessageBox.Show("Bạn Đã Thay Đổi Thông Tin Thành Công ! ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            accoun_textbox.Clear();
            pass_textbox.Clear();
            changere_textbox.Clear();
        }
        int checkpass = 1;
        private void showpass_old_Click(object sender, EventArgs e)
        {
            if (checkpass == 1)
            {
                pass_textbox.UseSystemPasswordChar = false;
                showpass_old.Image = new Bitmap(Application.StartupPath + "/Resources/1.jpg");
                checkpass = 0;
            }
            else
            {
                pass_textbox.UseSystemPasswordChar = true;
                showpass_old.Image = new Bitmap(Application.StartupPath + "/Resources/2.jpg");
                checkpass = 1;
            }
        }

        private void showre_password_Click(object sender, EventArgs e)
        {
            if (checkpass == 1)
            {
                changere_textbox.UseSystemPasswordChar = false;
                showre_password.Image = new Bitmap(Application.StartupPath + "/Resources/1.jpg");
                checkpass = 0;
            }
            else
            {
                changere_textbox.UseSystemPasswordChar = true;
                showre_password.Image = new Bitmap(Application.StartupPath + "/Resources/2.jpg");
                checkpass = 1;
            }
        }
    }
}

