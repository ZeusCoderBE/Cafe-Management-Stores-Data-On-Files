using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace BaiQuanLyQuancafe
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void sdt_label_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void repass_label_Click(object sender, EventArgs e)
        {

        }

        private void pass_label_Click(object sender, EventArgs e)
        {

        }

        private void Fullname_label_Click(object sender, EventArgs e)
        {

        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            Close();
        }
           public static Information inf = new Information();
        public void Addbutton()
        {
            inf = new Information(name_box.Text, phone_box.Text, nameac_box.Text, pass_box.Text, repass_box.Text);
        }
        private void Dk_button_Click(object sender, EventArgs e)
        {
            int t = 0;
            string accounts = "account.txt";
            string[] line;
            int num = 0;
            line = File.ReadAllLines(accounts);
            for(int i=0; i<line.Length; i++)
            {
                if (String.Compare(nameac_box.Text, line[i])==0&& String.Compare(pass_box.Text, line[i+1])==0)
                {
                    t = 1;
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu đã tồn tại ! Xin Vui lòng Nhập lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameac_box.Clear();
                    pass_box.Clear();
                    return;
                }
            }
            if (pass_box.Text.Length > 8 && nameac_box.Text.Length > 8 && phone_box.Text.Length == 10 && String.Compare(repass_box.Text, pass_box.Text) == 0 &&Int32.TryParse(phone_box.Text,out num))
            {
                Addbutton();
                string[] lines = new string[] { inf.Name, inf.Phonenumber, inf.Account, inf.Password, inf.Password };
                for (int i = 0; i < 1; i++)
                {
                    File.AppendAllLines(accounts, lines);
                }
                nameac_box.Clear();
                pass_box.Clear();
                phone_box.Clear();
                name_box.Clear();
                repass_box.Clear();
                MessageBox.Show("Bạn đã tạo tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.Compare(repass_box.Text, "") == 0 || (String.Compare(name_box.Text, "") == 0) || String.Compare(nameac_box.Text, "") == 0 || String.Compare(pass_box.Text, "") == 0 || String.Compare(phone_box.Text, "") == 0)
            {
                MessageBox.Show("Bạn Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.Compare(phone_box.Text,"A")>=0 && String.Compare(phone_box.Text,"Z")<=0|| String.Compare(phone_box.Text, "") >= 0 && String.Compare(phone_box.Text, "Z")<=0||(phone_box.Text.Length) <=9)
            {
                MessageBox.Show("Số Điện Thoại không hợp lệ(hợp lệ là khi nó là 1 dãy số gồm  10 số)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone_box.Clear();
            }
            else if (nameac_box.Text.Length <= 8)
            {
                MessageBox.Show(" Tên tài khoản phải lớn hơn 8 kí tự !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameac_box.Clear();
            }
            else if (String.Compare(repass_box.Text, pass_box.Text) != 0)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); pass_box.Clear();
                repass_box.Clear();
                pass_box.Clear();
            }
            else if (pass_box.Text.Length <= 8)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn 8 kí tự !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pass_box.Clear();
                repass_box.Clear();
            }
        }
        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
