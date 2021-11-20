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
    public partial class BatDauEN : Form
    {
        public BatDauEN()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        SoundPlayer nhac = new SoundPlayer(ChuongTrinhHocTapChoBe.Properties.Resources.nhacNenEN);
        public bool xetATBD;
        #endregion

        private void BatDauEN_Load(object sender, EventArgs e)
        {
            if (Main.nhacNen == true)
            {
                nhac.PlayLooping();
                ckLoa.Checked = false;
                xetATBD = true;
            }
            else
            {
                nhac.Stop();
                ckLoa.Checked = true;
                xetATBD = false;
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.Text)
            {
                case "Nhân":
                    echNhaySo f1 = new echNhaySo();
                    f1.so = Convert.ToInt32(numSo.Value);
                    f1.xetAT = xetATBD;
                    this.Hide();
                    f1.ShowDialog();
                    break;
                case "Chia":
                    echNhaySo f2 = new echNhaySo();
                    f2.so = Convert.ToInt32(numSo.Value);
                    f2.xetAT = xetATBD;
                    f2.flag = 1;
                    this.Hide();
                    f2.ShowDialog();
                    break;
                case "A - Z":
                    echNhayChu f3 = new echNhayChu();
                    f3.xetAT = xetATBD;
                    this.Hide();
                    f3.ShowDialog();
                    break;
                case "Z - A":
                    echNhayChu f4 = new echNhayChu();
                    f4.flag = 1;
                    f4.xetAT = xetATBD;
                    this.Hide();
                    f4.ShowDialog();
                    break;
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLoa.Checked)
            {
                nhac.Stop();
                xetATBD = false;
            }
            else
            {
                nhac.PlayLooping();
                xetATBD = true;
            }
        }

        private void BatDauEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhac.Stop();
            Main.nhacNen = xetATBD;
        }
    }
}
