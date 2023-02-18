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

namespace BaiQuanLyQuancafe
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void Change_Load(object sender, EventArgs e)
        {

        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
        string output = " Mật Khẩu Không Đúng, Vui Lòng Nhập Lại";
        string[] line;
        string x = "account.txt";
        List<Information>list =new List<Information>();
        Information inf=new Information();
        private void Save_button_Click(object sender, EventArgs e)
        {
            int t = 0;
            line=File.ReadAllLines(x);
            string[] y = new string[] { };
            for (int i = 0; i < line.Length; i++)
            {
                if (i % 5 == 4)
                {
                    inf = new Information(line[i - 4], line[i - 3], line[i - 2], line[i - 1], line[i]) ;
                    list.Add(inf);
                }
            }
            for(int i = 0; i < line.Length; i++) 
            {
                if (String.Compare(line[i],password_textbox.Text)==0 &&String.Compare(password_textbox.Text, newpass_textbox.Text) != 0 && String.Compare(newpass_textbox.Text, renewpass_textbox.Text) == 0)
                {
                    t = 1;
                    goto jump;
                }
            }
             if (String.Compare(newpass_textbox.Text, "") == 0 || String.Compare(renewpass_textbox.Text, "") == 0 || String.Compare(password_textbox.Text, "") == 0)
            {
                MessageBox.Show("Bạn Không Được Để Trống", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
            if (t==0)
            {
                MessageBox.Show(output, "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
            if(String.Compare(password_textbox.Text, newpass_textbox.Text) == 0)
            {
                MessageBox.Show("Mật Khẩu Mới Không Được Trùng Với Mật Khẩu Cũ", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
            else if( String.Compare(newpass_textbox.Text, renewpass_textbox.Text) != 0)
            {
                MessageBox.Show("Xác Nhận Mật Khẩu Không Khớp", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
            jump: 
            File.WriteAllLines(x, y);
            for(int j=0;j<list.Count;j++)
            {
                if (String.Compare(list[j].Password,password_textbox.Text)==0 && String.Compare(password_textbox.Text, newpass_textbox.Text) !=0 &&String.Compare(newpass_textbox.Text, renewpass_textbox.Text)==0)
                {
                    list[j].Password = newpass_textbox.Text;
                    list[j].Repassword = renewpass_textbox.Text;
                }
                string[] newinf = new string[] { list[j].Name, list[j].Phonenumber, list[j].Account, list[j].Password, list[j].Repassword };
                File.AppendAllLines(x, newinf);
            }
            MessageBox.Show("Bạn Đã Thay Đổi Thông Tin Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            password_textbox.Clear();
            newpass_textbox.Clear();
            renewpass_textbox.Clear();
        }
        int check = 1;

        private void showpass_old_Click_1(object sender, EventArgs e)
        {
            if (check == 1)
            {
                password_textbox.UseSystemPasswordChar = false;
                showpass_old.Image = new Bitmap(Application.StartupPath + "/Resources/1.jpg");
                check = 0;
            }
            else
            {

                password_textbox.UseSystemPasswordChar = true;
                showpass_old.Image = new Bitmap(Application.StartupPath + "/Resources/2.jpg");
                check = 1;
            }
        }

        private void shownew_password_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                newpass_textbox.UseSystemPasswordChar = false;
                shownew_password.Image = new Bitmap(Application.StartupPath + "/Resources/1.jpg");
                check = 0;
            }
            else
            {

                newpass_textbox.UseSystemPasswordChar = true;
                shownew_password.Image = new Bitmap(Application.StartupPath + "/Resources/2.jpg");
                check = 1;
            }
        }

        private void showrenew_password_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                renewpass_textbox.UseSystemPasswordChar = false;
                showrenew_password.Image = new Bitmap(Application.StartupPath + "/Resources/1.jpg");
                check = 0;
            }
            else
            {

                renewpass_textbox.UseSystemPasswordChar = true;
                showrenew_password.Image = new Bitmap(Application.StartupPath + "/Resources/2.jpg");
                check = 1;
            }
        }
    }
}
