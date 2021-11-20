using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using ChuongTrinhHocTapChoBe.Class;
using ChuongTrinhHocTapChoBe.Game.Sơn.HuongDan;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class GameChonHinh : Form
    {
        public GameChonHinh()
        {
            InitializeComponent();
        }
        Music ms;
        private void init()
        {
            ms = new Music();
            lbGioiThieu.Text = lbHuongDan.Text = "";
            //lbHuongDan.Font = new Font("Arial", 13);
            //lbGioiThieu.Font = new Font("Arial", 15);
            lbHuongDan.Font = new Font(lbHuongDan.Font, FontStyle.Bold);
            lbGioiThieu.Font = new Font(lbHuongDan.Font, FontStyle.Bold);
            lbHuongDan.BackColor = lbGioiThieu.BackColor = Color.Transparent;
            lbHuongDan.ForeColor = lbGioiThieu.ForeColor = Color.Red;
            lbGioiThieu.TextAlign = ContentAlignment.MiddleLeft;
            lbGioiThieu.BorderStyle = lbHuongDan.BorderStyle = BorderStyle.None;          
            btTiepTuc.Text = "Tiếp tục";
            btStart.Text = "Bắt đầu";
        }
        private void GameChonHinh_Load(object sender, EventArgs e)
        {
            init();
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\pic\\icon default\\Dog.jfif");
            BackgroundImageLayout = ImageLayout.Stretch;
            lbGioiThieu.Text =   "Game chọn hình sẽ giúp trẻ em nhớ hình ảnh và tên của các loài vật."
                               + "Ngoài ra giúp trẻ rèn luyện được tính phản xạ của bản thân.";
            lbHuongDan.Visible = false;
            btStart.Visible = false;
            lbHuongDan.Text = "                              Hướng dẫn chơi game\n"
        + "Để bắt đầu trò chơi hãy nhấn nút Start.\n"
        + "Nhấn Stop nếu muốn dừng trò chơi.\n"
        + "Nếu muốn chơi lại hãy nhấn nút Replay.\n"
        + "Nhấn nút Exit để thoát trò chơi.\n"
        + "Khi bắt đầu game sẽ hiện ra hình các con vật và sẽ có 1 ô hiển thị tên con vật.\n "
        + "Hãy chọn hình con vật đúng với tên con vật đã hiện trên ô.\n"
        + "Khi chọn đúng sẽ tăng số điểm ngược lại sẽ bị trừ điểm.\n"
        + "Hãy chọn chính xác nhất để giành được số điểm cao nhất trong thời gian quy định.\n";
        }
        private void btTiepTuc_Click_1(object sender, EventArgs e)
        {
            lbGioiThieu.Visible = false;
            lbHuongDan.Visible = true;
            if (lbHuongDan.Visible)
            {
                btTiepTuc.Visible = false;
                btStart.Visible = true;
            }
        }
        private void btStart_Click_1(object sender, EventArgs e)
        {
            ChonHinh frmGLH = new ChonHinh();
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
            //    ms.Off_Music();
            //    e.Cancel = false;
            //}
            //if (e.Cancel == false)
            //{
            //    //Environment.Exit(1);
            //}

        }
    }
}

