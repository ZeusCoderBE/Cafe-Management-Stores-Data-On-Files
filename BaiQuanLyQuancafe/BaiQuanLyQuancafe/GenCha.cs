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
using System.Reflection;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace BaiQuanLyQuancafe
{
    public partial class GenCha : Form
    {
        public GenCha()
        {
              InitializeComponent();
              ProcessBinding();
              AddBinding();
              LoadList();
        }
        static Cafe cf = new Cafe();
        static List<Cafe> listcf;
        Label lb = new Label() { Text = "Delicious Drink", Location = new Point(230, 180) };
        ImageList smalliml;
        List<Cafe> list = new List<Cafe>();
        string Bill = "Bill.txt";
        static string Output = "";
        string[] remove = new string[]{ };

        void LoadLogo()
        {
            smalliml = new ImageList() { ImageSize = new Size(20, 30) };
            smalliml.Images.Add(new Bitmap(Application.StartupPath + "/Picture/2.jpg"));
        }   
        void Loadlabel()
        { 
            lb.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(163)));
            lb.ForeColor = Color.Black;
            lb.Size = new Size(200, 120);
            pnelmenu_picture.Controls.Add(lb);
        }
        void ProcessBinding()
        {
            listcf = new List<Cafe>()
              {
                 new Cafe("S", 0) { },
                 new Cafe("M",10000) { },
                 new Cafe("L",15000) { }
              };
            size_box.DataSource = listcf;
            size_box.DisplayMember = "Size";
            listcf = new List<Cafe>()
              {
                 new Cafe("không có",0),
                 new Cafe("Trân Châu Caraman",3000),
                 new Cafe("Trân Châu Trắng 3Q", 5000),
                 new Cafe("Khúc bạch", 5000),
                 new Cafe("Sương Sáo Thảo Mộc", 5000),
                 new Cafe("Budding Trứng", 5000), new Cafe("Cream Cheese",10000),
                 new Cafe("Cream Cheese", 10000), new Cafe("Thạch Nha Đam", 10000),
                 new Cafe("Full Topping", 20000)
              };
            topping_box.DataSource = listcf;
            topping_box.DisplayMember = "Size";
        }
        void AddBinding()
        {
            Sizeprice_textbox.DataBindings.Add(new Binding("Text", size_box.DataSource, "Price"));
            topping_textbox.DataBindings.Add(new Binding("Text", topping_box.DataSource, "Price"));
        }
        void LoadList()
        {
            LoadLogo();
            showitem.Columns.Add("Name Drinks", 100);
            showitem.Columns.Add("Price", 80);
            showitem.Columns.Add("Toppings", 150);
            showitem.Columns.Add("Size", 50);
            showitem.Columns.Add("Number", 50);
            showitem.SmallImageList = smalliml;
            showitem.FullRowSelect = true;
            showitem.CheckBoxes = true;
            showitem.GridLines = true;
            showitem.View = View.Details;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cf.Name = Drink1_label.Text;
        }
        private void Information_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Infor.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message,"Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Khởi Động Lại Ứng Dụng  !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            DialogResult dl = MessageBox.Show("Bạn Có Chắc Chắn Thoát Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                a.Show();
                Close();
            }
        }
        private void All_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            Drink1_label.Show();
            Drink2_label.Show();
            Drink3_label.Show();
            Drink4_label.Show();
            Drink5_label.Show();
            Drink6_label.Show();
            Drink7_label.Show();
            Drink8_label.Show();
            Price1_label.Show();
            Price2_label.Show();
            Price3_label.Show();
            Price4_label.Show();
            Price5_label.Show();
            Price6_label.Show();
            Price7_label.Show();
            Price8_label.Show();
            Menu_label.Show();
            lb.Hide();
        }
        private void Special_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            Drink1_label.Hide();
            Drink2_label.Hide();
            Drink3_label.Hide();
            Drink4_label.Hide();
            Drink5_label.Hide();
            Drink6_label.Hide();
            Drink7_label.Hide();
            Drink8_label.Hide();
            Price1_label.Hide();
            Price2_label.Hide();
            Price3_label.Hide();
            Price4_label.Hide();
            Price5_label.Hide();
            Price6_label.Hide();
            Price7_label.Hide();
            Price8_label.Hide();
            lb.Show();
            Loadlabel();
            Menu_label.Hide();
        }
        private void number_up_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Remove_button_Click(object sender, EventArgs e)
        {
           for(int i=0;i<showitem.Items.Count;i++)
            {
                if (showitem.Items[i].Checked == true)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (String.Compare(showitem.Items[i].Text, list[j].Name) == 0)
                        {
                            list[j].Name = "";
                            list[j].Price = 0;
                            list[j].Topping = "";
                            list[j].Size = "Không có";
                            list[j].Number = 0;
                        }
                        string[] line = new string[] { list[j].Name, list[j].Price.ToString(), list[j].Topping, list[j].Size, list[j].Number.ToString() };
                        File.AppendAllLines(Bill, line);
                    }
                    showitem.Items[i].Remove();
                }
            }
        }
        private void showitem_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int u = 0;
            string[] lines;
            lines = File.ReadAllLines(Bill);
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 5 == 4)
                {
                    u = u + Convert.ToInt32(lines[i - 3]);
                    cf = new Cafe(lines[i - 4], Convert.ToInt32(lines[i - 3]), lines[i - 2], lines[i - 1], Convert.ToInt32(lines[i]));
                    list.Add(cf);
                }
            }
        }
        private void showitem_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }
        private void Payment_button_Click(object sender, EventArgs e)
        {
            int u = 0;
            string[] lines;
            lines=File.ReadAllLines(Bill);
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 5 == 4)
                {
                    u = u + Convert.ToInt32(lines[i - 3]);
                    cf = new Cafe(lines[i - 4], Convert.ToInt32(lines[i - 3]), lines[i - 2], lines[i - 1], Convert.ToInt32(lines[i]));
                    if (String.Compare(cf.Name, "") != 0)
                    {
                        Output += cf.Display();
                    }
                }
            }
            MessageBox.Show(Output, "Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(u.ToString(), "Tổng Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Output = "";
            File.WriteAllLines(Bill, remove);
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (String.Compare(cf.Name, "Trà Sữa ") == 0)
            {
                ListViewItem item2 = new ListViewItem();
                cf = new Cafe(cf.Name, Int32.Parse(Price1_label.Text) * Int32.Parse(number_up.Text) + Int32.Parse(Sizeprice_textbox.Text) * Int32.Parse(number_up.Text) + Int32.Parse(topping_textbox.Text) * Int32.Parse(number_up.Text), topping_box.Text, size_box.Text, Int32.Parse(number_up.Text));
                if (Int32.Parse(number_up.Text) == 1)
                {
                    item2.Text = cf.Name;
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Price.ToString() });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Topping });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Size });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = number_up.Text });
                    showitem.Items.Add(item2);
                }
                else
                {
                    item2.Text = cf.Name;
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Price.ToString() });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Topping });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Size });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = number_up.Text });
                    showitem.Items.Add(item2);
                }
                item2.ImageIndex = 0;
                string[] line = new string[] { cf.Name, cf.Price.ToString(), cf.Topping, cf.Size, cf.Number.ToString() };
                for (int i = 0; i < 1; i++)
                {
                    File.AppendAllLines(Bill, line);
                }
            }
            if (String.Compare(cf.Name, "Trà Sữa Dâu") == 0)
            {
                ListViewItem item2 = new ListViewItem();
                cf = new Cafe(cf.Name, Int32.Parse(Price2_label.Text) * Int32.Parse(number_up.Text) + Int32.Parse(Sizeprice_textbox.Text) * Int32.Parse(number_up.Text) + Int32.Parse(topping_textbox.Text) * Int32.Parse(number_up.Text), topping_box.Text, size_box.Text, Int32.Parse(number_up.Text));
                if (Int32.Parse(number_up.Text) == 1)
                {
                    item2.Text = cf.Name;
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Price.ToString() });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Topping });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Size });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = number_up.Text });
                    showitem.Items.Add(item2);
                }
                else
                {
                    item2.Text = cf.Name;
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Price.ToString() });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Topping });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cf.Size });
                    item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = number_up.Text });
                    showitem.Items.Add(item2);
                }
                item2.ImageIndex = 0;
                string[] line = new string[] { cf.Name, cf.Price.ToString(), cf.Topping, cf.Size, cf.Number.ToString() };
                for (int i = 0; i < 1; i++)
                {
                    File.AppendAllLines(Bill, line);
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cf.Name = Drink2_label.Text;
        }
        private void change_informenu_Click(object sender, EventArgs e)
        {
            Change chang = new Change();
            chang.Show();
        }

        private void showitem_ItemActivate(object sender, EventArgs e)
        {

        }
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void size_box_SelectedValueChanged_1(object sender, EventArgs e)
        {
       
        }

        private void topping_box_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }
        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void GreenCha_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Price3_label_Click(object sender, EventArgs e)
        {

        }

        private void Drink2_label_Click(object sender, EventArgs e)
        {

        }

        private void Price4_label_Click(object sender, EventArgs e)
        {

        }

        private void Price5_label_Click(object sender, EventArgs e)
        {

        }

        private void Price1_label_Click(object sender, EventArgs e)
        {

        }

        private void Drink1_label_Click(object sender, EventArgs e)
        {

        }

        private void Drink3_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void panel6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void size_box_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Load_button_Click(object sender, EventArgs e)
        {

        }
        private void size_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void size_box_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void topping_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnelmenu_picture_Click(object sender, EventArgs e)
        {

        }

        private void pnelmenu_picture_Paint(object sender, PaintEventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void showitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
