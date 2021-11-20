using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChuongTrinhHocTapChoBe.Game;
using ChuongTrinhHocTapChoBe.Class;
using System.IO;

namespace ChuongTrinhHocTapChoBe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static bool nhacNen { get; set; } //âm nhạc lưu lại có bật hay không
        public static string licensedName{ get; set; } //tên người mua bản quyền
        INI loadINI = new INI(Application.StartupPath + "\\Data\\LRN.ini");
        string section = "Bo tro choi cho tre em - Team19 OU";
        parentpass nhapPass;
        #region Phần settings
        ////Phần settings
        HScrollBar thanhNhacNen = new HScrollBar();
        Label nhacNenCoHayKhong = new Label();
        Label giaTriBatTat = new Label();
        //Chỉnh sửa license
        Label suaLicense = new Label();
        TextBox maLicense = new TextBox();
        Button kiemTraLicense = new Button();

        ////Trang thai ban quyền
        Label banQuyen = new Label();
        Label giaTriBanQuyen = new Label();
        Button muaBanQuyen = new Button();

        //Đặt pass ứng dụng
        Label parentpass1 = new Label();
        Button pass = new Button();

        //
        #endregion
        private void Main_Load(object sender, EventArgs e)
        {
            //Đọc âm nhạc có mở hay không?
            if (loadINI.Read("Volume", section) == "On")
            {
                nhacNen = true;
            }
            else
            {
                nhacNen = false;
            }
            if (loadINI.Read("lock", section) != "")
            {
                this.Hide(); 
                nhapPass = new parentpass();
                xetPass.Start();
                xetPass.Enabled = true;
                nhapPass.ShowDialog();
                nhapPass.BringToFront();
            }
        }

        private void picBangVe_Click(object sender, EventArgs e)
        {
            BangVeTreEm chayChuongTrinh = new BangVeTreEm();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        } 

        private void picDuaXe_Click(object sender, EventArgs e)
        {
            Game.DuaXeHocTiengAnh.DuaXe_TrangChu chayChuongTrinh = new Game.DuaXeHocTiengAnh.DuaXe_TrangChu();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        } 

        private void picEchNhay_Click(object sender, EventArgs e)
        {
            Game.EchNhay.BatDauEN chayChuongTrinh = new Game.EchNhay.BatDauEN();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        }

        private void picDoanHinh_Click(object sender, EventArgs e)
        {
            Game.GameChonHinh chayChuongTrinh = new Game.GameChonHinh();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        }

        private void picLatHinh_Click(object sender, EventArgs e)
        {
            Game.GameLatHinh chayChuongTrinh = new Game.GameLatHinh();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        }

        private void picDiSoThu_Click(object sender, EventArgs e)
        {
            Game.SoThu.BatDauST chayChuongTrinh = new Game.SoThu.BatDauST();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        }

        private void picHungTao_Click(object sender, EventArgs e)
        {
            Game.HungTaoHocToan.HungTao_TrangChu chayChuongTrinh = new Game.HungTaoHocToan.HungTao_TrangChu();
            chayChuongTrinh.StartPosition = FormStartPosition.CenterScreen;
            chayChuongTrinh.ShowDialog();
        } 

        private void picCaiDat_Click(object sender, EventArgs e)
        {
            if (pnUngDung.Enabled)
            {
                pnUngDung.Enabled = false;
                pnUngDung.Hide();
                CaiDatShow();
            }
        }

        private void CaiDatShow()
        {
            if (!pnUngDung.Enabled)
            {
                PictureBox logoGroup = new PictureBox();
                Label tenGroup = new Label();

                //pic Back
                PictureBox picBack;
                picBack = new PictureBox();

                Control[] nhomSet = new Control[] { muaBanQuyen, nhacNenCoHayKhong, thanhNhacNen, giaTriBatTat, suaLicense, maLicense, kiemTraLicense, parentpass1, pass, banQuyen, giaTriBanQuyen, logoGroup, tenGroup, picBack};
                foreach (Control ctrl in nhomSet)
                {
                    ctrl.Enabled = true;
                    ctrl.Show();
                }
                //logo group phát triển
                logoGroup.Location = new Point(50, 10);
                logoGroup.Image = Properties.Resources.main;
                logoGroup.SizeMode = PictureBoxSizeMode.StretchImage;
                logoGroup.Size = new Size(315, 315);
                tenGroup.Text = "Lập Trình Giao Diện (IT91)\nTiến - Sơn - Tuyên";
                tenGroup.ForeColor = Color.Black;
                tenGroup.BringToFront();
                tenGroup.Font = new Font("Arial", 12, FontStyle.Bold);
                tenGroup.Location = new Point(90 ,355);
                tenGroup.TextAlign = ContentAlignment.MiddleCenter;
                tenGroup.AutoSize = true;
                //Tùy chỉnh nhạc nền bật hoặc tắt
                //Enable
                //nhacNenCoHayKhong.Enabled = thanhNhacNen.Enabled = giaTriBatTat.Enabled =
                //    suaLicense.Enabled = maLicense.Enabled = kiemTraLicense.Enabled = banQuyen.Enabled = giaTriBanQuyen.Enabled =
                //    parentpass.Enabled = pass.Enabled = true;
                //
                //nhãn Nhạc nền
                nhacNenCoHayKhong.Text = "Nhạc nền";
                nhacNenCoHayKhong.Font = new Font("Arial", 12);
                nhacNenCoHayKhong.Location = new Point(this.ClientRectangle.Right - 520, 45);
                //thanh nhạc nền
                thanhNhacNen.Minimum = 0;
                thanhNhacNen.Maximum = 100;
                thanhNhacNen.LargeChange = 50;
                thanhNhacNen.Height = 30;
                thanhNhacNen.Width = this.ClientRectangle.Width / 4;
                thanhNhacNen.ValueChanged += ThanhNhacNen_ValueChanged;
                thanhNhacNen.Location = new Point(nhacNenCoHayKhong.Left + 25 + nhacNenCoHayKhong.Width, nhacNenCoHayKhong.Top);
                //nhãn kq bật tắt
                if (nhacNen)
                {
                    giaTriBatTat.ForeColor = Color.Green;
                    thanhNhacNen.Value = 100;
                    giaTriBatTat.Text = "Bật";
                }
                else
                {
                    thanhNhacNen.Value = 0;
                    giaTriBatTat.ForeColor = Color.Red;
                    giaTriBatTat.Text = "Tắt";
                }
                giaTriBatTat.Font = new Font("Arial", 12, FontStyle.Bold);
                giaTriBatTat.Click += GiaTriBatTat_Click;
                giaTriBatTat.Location = new Point(thanhNhacNen.Left + 25 + thanhNhacNen.Width, nhacNenCoHayKhong.Top);

                //Chỉnh sửa license
                //Label suaLicense = new Label();
                //TextBox maLicense = new TextBox();
                //Button kiemTraLicense = new Button();
                //nhãn sửa license
                suaLicense.Text = "Bản quyền";
                suaLicense.AutoSize = true;
                suaLicense.Font = new Font("Arial", 12);
                suaLicense.Location = new Point(this.ClientRectangle.Right - 520, 145);
                //chỗ nhập mã
                maLicense.Font = new Font("Arial", 12, FontStyle.Strikeout);
                maLicense.Location = new Point(suaLicense.Left + 25 + suaLicense.Width, suaLicense.Top);
                maLicense.Width = 250;
                maLicense.PlaceholderText = "Nhập mã bản quyền";
                maLicense.MaxLength = 19;
                maLicense.TextAlign = HorizontalAlignment.Center;
                //kiểm tra khả dụng của mã
                kiemTraLicense.Text = "Kiểm tra";
                kiemTraLicense.Location = new Point(maLicense.Left + 25 + maLicense.Width, suaLicense.Top);
                kiemTraLicense.Font = new Font("Arial", 12);
                kiemTraLicense.Click += KiemTraLicense_Click;
                kiemTraLicense.AutoSize = true;


                ////Trang thai ban quyền
                //Label banQuyen = new Label();
                //Label giaTriBanQuyen = new Label();
                banQuyen.Text = "Trạng thái bản quyền";
                banQuyen.Width = 200;
                banQuyen.AutoSize = false;
                banQuyen.Font = new Font("Arial", 12);
                banQuyen.Location = new Point(this.ClientRectangle.Right - 520, 245);

                giaTriBanQuyen.Location = new Point(banQuyen.Left + 10 + banQuyen.Width, banQuyen.Top);
                KiemTraLicenseHienTai(giaTriBanQuyen);
                giaTriBanQuyen.Font = new Font("Arial", 12);
                giaTriBanQuyen.AutoSize = false;
                giaTriBanQuyen.Width = 200;

                //Login bản quyền
                muaBanQuyen.Text = "Mua";
                muaBanQuyen.Location = new Point(giaTriBanQuyen.Left + 10 + giaTriBanQuyen.Width, banQuyen.Top);
                muaBanQuyen.Font = new Font("Arial", 12);
                muaBanQuyen.AutoSize = true;
                muaBanQuyen.Click += MuaBanQuyen_Click;


                ////Đặt pass ứng dụng
                //Label parentpass = new Label();
                //Button pass = new Button();
                //nhãn đặt pass
                parentpass1.Text = "Bảo mật phụ huynh";
                parentpass1.Font = new Font("Arial", 12);
                parentpass1.Location = new Point(this.ClientRectangle.Right - 520, 345);
                parentpass1.Width = 200;
                //Button chuyển hướng đặt pass

                pass.Text = "Thay đổi mật mã";
                pass.Location = new Point(parentpass1.Left + 25 + parentpass1.Width, parentpass1.Top);
                pass.Font = new Font("Arial", 12);
                pass.Click += Pass_Click;
                pass.AutoSize = true;
                pass.Width = 250;

                //nut Back lại trang chủ
                picBack.Size = new Size(40, 40);
                picBack.Location = new Point(this.ClientRectangle.Right - 300, this.ClientRectangle.Bottom - 60);
                picBack.Image = Properties.Resources.back;
                picBack.SizeMode = PictureBoxSizeMode.StretchImage;
                picBack.Click += PicBack_Click;

                //Thêm tất cả control vào
                this.Controls.AddRange(nhomSet);
            }
        }

        private void MuaBanQuyen_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.ShowDialog();
            newLogin.BringToFront();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Hide();
                ctrl.Enabled = false;
            }
            pnUngDung.Enabled = true;
            pnUngDung.Show();
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            parentpass doiPassMoi = new parentpass();
            doiPassMoi.doiPass = true;
            doiPassMoi.ShowDialog();
        }

        private void KiemTraLicense_Click(object sender, EventArgs e)
        {
            if (KiemTraLicense(maLicense.Text))
            {
                loadINI.Write("license", maLicense.Text, section);
                MessageBox.Show("Nhập bản quyền thành công.\nKhởi động lại cài đặt để áp dụng thay đổi.");
            }
            else
            {
                MessageBox.Show("Mã không khả dụng.");
            }
            return;
        }

        private void GiaTriBatTat_Click(object sender, EventArgs e)
        {
            if (giaTriBatTat.Text == "Bật")
            {
                giaTriBatTat.Text = "Tắt";
                giaTriBatTat.ForeColor = Color.Red;
                thanhNhacNen.Value = 0;
                nhacNen = false;
            }
            else
            {
                giaTriBatTat.Text = "Bật";
                giaTriBatTat.ForeColor = Color.Green;
                thanhNhacNen.Value = 100;
                nhacNen = true;
            }
        }

        private void ThanhNhacNen_ValueChanged(object sender, EventArgs e)
        {
            if (thanhNhacNen.Value < 50)
            {
                thanhNhacNen.Value = 0;
            }
            else
            {
                thanhNhacNen.Value = 100;
            }
            if (thanhNhacNen.Value == 100)
            {
                giaTriBatTat.Text = "Bật";
                giaTriBatTat.ForeColor = Color.Green;
                nhacNen = true;
                loadINI.Write("Volume", "On", section);
            }
            else
            {
                giaTriBatTat.Text = "Tắt";
                giaTriBatTat.ForeColor = Color.Red;
                nhacNen = false;
                loadINI.Write("Volume", "Off", section);
            }
        }

        private void xetPass_Tick(object sender, EventArgs e)
        {
            if (nhapPass.moKhoa)
            {
                this.Show();
                xetPass.Stop();
                xetPass.Dispose();
            }
        }
        private bool KiemTraLicense(string licenseCuaNguoiDung)
        {
            //Application.StartupPath + @"\DuLieu\LicenseKey.txt"
            using (StreamReader docCode = new StreamReader(Application.StartupPath + @"\DuLieu\LicenseKey.txt"))
            {
                string tempKey = "";
                while (!docCode.EndOfStream)
                {
                    tempKey = docCode.ReadLine();
                    tempKey = tempKey.Substring(2);
                    if (tempKey == licenseCuaNguoiDung)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void KiemTraLicenseHienTai(Label trangThai)
        {
            if (loadINI.Read("license", section) != "")
            {
                if (KiemTraLicense(loadINI.Read("license", section)))
                {
                    trangThai.Text = "Đã kích hoạt";
                    trangThai.ForeColor = Color.Green;
                    return;
                }
            }

            trangThai.Text = "Chưa có bản quyền";
            trangThai.ForeColor = Color.Red;
        
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nhacNen)
                loadINI.Write("Volume", "On", section);
            else loadINI.Write("Volume", "Off", section);
        }
    }
}
