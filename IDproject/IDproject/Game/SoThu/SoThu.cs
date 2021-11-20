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
using System.IO;

namespace ChuongTrinhHocTapChoBe.Game.SoThu
{
    public partial class SoThu : Form
    {
        public SoThu()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        string path = Application.StartupPath + @"/DuLieu/";
        string pathAT = Application.StartupPath + @"/Nhac/";
        string dong;
        string[] chuoi;
        TuongTacST f = new TuongTacST();
        SoundPlayer nhac = new SoundPlayer(ChuongTrinhHocTapChoBe.Properties.Resources.nhacNen);
        public bool xetAT;
        #endregion

        private void btVoi_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (File.Exists(path + "CauHoi.txt"))
            {
                StreamReader docFile = new StreamReader(path + "CauHoi.txt");
                for (int i = 1; i <= 23; i += 2)
                {
                    dong = docFile.ReadLine();
                    chuoi = dong.Split('.');
                    if (chuoi[0] == bt.Text)
                    {
                        f.soAnh = i;
                        f.gt = chuoi[1];
                        f.tl = chuoi[2];
                        f.kq = chuoi[3];
                        f.pd = chuoi[4];
                        f.ecb = chuoi[5];
                        SoundPlayer amThanh = new SoundPlayer(pathAT + i + ".wav");
                        amThanh.Play();
                        break;
                    }  
                }
                f.ShowDialog();
                nhac.PlayLooping();
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

        private void SoThu_Load(object sender, EventArgs e)
        {
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
        }

        private void SoThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhac.Stop();
            Main.nhacNen = xetAT;
        }
    }
}
