using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ChuongTrinhHocTapChoBe.Game.EchNhay
{
    public partial class echNhayChu : Form
    {
        public echNhayChu()
        {
            InitializeComponent();
        }
        #region Biến toàn cục
        string path = Application.StartupPath + @"/Hinh/";
        SoundPlayer nhacNen = new SoundPlayer(ChuongTrinhHocTapChoBe.Properties.Resources.nhacNenEN);
        string chu = " ";
        Random r = new Random();
        List<string> bcc = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        Button[] bt = new Button[26];
        int so, diem = 0, maAsc;
        public int flag;
        public bool xetAT;
        #endregion

        private void echNhayChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhacNen.Stop();
            Main.nhacNen = xetAT;
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLoa.Checked)
            {
                nhacNen.Stop();
                xetAT = false;
            }
            else
            {
                nhacNen.PlayLooping();
                xetAT = true;
            }
        }

        private void echNhayChu_Load(object sender, EventArgs e)
        {
            int top = 200, left = 500;
            for (int i = 0; i <= 25; i++)
            {
                bt[i] = new Button();
                bt[i].Name = "bt" + i;
                bt[i].Size = new Size(150, 150);
                bt[i].Font = new Font("Times New Roman", 22, FontStyle.Bold);
                bt[i].ForeColor = Color.Yellow;
                bt[i].BackgroundImage = Image.FromFile(path + "La.jpg");
                bt[i].BackgroundImageLayout = ImageLayout.Stretch;
                bt[i].FlatStyle = FlatStyle.Flat;
                bt[i].FlatAppearance.BorderSize = 0;
                bt[i].Top = top;
                bt[i].Left = left;
                so = r.Next(bcc.Count);
                chu = bcc[so];
                bt[i].Text = chu;
                bcc.RemoveAt(so);
                bt[i].Click += new EventHandler(bt_click);
                this.Controls.Add(bt[i]);
                left += 150;
                if (i == 6 || i == 13 || i == 20)
                {
                    top += 150;
                    left = 500;
                }
            }
            if (flag == 1)
            {
                maAsc = 90;
            }
            else
            {
                maAsc = 65;
            }
            if (xetAT)
            {
                nhacNen.PlayLooping();
                ckLoa.Checked = false;
            }
            else
            {
                nhacNen.Stop();
                ckLoa.Checked = true;
            }
        }

        private void bt_click(object sender, EventArgs e)
        {
            Button btNhan = (Button)sender;
            picEch.Top = btNhan.Top;
            picEch.Left = btNhan.Left;
            if (Convert.ToChar(btNhan.Text) == Convert.ToChar(maAsc))
            {
                diem += 5;

                btNhan.Dispose();
                if (diem == 130)
                {
                    if (MessageBox.Show("Bạn có muốn chơi tiếp không? \nĐiểm của bạn: " + diem, "TUYỆT! BẠN ĐÃ HOÀN THÀNH TRÒ CHƠI", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        BatDauEN f = new BatDauEN();
                        f.xetATBD = xetAT; 
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        Close();
                    }
                }
                lbDiem.Text = diem.ToString();
                if (flag == 1)
                {
                    maAsc--;
                }
                else
                {
                    maAsc++;
                }
            }
            else
            {
                picEch.Image = Image.FromFile(path + "nuoc.jpg");
                SoundPlayer amThanh = new SoundPlayer(ChuongTrinhHocTapChoBe.Properties.Resources.flop);
                amThanh.Play();
                if (MessageBox.Show("Nhảy sai rồi! Bạn có muốn chơi lại? \nĐiểm của bạn: " + diem, "BẠN ĐÃ THUA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    BatDauEN f = new BatDauEN();
                    f.xetATBD = xetAT;
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
