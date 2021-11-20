using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChuongTrinhHocTapChoBe.Class;
using WMPLib;
using System.Media;
using System.Threading;

namespace ChuongTrinhHocTapChoBe.Game.DuaXeHocTiengAnh
{
    public partial class DuaXe_CauHoi : Form
    {
        public DuaXe_CauHoi()
        {
            InitializeComponent();
        }
        #region CauHoi
        string[] cauHoi;
        string[] dapAn1;
        string[] dapAn2;
        string[] dapAn3;
        string[] dapAn4;
        int soLuong;
        #endregion
        #region Biến toàn cục
        public static bool traLoiDung { get; set; }
        public static bool choDoi { get; set; }
        Random bienRand = new Random();
        int dapAnDung = 0;
        int loaiThoat;  //-1 tự thoát
        /// </summary>
        string path;
        SoundPlayer bg = new SoundPlayer();
        WindowsMediaPlayer amThanhDung;
        string urlDung;
        #endregion

        private void DuaXe_CauHoi_Load(object sender, EventArgs e)
        {
            choDoi = true;
            traLoiDung = false;
            loaiThoat = -1;
            //Đưa địa chỉ về thư mục gốc
            path = Application.StartupPath;// = Directory.GetParent(Application.StartupPath.ToString()).ToString();
            for (int dem = 0; dem < 4; dem++)
            {
                path = Directory.GetParent(path).ToString();
            }
            //Tạo đối tượng đọc từ file
            using (FileStream doiTuongStream = new FileStream(path + @"\Game\DuaXeHocTiengAnh\question.txt", FileMode.Open))
            {
                StreamReader strm = new StreamReader(doiTuongStream, Encoding.UTF8);
                //Đọc số lượng câu hỏi có trong kho câu hỏi
                soLuong = int.Parse(strm.ReadLine());
                cauHoi = new string[soLuong];
                dapAn1 = new string[soLuong];
                dapAn2 = new string[soLuong];
                dapAn3 = new string[soLuong];
                dapAn4 = new string[soLuong];
                //Lưu đáp án vào mảng một chiều khi chạy
                int i = 0;
                while (!strm.EndOfStream)
                {
                    cauHoi[i] = strm.ReadLine();
                    string ghiDongDapAn = strm.ReadLine();
                    ghiDongDapAn = ghiDongDapAn.Substring(1);
                    string[] dapAn = ghiDongDapAn.Split("*");
                    dapAn1[i] = dapAn[0];
                    dapAn2[i] = dapAn[1];
                    dapAn3[i] = dapAn[2];
                    dapAn4[i] = dapAn[3];
                    i++;
                }
            }
            btnDapAn1.Text = btnDapAn2.Text = btnDapAn3.Text = btnDapAn4.Text = "";
            bg.SoundLocation = path + @"\Game\DuaXeHocTiengAnh\sound\dangCho.wav";
            if (DuaXe.amThanh)
                bg.Play();
            amThanhDung = new WindowsMediaPlayer();
            urlDung = path + @"\Game\DuaXeHocTiengAnh\sound\correct.wav";
            MoCauHoi();
        }
        private void MoCauHoi()
        {
            do
            {
                int soCauHoi = bienRand.Next(soLuong);
                if (DuaXe.luuCauHoi[soCauHoi] == 0)
                {
                    lbCauHoi.Text = cauHoi[soCauHoi];
                    string[] viTriDapAn = new string[4];
                    viTriDapAn[0] = dapAn1[soCauHoi];
                    viTriDapAn[1] = dapAn2[soCauHoi];
                    viTriDapAn[2] = dapAn3[soCauHoi];
                    viTriDapAn[3] = dapAn4[soCauHoi];
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Button && (string)ctrl.Tag == "dapAn")
                        {
                            do
                            {
                                int soViTriSinh = bienRand.Next(4);
                                if (viTriDapAn[soViTriSinh] != "")
                                {
                                    if (soViTriSinh == 0)
                                    {
                                        dapAnDung = int.Parse(StringCustom.SubstringRight(ctrl.Name, 1));
                                    }    
                                    ctrl.Text = viTriDapAn[soViTriSinh];
                                    viTriDapAn[soViTriSinh] = "";
                                    break;
                                }
                            } while (true);
                        }
                    }
                    DuaXe.luuCauHoi[soCauHoi] = 1;
                    break;
                }
            } while (true);
        }

        private void ChonDapAn(object sender, EventArgs e)
        {
            int dapAnNguoiChoiChon = int.Parse(StringCustom.SubstringRight(((Button)sender).Name, 1));
            if (dapAnNguoiChoiChon == dapAnDung)
            {
                if (DuaXe.amThanh)
                    amThanhDung.URL = urlDung;
                traLoiDung = true;
            }
            else
            {
                traLoiDung = false;
            }
            loaiThoat = 0;
            Thread.Sleep(200);
            choDoi = false;
            bg.Stop();
            this.Close();
        }

        private void thoiGianCho_Tick(object sender, EventArgs e)
        {
            this.thanhQuaTrinh.Increment(1);
            if (this.thanhQuaTrinh.Value == this.thanhQuaTrinh.Maximum)
            {
                loaiThoat = 0;
                traLoiDung = false;
                choDoi = false;
                this.Close();
            }
        }

        private void DuaXe_CauHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            choDoi = false;
            if (loaiThoat == -1)
            {
                if (MessageBox.Show("Nếu như bỏ qua, bạn sẽ bị đánh thua.\nBạn có thực sự muốn bỏ qua câu này?", "Bỏ qua", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
