using System;
using System.Windows.Forms;
using System.IO;
using ChuongTrinhHocTapChoBe.Class;
using ChuongTrinhHocTapChoBe.Game.Sơn.HuongDan;
using ChuongTrinhHocTapChoBe.Game;
using System.Runtime.InteropServices;

namespace ChuongTrinhHocTapChoBe
{
    public partial class Login : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        public Login()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        string path = Application.StartupPath + @"/DuLieu/";
        string licenseKey, motDong;
        int so;
        string[] chuoi;
        Random r = new Random();
        string username;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        Music ms;
        int flagOnOffmusic = 1;
        #endregion

        #region Form
        private void Login_Load(object sender, EventArgs e)
        {          
            btCap.Enabled = false;
            so = r.Next(0, 10);
            ms = new Music();
            ms.Name = "Login.wav";
            ms.On_Music();         
            if (File.Exists(path + "licenseKey.txt"))
            {
                StreamReader doc = new StreamReader(path + "licenseKey.txt");
                for (int i = 0; i < 10; i++)
                {
                    motDong = doc.ReadLine();
                    chuoi = motDong.Split(".");
                    if (so == i)
                    {
                        licenseKey = chuoi[1];
                        break;
                    }
                }              
            }
            else
            {
                licenseKey = "Không có License key";
            }          
        }
        private void Login_Shown(object sender, EventArgs e)
        {
            txtTenDN.Focus();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            ms.Off_Music();
        }
        #endregion

        #region Button
        private void btDN_Click(object sender, EventArgs e)
        {
            SaveFileDialog s1 = new SaveFileDialog();
            s1.Filter = "INI File |*.ini";
            INI ini = new INI(Application.StartupPath + "\\Data\\LRN.ini");
            string section = "Bo tro choi cho tre em - Team19 OU";
            string volume;
            if (rbNam.Checked == true)
                ini.Write("gender", "Nam", section);
            else
                ini.Write("gender", "Nu", section);
            if (flagOnOffmusic == 1)
                volume = "On";
            else
                volume = "Off";
            ini.Write("username", username, section);
            ini.Write("volume", volume, section);
            if (txtTenDN.Text == "")
                username = "Guest";
            else
                username = txtTenDN.Text;
            ini.Write("username", username, section);
            ini.Write("license", licenseKey, section);
            MessageBox.Show("Bản quyền đã được thêm. Chúc bạn sử dụng vui vẻ.");
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            txtTenDN.Focus();
            //txtMK.Clear();
            //dtpNS.Value = DateTime.Now;
            rbNam.Checked = true;
        }

        private void btCap_Click(object sender, EventArgs e)
        {
            txtLK.Text = licenseKey;
        }

        private void ckXN_Click(object sender, EventArgs e)
        {
            if (ckXN.Checked)
            {
                btCap.Enabled = true;
            }
            else
            {
                btCap.Enabled = false;
            }
        }
        #endregion

        #region Lựa chọn
        private void Tang()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
              (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        private void tăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tang();
        }
        private void Giam()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }
        private void gIảmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giam();
        }            
        private void TurnOnMusic()
        {
            if (bậtNhạcToolStripMenuItem.Text == "Bật nhạc")
                bậtNhạcToolStripMenuItem.Text = "Tắt nhạc";
            else
                bậtNhạcToolStripMenuItem.Text = "Bật nhạc";
            if (flagOnOffmusic == 0)
            {
                flagOnOffmusic = 1;
                ms.On_Music();
            }
            else
            {
                flagOnOffmusic = 0;
                ms.Off_Music();
            }
        }
        private void bậtNhạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnOnMusic();
        }
        private void Guide()
        {
            HuongDan();
        }
        private void HuongDan()
        {
            HuongDanBanPhim huongDanBanPhim = new HuongDanBanPhim();
            huongDanBanPhim.Show();
        }
        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan();
        }
        private void Exit()
        {
            Close();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion

        #region Sự kiện bàn phím
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Exit();
                    return true;
                case Keys.F1:
                    TurnOnMusic();
                    return true;
                case Keys.F2:
                    Tang();
                    return true;
                case Keys.F3:
                    Giam();
                    return true;
                case Keys.F4:
                    Guide();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion
    }
}
