using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Media;
using ChuongTrinhHocTapChoBe.Class;
using ChuongTrinhHocTapChoBe.Game.Sơn.HuongDan;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class GameLatHinh : Form
    {
        public GameLatHinh()
        {
            InitializeComponent();
        }
        Music ms = new Music();
        private void init()
        {
            lbGioiThieu.Text = lbHuongDan.Text = "";
            //lbHuongDan.Font = new Font("Arial", 12);
            //lbGioiThieu.Font = new Font("Arial", 20);
            lbHuongDan.Font = new Font(lbHuongDan.Font, FontStyle.Bold);
            lbGioiThieu.Font = new Font(lbHuongDan.Font, FontStyle.Bold);
            lbHuongDan.BackColor = lbGioiThieu.BackColor = Color.Transparent;
            lbHuongDan.ForeColor = lbGioiThieu.ForeColor = Color.Red;
            lbGioiThieu.TextAlign = ContentAlignment.MiddleLeft;
            lbGioiThieu.BorderStyle = lbHuongDan.BorderStyle = BorderStyle.None;
            btTiepTuc.Text = "Tiếp tục";
            btStart.Text = "Bắt đầu";
        }
        private void Form1_Load(object sender, EventArgs e)
        {          
            init();
            BackgroundImage = Image.FromFile(Application.StartupPath + "icon default\\pokemon_nature.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            lbGioiThieu.Text = "Game lật hình sẽ giúp trẻ em rèn luyện trí nhớ cũng như " +
                                "giúp trẻ nhớ được mặt chữ của bảng chữ cái tiếng anh";
            lbHuongDan.Visible = false;
            btStart.Visible = false;
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
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            lbGioiThieu.Visible = false;
            lbHuongDan.Visible = true;
            if (lbHuongDan.Visible)
            {
                btTiepTuc.Visible = false;
                btStart.Visible = true;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            LatHinh frmGLH = new LatHinh();
            frmGLH.ShowDialog();
            frmGLH.BringToFront();
            this.Hide();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            ms.Off_Music();
            //if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;

            //}
            //else
            //{
            //    e.Cancel = false;
            //}
            //if (e.Cancel == false) { 
            //    //Environment.Exit(1);
            //}
        }
    }
}
