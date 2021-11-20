using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace ChuongTrinhHocTapChoBe.Game.HungTaoHocToan
{
    public partial class HungTao : Form
    {
        public HungTao()
        {
            InitializeComponent();
            KhoiTaoGame();
        }

        #region Biến toàn cục
        int luot, diemSo, boLo, tocDoRoi;
        Random bienRand = new Random();
        bool quaTrai = false;
        bool quaPhai = false;
        bool gioCoApple = false;
        bool thua = false;
        public static bool formDong = false;
        SoundPlayer bgAudio;
        WindowsMediaPlayer roiAudio, bombAudio, ketThuc;
        string path, tenNguoiChoi;
        public static bool amThanh { get; set; }
        #endregion

        public void KhoiTaoGame()
        {
            //Âm thanh
            if (amThanh)
                choiAmThanh.Image = Properties.Resources.musicON;
            else choiAmThanh.Image = Properties.Resources.musicOFF;
            //Khởi tạo path
            path = Application.StartupPath;
            for (int i = 0; i < 4; i++)
            {
                path = Directory.GetParent(path).ToString();
            }
            diemSo = boLo = 0;
            luot = 0;
            tocDoRoi = 10;
            picTao2.Enabled = picTao3.Enabled = picTao4.Enabled = picTaoASP.Enabled = picBomb.Enabled = false;
            picTao2.Hide();
            picTao3.Hide();
            picTao4.Hide();
            picTaoASP.Hide();
            picBomb.Hide();
            thua = false;
            ViTriRoi(picTao1);
            picGio.Left = ClientSize.Width / 2;
            bgAudio = new SoundPlayer(); 
            roiAudio = new WindowsMediaPlayer();
            bombAudio = new WindowsMediaPlayer();
            bgAudio.SoundLocation = path + @"\Game\HungTaoHocToan\audio\bg.wav";
            if (amThanh)
                bgAudio.PlayLooping();
        }

        private void TroChoiChay_Tick(object sender, EventArgs e)
        {
            //Hiện số điểm và số vật phẩm bị bỏ qua trên màn hình chơi
            lbDiemSo.Text = "Điểm số: " + diemSo.ToString();
            lbBoLo.Text = "Bỏ lỡ: " + boLo.ToString();
            //Giỏ hàng thay đổi khi điểm số lớn hơn 0
            if ((diemSo == 5 || diemSo == 10) && gioCoApple == false)
            {
                picGio.Image.Dispose();
                picGio.Image = Properties.Resources.cartapple;
                gioCoApple = true;
            }
            else if (diemSo == 0 && gioCoApple == true)
            {
                picGio.Image.Dispose();
                picGio.Image = Properties.Resources.cart;
                gioCoApple = false;
            }
            //Giỏ hàng qua phải qua trái di chuyển
            if (quaTrai == true && picGio.Left >= 20)
            {
                picGio.Left -= 25;
            }
            if (quaPhai == true && picGio.Left < ClientSize.Width - picGio.Width - 20)
            {
                picGio.Left += 25;
            }
            foreach (Control picBox in this.Controls)
            {
                if (picBox is PictureBox && (string)picBox.Tag == "item")
                {
                    if (picBox.Enabled == true)
                    {
                        picBox.Top += tocDoRoi;
                        if (luot < 50)
                        {
                            if (luot == 3)
                            {
                                picTao2.Enabled = true;
                                ViTriRoi(picTao2);
                                picTao2.Show();
                            }
                            else if (luot == 1)
                            {
                                picTao3.Enabled = true;
                                picTao3.Show();
                                picBomb.Enabled = true;
                                picBomb.Show();
                                tocDoRoi = 10 + diemSo / (luot * 200);
                            }
                            else if (luot == 45)
                            {
                                picTao4.Enabled = true;
                                picTao4.Show();
                                picTaoASP.Enabled = true;
                                picTaoASP.Show();
                                tocDoRoi = 10 +  diemSo / (luot * 300);
                            }
                        } 
                        else
                        {
                            tocDoRoi = 10 + diemSo / (luot * 500);
                        }
                        if (picBox.Name == "picBomb" && (picBox.Top + picBox.Height + picBox.Height / 4 > this.ClientSize.Height))
                        {
                            if (amThanh)
                                bombAudio.URL = path + @"\Game\HungTaoHocToan\audio\bomb.mp3";
                            picBomb.Image.Dispose();
                            picBomb.Image = Properties.Resources.bomb;
                        }
                        else if (picBox.Name == "picBomb")
                        {
                            picBomb.Image.Dispose();
                            picBomb.Image = Properties.Resources.b;
                        }
                            if (picBox.Top + picBox.Height - picBox.Height / 2 > this.ClientSize.Height)
                        {

                            ViTriRoi(picBox);
                            if (picBox.Name != "picTaoASP" && picBox.Name != "picBomb")
                            {
                                if (amThanh)
                                    roiAudio.URL = path + @"\Game\HungTaoHocToan\audio\Roi.mp3";
                                boLo++;
                                if (diemSo >= 5)
                                {
                                    diemSo -= 5;
                                }
                                else
                                {
                                    diemSo = 0;
                                }
                            }
                        }
                        if (picGio.Bounds.IntersectsWith(picBox.Bounds))
                        {
                            ViTriRoi(picBox);
                            if (picBox.Name == "picTaoASP" || picBox.Name == "picBomb")
                            {
                                TroChoiChay.Stop();
                                HungTao_CauHoi cauHoi = new HungTao_CauHoi();
                                cauHoi.ShowDialog();
                                cauHoi.BringToFront();
                                if (HungTao_CauHoi.KetQua)
                                {
                                    if (picBox.Name == "picTaoASP")
                                    {
                                        diemSo += 20;
                                    }
                                }
                                else
                                {
                                    if (picBox.Name == "picBomb" && diemSo >= 10)
                                    {
                                        diemSo -= 10;
                                    }
                                }
                                quaTrai = false;
                                quaPhai = false;
                                cauHoi.Dispose();
                            }
                            else
                            {
                                diemSo += 10;
                            }
                        }
                    }
                } 
            }
            if (boLo >= 20)
            {
                thua = true;
                TroChoiChay.Stop();
                bgAudio.Stop();
                try
                {
                    tenNguoiChoi = Microsoft.VisualBasic.Interaction.InputBox("Hãy nhập tên của bạn vào khung nhập bên dưới để hệ thống có thể lưu và ghi bạn vào bảng thành tích.", "Nhập tên của bạn: ");
                    if (tenNguoiChoi == "")
                    {
                        tenNguoiChoi = "Người chơi ẩn danh";
                    }
                    if (File.Exists(path + @"\Game\HungTaoHocToan\player.txt"))
                    {
                        using (FileStream ghiFile = new FileStream(path + @"\Game\HungTaoHocToan\player.txt", FileMode.Append, FileAccess.Write))
                        {
                            StreamWriter ghiThem = new StreamWriter(ghiFile, Encoding.UTF8);
                            ghiThem.WriteLine(tenNguoiChoi + " " + diemSo.ToString());
                            ghiThem.Close();
                        }
                    }
                    else
                    {
                        using (FileStream ghiFile = new FileStream(path + @"\Game\HungTaoHocToan\player.txt", FileMode.Create, FileAccess.Write))
                        {
                            StreamWriter ghiThem = new StreamWriter(ghiFile, Encoding.UTF8);
                            ghiThem.WriteLine(tenNguoiChoi + " " + diemSo.ToString());
                            ghiThem.Close();
                        }
                    }

                }
                catch (IOException) { }
                if (amThanh)
                {
                    ketThuc = new WindowsMediaPlayer();
                    if (diemSo > 0)
                        ketThuc.URL = path + @"\Game\HungTaoHocToan\audio\thua1.wav";
                    else
                    {
                        ketThuc.URL = path + @"\Game\HungTaoHocToan\audio\thua2.wav";
                    }
                }
                if (MessageBox.Show(String.Format("Điểm số của bạn: {0}\nLượt chơi: {1}\nTên: {2} ", diemSo, luot, tenNguoiChoi), "Kết quả", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    KhoiTaoGame();
                }
                else
                {
                    formDong = true;
                    bgAudio.Stop();
                    this.Close();
                }
            }
        }
        private void TamDung_Tick(object sender, EventArgs e)
        {
            if (HungTao_CauHoi.ChoDoi == false && thua == false)
            {
                TroChoiChay.Start();
            }
        }

        private void HungTao_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgAudio.Stop();
            if (boLo < 20)
            {
                e.Cancel = true;
                boLo = 20;
                thua = true;
            }
            HungTao_TrangChu.amThanh = amThanh;
        }

        private void ViTriRoi(Control pic) //Sinh ngẫu nhiên vị trí của một vật phẩm rơi không bị chồng lấn vị trí của nhau
        {
            if (pic is PictureBox)
            {
                Rectangle temp;
                bool flag;
                do
                {
                    flag = false;
                    pic.Top = bienRand.Next(100, 380) * -1;
                    pic.Left = bienRand.Next(0, ClientSize.Width - pic.Width);
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && (string)x.Tag == "item")
                        {
                            if (x == pic)
                                continue;
                            temp = new Rectangle(x.Left, x.Top, x.Width, x.Height);
                            //Xử lý chồng lấn trái góc trên
                            if (temp.Contains(new Point(pic.Left, pic.Top)))
                            {
                                flag = false;
                                break;
                            }
                            //Xử lý chồng lấn góc trái dưới
                            if (temp.Contains(new Point(pic.Left, pic.Top + pic.Height)))
                            {
                                flag = false;
                                break;
                            }
                            //Xử lý chồng lấn góc phải trên
                            if (temp.Contains(new Point(pic.Left + pic.Width, pic.Top)))
                            {
                                flag = false;
                                break;
                            }
                            //Xử lý chồng lấn góc phải dưới
                            if (temp.Contains(new Point(pic.Left + pic.Width, pic.Top + pic.Height)))
                            {
                                flag = false;
                                break;
                            }
                            flag = true;
                        }
                    }
                } while (!flag);
                luot++;
            }
        }

        private void choiAmThanh_Click(object sender, EventArgs e)
        {
            if (amThanh)
            {
                choiAmThanh.Image.Dispose();
                choiAmThanh.Image = Properties.Resources.musicOFF;
                bgAudio.Stop();
                amThanh = false;
            }
            else
            {
                choiAmThanh.Image.Dispose();
                choiAmThanh.Image = Properties.Resources.musicON;
                bgAudio.PlayLooping();
                amThanh = true;
            }
        }


        //Xử lý di chuyển giỏ đựng
        private void HungTao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                quaTrai = false;
            if (e.KeyCode == Keys.Right)
                quaPhai = false;
        }
        private void HungTao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                quaTrai = true;
            if (e.KeyCode == Keys.Right)
                quaPhai = true;
        }

        //Xử lý phím tắt
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
