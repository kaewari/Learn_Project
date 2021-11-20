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
    public partial class echNhaySo : Form
    {
        public echNhaySo()
        {
            InitializeComponent();
        }

        string path = Application.StartupPath + @"/Hinh/";
        SoundPlayer nhac = new SoundPlayer(ChuongTrinhHocTapChoBe.Properties.Resources.nhacNenEN);
        Random r = new Random();
        public int so, flag;
        public bool xetAT;
        int diem = 0, heSo = 1;
        Button[,] bt = new Button[2, 10];

        private void echNhaySo_Load(object sender, EventArgs e)
        {
            int top = 370;
            for (int i = 0; i <= 1; i++)
            {
                int left = 200;
                int max = so + 1, min = so - 1;
                for (int j = 0; j <= 9; j++)
                {
                    bt[i, j] = new Button();
                    bt[i, j].Name = string.Format("bt{0}{1}", i, j);
                    bt[i, j].Size = new Size(170, 170);
                    bt[i, j].Font = new Font("Times New Roman", 22, FontStyle.Bold);
                    bt[i, j].ForeColor = Color.Yellow;
                    bt[i, j].Text = r.Next(min, max).ToString();
                    if (i == 1 && Convert.ToInt32(bt[i, j].Text) == Convert.ToInt32(bt[i - 1, j].Text))
                    {
                        int tam = Convert.ToInt32(bt[i, j].Text);
                        bt[i - 1, j].Text = (tam + 1).ToString();
                    }
                    bt[i, j].BackgroundImage = Image.FromFile(path + "La.jpg");
                    bt[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    bt[i, j].FlatStyle = FlatStyle.Flat;
                    bt[i, j].FlatAppearance.BorderSize = 0;
                    bt[i, j].Top = top;
                    bt[i, j].Left = left;
                    bt[i, j].Click += new EventHandler(bt_click);
                    this.Controls.Add(bt[i, j]);
                    left += 170;
                    min += so;
                    max += so;
                }
                top += 170;
            }
            if (xetAT)
            {
                nhac.PlayLooping();
                ckLoa.Checked = false;
            }
            else
            {
                nhac.Stop();
                ckLoa.Checked = true;
            }
            if (flag == 1)
            {
                lb2.Text = so.ToString();
                lbKQ.Text = heSo.ToString();
                lbDau.Text = ":";
            }
            else
            {
                lb1.Text = so.ToString();
                lb2.Text = heSo.ToString();
                lbDau.Text = "x";
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLoa.Checked)
            {
                nhac.Stop();
                xetAT = false;
            }
            else
            {
                nhac.PlayLooping();
                xetAT = true;
            }
        }

        private void echNhaySo_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhac.Stop();
            Main.nhacNen = xetAT;
        }

        private void bt_click(object sender, EventArgs e)
        {
            Button btNhan = (Button)sender;
            picEch.Top = btNhan.Top;
            picEch.Left = btNhan.Left;
            if ((so * heSo) == Convert.ToInt32(btNhan.Text))
            {
                diem += 5;
                lbDiem.Text = diem.ToString();
                heSo++;
                if (diem == 50)
                {
                    lb2.Text = "10";
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
                if (flag == 1)
                {
                    lbKQ.Text = heSo.ToString();
                }
                else
                {
                    lb2.Text = heSo.ToString();
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
