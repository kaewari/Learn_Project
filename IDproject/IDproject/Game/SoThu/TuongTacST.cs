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

namespace ChuongTrinhHocTapChoBe.Game.SoThu
{
    public partial class TuongTacST : Form
    {
        public TuongTacST()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        public string gt, tl, kq, pd, ecb, path = " ";
        public int soAnh, min, max;
        string pathTT = Application.StartupPath + @"/DuLieu/"; 
        #endregion

        private void TuongTac_Load(object sender, EventArgs e)
        {
            lbCH.Text = gt;
            lbTL.Text = tl;
            lbDem.Text = pd;
            lbTT.Text = ecb;
            min = soAnh;
            max = soAnh + 2;
            path = Application.StartupPath + @"/Hinh/";
            try
            {
                pic.Image = Image.FromFile(path + soAnh + ".jpg");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không có ảnh");
            }
        }

        private void btAnh_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            soAnh = r.Next(min, max);
            try
            {
                pic.Image = Image.FromFile(path + soAnh + ".jpg");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không có ảnh");
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            lbKQ.Text = kq + txtKQ.Text + ".";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            Close();
        }
    }
}
