using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChuongTrinhHocTapChoBe.Class;
using ChuongTrinhHocTapChoBe.Game;
using System.IO;
using WMPLib;
using System.Media;
using System.Threading;

namespace ChuongTrinhHocTapChoBe.Game.DuaXeHocTiengAnh
{
    public partial class DuaXe : Form
    {
        public DuaXe()
        {
            InitializeComponent();
            KhoiTaoGame();
        }
        #region Biến toàn cục
        string tenNguoiChoi;
        Random rand = new Random();
        int[] viTri = { 13, 237, 459 };
        int[] coGiaTri = { 0, 0, 0 };
        int diemSo, luotChoi, soKM;
        String[] cacLoaiXe = { "yellow", "red", "nearblack", "gray" };
        const int soLanXe = 3;
        bool duocBound = false;
        string path;
        SoundPlayer bgAudio;
        WindowsMediaPlayer ketThuc, tongXe;
        string urlKetThuc, urlTongXe;
        public static bool daDong { get; set; }
        #endregion
        #region Biến trạng thái
        public static int[] luuCauHoi { get; set; }
        public static bool amThanh { get; set; }
        #endregion
        private void KhoiTaoGame()
        {
            //Đọc trạng thái âm thanh
            amThanh = DuaXe_TrangChu.amThanh;
            tenNguoiChoi = "temp";
            if (amThanh)
            {
                picMusic.Image = Properties.Resources.musicON;
            }
            else
            {
                picMusic.Image = Properties.Resources.musicOFF;
            }
            daDong = false;
            diemSo = luotChoi = soKM = 0;
            //Trả giá trị mặc định
            for (int i = 0; i < coGiaTri.Length; i++)
            {
                coGiaTri[i] = 0;
            }
            lbDiemSo.Text = diemSo.ToString();
            lbLuotChoi.Text = soKM.ToString();
            MauXe(picGame1);
            MauXe(picGame2);
            LuaChonViTriChoi();
            //Đưa địa chỉ về thư mục gốc
            path = Application.StartupPath;
            for (int dem = 0; dem < 4; dem++)
            {
                path = Directory.GetParent(path).ToString();
            }
            //Đọc số lượng câu hỏi
            using (FileStream doiTuongStream1 = new FileStream(path + @"\Game\DuaXeHocTiengAnh\question.txt", FileMode.Open))
            {
                StreamReader strm1 = new StreamReader(doiTuongStream1, Encoding.UTF8);
                //Đọc số lượng câu hỏi có trong kho câu hỏi
                luuCauHoi = new int[int.Parse(strm1.ReadLine())];
                for (int i = 0; i < luuCauHoi.Length; i++)
                {
                    luuCauHoi[i] = 0;
                }
                strm1.Close();
            }
            bgAudio = new SoundPlayer();
            ketThuc = new WindowsMediaPlayer();
            tongXe = new WindowsMediaPlayer();
            bgAudio.SoundLocation = path + @"\Game\DuaXeHocTiengAnh\sound\bg.wav";
            urlKetThuc = path + @"\Game\DuaXeHocTiengAnh\sound\ketThuc.wav";
            urlTongXe = path + @"\Game\DuaXeHocTiengAnh\sound\tongXe.wav";
            if (amThanh)
                bgAudio.PlayLooping();
            TroChoiChay.Start();
        }

