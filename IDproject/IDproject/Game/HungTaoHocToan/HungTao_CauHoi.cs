using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class HungTao_CauHoi : Form
    {
        public HungTao_CauHoi()
        {
            InitializeComponent();
        }

        public static bool KetQua { get; set; }
        public static bool ChoDoi { get; set; }
        int kq = 0;
        int luuKQ = 0;
        Random rand = new Random();
        char[] phepToan = { '+', '-' };

        private void HungTao_CauHoi_Load(object sender, EventArgs e)
        {
            int so1, so2;
            KetQua = false;
            ChoDoi = true;
            do
            {
                so1 = rand.Next(10);
                so2 = rand.Next(10);
            } while (so1 < so2);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            switch (phepToan[rand.Next(0, 2)])
            {
                case '+':
                    kq = so1 + so2;
                    lbPhepTinh.Text = "+";
                    break;
                case '-':
                    kq = so1 - so2;
                    lbPhepTinh.Text = "-";
                    break;
            }
            if (rand.Next(1, 3) == 1)
            {
                dapAn1.Text = kq.ToString();
                do
                {
                    dapAn2.Text = rand.Next(0, 18).ToString();
                } while (int.Parse(dapAn1.Text) == int.Parse(dapAn2.Text));
            }
            else
            {
                dapAn2.Text = kq.ToString();
                do
                {
                    dapAn1.Text = rand.Next(0, 18).ToString();
                } while (int.Parse(dapAn1.Text) == int.Parse(dapAn2.Text));
            }
            thoiGianTroi.Start();
        }


        private void dapAn_Click(object sender, EventArgs e)
        {
            thoiGianTroi.Stop();
            if (Convert.ToInt32(((Button)sender).Text) != kq)
            {
                lbGhiKQ.Text = "SAI RỒI";
                KetQua = false;
                luuKQ = 1;
            }
            else
            {
                if (luuKQ == 0)
                {
                    KetQua = true;
                }
                ChoDoi = false;
                this.Close();
                luuKQ = 0;
            }
        }

        private void thoiGianTroi_Tick(object sender, EventArgs e)
        {
            this.thanhQuaTrinh.Increment(1);
            if (this.thanhQuaTrinh.Value == this.thanhQuaTrinh.Maximum)
            {
                this.Close();
                KetQua = false;
                ChoDoi = false;
            }
        }

        private void HungTao_CauHoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChoDoi = false;
        }
    }
}
