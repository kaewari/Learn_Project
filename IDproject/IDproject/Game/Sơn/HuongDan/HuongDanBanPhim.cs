using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhHocTapChoBe.Game.Sơn.HuongDan
{
    public partial class HuongDanBanPhim : Form
    {
        public HuongDanBanPhim()
        {
            InitializeComponent();
        }
        private void init()
        {
            lbHuongDan.Font = new Font(lbHuongDan.Font, FontStyle.Bold);
            lbHuongDan.BackColor = Color.Transparent;
            lbHuongDan.ForeColor = Color.OrangeRed;
            lbHuongDan.BorderStyle = BorderStyle.None;
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\totoro.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void HuongDanBanPhim_Load(object sender, EventArgs e)
        {
            init();
            lbHuongDan.Text = "                                                     Hướng dẫn chơi game\n"
        + "Để bắt đầu trò chơi hãy nhấn nút Start.\n"
        + "Nhấn Stop nếu muốn dừng trò chơi.\n"
        + "Nếu muốn chơi lại hãy nhấn nút Replay.\n"
        + "Nhấn nút Exit để thoát trò chơi.\n"
        + "Thoát: Escape.\n"
        + "Bật/Tắt nhạc: F1.\n"
        + "Tăng âm lượng: F2.\n"
        + "Giảm âm lượng: F3.\n"
        + "Hướng dẫn: F4.\n";
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
