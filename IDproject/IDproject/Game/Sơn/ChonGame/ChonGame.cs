using System;
using System.Drawing;
using System.Windows.Forms;
using ChuongTrinhHocTapChoBe.Class;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class ChonGame : Form
    {
         public ChonGame()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        Music ms = new Music();
        bool check = false;
        #endregion

        #region Khởi tạo
        private void init()
        {                   
            lbChuoi.TextAlign = ContentAlignment.MiddleRight;
            lbChuoi.Text = "                                                                        " +
                "                                      Bộ trò chơi cho trẻ em-K19-OU";
            lbHuongDan.Text = "Hãy chọn game bạn muốn chơi.";
            lbHuongDan.TextAlign = ContentAlignment.MiddleCenter;
            checkLatHinh.Text = "Game lật hình";
            checkChonHinh.Text = "Game chọn hình";
            checkBangVe.Text = "Bảng vẽ trẻ em";
            checkDuaXe.Text = "Đua xe học tiếng Anh";
            checkEchNhay.Text = "Ếch nhảy";
            checkHungTao.Text = "Hứng táo học toán";
            checkSoThu.Text = "Sở thú";
            lbHuongDan.Font = new Font("Arial", 26);
            lbHuongDan.Font = new Font(lbHuongDan.Font, FontStyle.Italic);
            lbHuongDan.BackColor = Color.Transparent;
            lbHuongDan.ForeColor = Color.Red;
            btTiepTuc.Text = "Tiếp tục";
            lbPlayerName.BackColor = checkChonHinh.BackColor = checkLatHinh.BackColor = checkHungTao.BackColor = 
                checkDuaXe.BackColor = checkEchNhay.BackColor = checkSoThu.BackColor = checkBangVe.BackColor = Color.Transparent;
        }
        #endregion

        #region Form
        private void ChonGame_Load(object sender, EventArgs e)
        {
            init();            
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\pic\\icon default\\Ghibli.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            string section = "Bo tro choi cho tre em - Team19 OU";
            SaveFileDialog s1 = new SaveFileDialog();
            s1.Filter = "INI File |*.ini";
            INI ini = new INI(Application.StartupPath + "\\Data\\LRN.ini");
            if (checkLatHinh.Checked)
            {
                GameLatHinh FrmGLH = new GameLatHinh();
                FrmGLH.Show();
                this.Hide();
            }
            else
            {
                if (checkChonHinh.Checked)
                {
                    GameChonHinh FrmGCH = new GameChonHinh();
                    FrmGCH.Show();
                    this.Hide();
                }
                else
                {
                    if (checkBangVe.Checked)
                    {
                        BangVeTreEm bangVeTreEm = new BangVeTreEm();
                        bangVeTreEm.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (checkDuaXe.Checked)
                        {
                            DuaXeHocTiengAnh.DuaXe duaXe = new DuaXeHocTiengAnh.DuaXe();
                            duaXe.Show();
                            this.Hide();
                        }
                        else
                        {
                            if (checkEchNhay.Checked)
                            {
                                EchNhay.BatDauEN batDauEN = new EchNhay.BatDauEN();
                                batDauEN.Show();
                                this.Hide();
                            }
                            else
                            {
                                if (checkSoThu.Checked)
                                {
                                    SoThu.BatDauST batDauST = new SoThu.BatDauST();
                                    batDauST.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    if (checkHungTao.Checked)
                                    {
                                        HungTaoHocToan.HungTao_TrangChu hungTao_TrangChu = new HungTaoHocToan.HungTao_TrangChu();
                                        hungTao_TrangChu.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn chưa chọn game.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (txtPlayerName.Text == "")
            {
                txtPlayerName.Text = "Guest";
            }
            ini.Write("username-1",txtPlayerName.Text, section);
            if(check)
                ms.Off_Music();
            ini.Write("volume", "Off", section);
        }
        private void checkLatHinh_CheckedChanged(object sender, EventArgs e)
        {
            check = true;
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (e.Cancel == false)
            {
                Environment.Exit(1);
            }
        }
        #endregion

        #region Thời gian
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbChuoi.Text = lbChuoi.Text.Substring(1) + lbChuoi.Text.Substring(0, 1);
        }
        #endregion      
    }  
}
