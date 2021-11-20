using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class HuongDan : Form
    {
        public HuongDan()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            lbHuongDan.Text = "                                                     Hướng dẫn chơi game\n"
        + "Để bắt đầu trò chơi hãy nhấn nút Start.\n"
        + "Nhấn Stop nếu muốn dừng trò chơi.\n"
        + "Nếu muốn chơi lại hãy nhấn nút Replay.\n"
        + "Nhấn nút Exit để thoát trò chơi.\n"
        + "Nhấn vào mỗi ô hình sẽ xuất hiện một hình ảnh và hãy nhớ hình ảnh này.\n"
        + "Lật tiếp hình thứ 2 nếu hình ảnh trong hình này giống hình ảnh của hình mở trước thì 2 hình sẽ biến mất "
        + "ngược lại thì 2 hình này sẽ ẩn đi.\n"
        + "Hãy thực hiện liên tục cho đến khi không còn hình nào trong thời gian quy định.\n";
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        + "Nhấn vào mỗi ô hình sẽ xuất hiện một hình ảnh và hãy nhớ hình ảnh này.\n"
        + "Lật tiếp hình thứ 2 nếu hình ảnh trong hình này giống hình ảnh của hình mở trước thì 2 hình sẽ biến mất "
        + "ngược lại thì 2 hình này sẽ ẩn đi.\n"
        + "Hãy thực hiện liên tục cho đến khi không còn hình nào trong thời gian quy định.\n";
            }
            else
            {
                btTiepTuc.Text = "Trước";               
                lbHuongDan.Text = "                                                     Hướng dẫn chơi game\n"
        + "Start: Enter.\n"
        + "Stop: Space.\n"
        + "Replay: F.\n"
        + "Exit: Esc.\n"
        + "Dễ: F1.\n"
        + "Trung bình: F2.\n"
        + "Khó: F3.\n"
        + "Bật/Tắt nhạc: F4.\n"
        + "Bật/Tắt tiếng: F5.\n"
        + "Hướng dẫn: F6.\n";
            }           
        }
    }
}
