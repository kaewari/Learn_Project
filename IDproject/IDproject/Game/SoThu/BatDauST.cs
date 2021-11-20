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

namespace ChuongTrinhHocTapChoBe.Game.SoThu
{
    public partial class BatDauST : Form
    {
        public BatDauST()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        SoundPlayer nhac = new SoundPlayer(ChuongTrinhHocTapChoBe.Properties.Resources.nhacNen);
        bool xetATBD; 
        #endregion

        private void btBD_Click(object sender, EventArgs e)
        {
            SoThu f = new SoThu();
            f.xetAT = xetATBD;
            this.Hide();
            f.ShowDialog();
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

        private void BatDauST_Load(object sender, EventArgs e)
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

        private void BatDauST_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhac.Stop();
            Main.nhacNen = xetATBD;
        }
    }
}
