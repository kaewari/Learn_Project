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
    public partial class HuongDanCH : Form
    {
        public HuongDanCH()
        {
            InitializeComponent();
        }
        private void init()
        {
            btStart.Text = "OK";
            btStart.ForeColor = Color.Red;
            lbHuongDan.Font = new Font(lbHuongDan.Font, FontStyle.Bold);
            lbHuongDan.BackColor = Color.Transparent;
            lbHuongDan.ForeColor = Color.OrangeRed;
            lbHuongDan.BorderStyle = BorderStyle.None;
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\totoro.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            btStart.Visible = false;
            btTiepTuc.Text = "Sau";
        }
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            btStart.Visible = true;
            if (btTiepTuc.Text == "Trước")
            {
                btTiepTuc.Text = "Sau";
                lbHuongDan.Text = "                                                     Hướng dẫn chơi game\n"
        + "Để bắt đầu trò chơi hãy nhấn nút Start.\n"
        + "Nhấn Stop nếu muốn dừng trò chơi.\n"
        + "Nếu muốn chơi lại hãy nhấn nút Replay.\n"
        + "Nhấn nút Exit để thoát trò chơi.\n"
        + "Nhìn từ để chọn hình tương ứng.\n"
        + "Hãy thực hiện liên tục cho đến khi hết thời gian quy định.\n";
            }
            else
            {
                btTiepTuc.Text = "Trước";
                lbHuongDan.Text = "                                                     Hướng dẫn chơi game\n"
        + "Start: Enter.\n"
        + "Stop: Space.\n"
        + "Replay: F.\n"
        + "Exit: Esc.\n"
        + "Bật/Tắt nhạc: F4.\n"
        + "Bật/Tắt tiếng: F5.\n"
        + "Hướng dẫn: F6.\n"
        + "Tăng âm lượng: F7.\n"
        + "Giảm âm lượng: F8.\n";
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HuongDanCH_Load(object sender, EventArgs e)
        {
            init();
            lbHuongDan.Text = "                                                         Hướng dẫn chơi game\n"
        + "Để bắt đầu trò chơi hãy nhấn nút Start.\n"
        + "Nhấn Stop nếu muốn dừng trò chơi.\n"
        + "Nếu muốn chơi lại hãy nhấn nút Replay.\n"
        + "Nhấn nút Exit để thoát trò chơi.\n"
        + "Nhìn từ để chọn hình tương ứng.\n"
        + "Hãy thực hiện liên tục cho đến khi hết thời gian quy định.\n";
        }
    }
}