        private void TroChoiChay_Tick(object sender, EventArgs e)
        {
            soKM++;
            lbDiemSo.Text = diemSo.ToString();
            lbLuotChoi.Text = soKM.ToString();
            foreach (Control pic in pnDuong.Controls)
            {
                if ((pic is PictureBox && (string)pic.Tag == "itemcar") || (pic is Label))
                {
                    pic.Top += 10;
                }
                if (pic.Top > ClientSize.Height)
                {
                    if (pic is Label)
                    {
                        pic.Top = - pic.Height;
                    }
                    else if ((string)pic.Tag == "itemcar") 
                    {
                        int ob = int.Parse(StringCustom.SubstringRight(pic.Name, 1));
                        coGiaTri[ob] = 0;
                        MauXe(pic);
                        LuaChonViTriChoi(pic);
                    }
                }
                if (pic != picMy)
                {
                    if (picMy.Bounds.IntersectsWith(pic.Bounds) && !duocBound)
                    {
                        luotChoi++;
                        bgAudio.Stop();
                        duocBound = true;
                        TroChoiChay.Stop();
                        DuaXe_CauHoi cauHoi = new DuaXe_CauHoi();
                        cauHoi.ShowDialog();
                        cauHoi.BringToFront();
                        if (DuaXe_CauHoi.traLoiDung)
                        {
                            diemSo += 10;
                            if (!DuaXe_CauHoi.choDoi)
                                XeCuaToiRe();
                        }
                        else
                        {
                            if (amThanh)
                                tongXe.URL = urlTongXe;
                            int ob = int.Parse(StringCustom.SubstringRight(pic.Name, 1));
                            coGiaTri[ob] = 0;
                            MauXe(pic);
                            LuaChonViTriChoi(pic);
                        } 
                        if (!DuaXe_CauHoi.choDoi)
                        {
                            TroChoiChay.Start();
                            if (amThanh)
                                bgAudio.PlayLooping();
                        }
                        duocBound = false;
                    }
                }
            }
            if (luotChoi == 10)
            {
                TroChoiChay.Stop();
                bgAudio.Stop();
                try
                {
                    tenNguoiChoi = Microsoft.VisualBasic.Interaction.InputBox("Hãy nhập tên của bạn vào khung nhập bên dưới để hệ thống có thể lưu và ghi bạn vào bảng thành tích.", "Nhập tên của bạn: ");
                    if (tenNguoiChoi == "")
                    {
                        tenNguoiChoi = "Người chơi ẩn danh";
                    }
                    if (File.Exists(path + @"\Game\DuaXeHocTiengAnh\player.txt"))
                    {
                        using (FileStream ghiFile = new FileStream(path + @"\Game\DuaXeHocTiengAnh\player.txt", FileMode.Append, FileAccess.Write))
                        {
                            StreamWriter ghiThem = new StreamWriter(ghiFile, Encoding.UTF8);
                            ghiThem.WriteLine(tenNguoiChoi + " " + diemSo.ToString() + " " + soKM.ToString());
                            ghiThem.Close();
                        }
                    }
                    else
                    {
                        using (FileStream ghiFile = new FileStream(path + @"\Game\DuaXeHocTiengAnh\player.txt", FileMode.Create, FileAccess.Write))
                        {
                            StreamWriter ghiThem = new StreamWriter(ghiFile, Encoding.UTF8);
                            ghiThem.WriteLine(tenNguoiChoi + " " + diemSo.ToString() + " " + soKM.ToString());
                            ghiThem.Close();
                        }
                    }
                    
                }
                catch (IOException) {  }
                if (amThanh)
                    ketThuc.URL = urlKetThuc;
                if (MessageBox.Show(String.Format("Điểm số của bạn: {0}/100\nQuãng đường đi được: {1}m\nTên: {2}", diemSo, soKM, tenNguoiChoi), "Kết quả", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    KhoiTaoGame();
                }
                else this.Close();
            }
        }

        private void DuaXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgAudio.Stop();
            if (luotChoi < 10)
            {
                e.Cancel = true;
                luotChoi = 10;
            }
        }

        private void DuaXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            daDong = true;
            DuaXe_TrangChu.amThanh = amThanh;
        }

        private void picMusic_Click(object sender, EventArgs e)
        {
            if(amThanh) //thì tắt âm
            {
                picMusic.Image.Dispose();
                picMusic.Image = Properties.Resources.musicOFF;
                bgAudio.Stop();
                amThanh = false;
            }
            else //thì bật âm
            {
                picMusic.Image.Dispose();
                picMusic.Image = Properties.Resources.musicON;
                bgAudio.PlayLooping();
                amThanh = true;
            }
        }

        private void LuaChonViTriChoi()
        {
            int soNgauNhien = -1;
            //Cho vị trí
            foreach (Control pic in pnDuong.Controls)
            {
                if (pic is PictureBox && (string)pic.Tag == "itemcar")
                {
                    pic.Top = rand.Next(270, 500) * -1;
                    do
                    {
                        soNgauNhien = rand.Next(soLanXe);
                        if (coGiaTri[soNgauNhien] == 0)
                        {
                            pic.Left = viTri[soNgauNhien];
                            coGiaTri[soNgauNhien] = 1;
                            pic.Name = "picGame" + soNgauNhien.ToString();
                            break;
                        }
                    } while (true);
                }
            }
        }
        private void XeCuaToiRe()
        {
            int soNgauNhien = -1;
            do
            {
                soNgauNhien = rand.Next(soLanXe);
                if (coGiaTri[soNgauNhien] == 0)
                {
                    picMy.Left = viTri[soNgauNhien];
                    break;
                }
            } while (true);
        }
        private void LuaChonViTriChoi(Control pic)
        {
            int soNgauNhien = -1;
            if (pic is PictureBox && (string)pic.Tag == "itemcar")
            {
                pic.Top = rand.Next(270, 380) * -1;
                do
                {
                    soNgauNhien = rand.Next(soLanXe);
                    if (coGiaTri[soNgauNhien] == 0)
                    {
                        pic.Left = viTri[soNgauNhien];
                        coGiaTri[soNgauNhien] = 1;
                        pic.Name = "picGame" + soNgauNhien.ToString();
                        break;
                    }
                } while (true);
            }
        }
        private void MauXe(Control pic)
        {
            //String[] cacLoaiXe = { "yellow", "red", "nearblack", "gray" };
            if (pic is PictureBox)
            {
                PictureBox temp = (PictureBox)pic;
                int chonXe = rand.Next(0, 4);
                temp.Image.Dispose();
                switch (chonXe)
                {
                    case 0:
                        temp.Image = Properties.Resources.yellow;
                        break;
                    case 1:
                        temp.Image = Properties.Resources.red;
                        break;
                    case 2:
                        temp.Image = Properties.Resources.nearblack;
                        break;
                    case 3:
                        temp.Image = Properties.Resources.gray;
                        break;
                }
            }
            
        }
    }
}
