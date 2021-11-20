using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class BangVeTreEm : Form
    {
        #region Biến toàn cục
        Point viTriVe;
        Graphics graph;
        Graphics veVien;
        PaintEventArgs toVe;
        PictureBox temp;
        PictureBox oldValue;
        Pen but;
        Color mauBut;
        int doDay;
        string path = Application.StartupPath;
        bool flag; //xem có vẽ gì hay chưa
        #endregion
        public BangVeTreEm()
        {
            InitializeComponent();
            KhoiTaoChuongTrinh();
        }
        private void KhoiTaoChuongTrinh()
        {
            //Địa chỉ gốc
            for (int i = 0; i < 4; i++)
            {
                path = Directory.GetParent(path).ToString();
            }
            pictureBox3.Focus();
            graph = khuVucVe.CreateGraphics();
            viTriVe = new Point(-1, -1);
            doDay = 5;
            doDayTang.Maximum = 100;
            doDayTang.Minimum = 1;
            flag = false;
            oldValue = null;
        }

        private void KiemTraVe()
        {
            if (temp == picGomTay)
            {
                this.Cursor = new Cursor(Properties.Resources.eraser.Handle);
            }
            else
            {
                this.Cursor = new Cursor(Properties.Resources.pencil.Handle);
            }
        }
        private void khuVucVe_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but = new Pen(mauBut, doDay);
                but.DashCap = DashCap.Round;
                but.StartCap = LineCap.Round;
                but.EndCap = LineCap.Round;
                graph.DrawLine(but, viTriVe, e.Location);
                viTriVe = e.Location;
                Invalidate();
                flag = true;
            }    
        }

        private void khuVucVe_MouseDown(object sender, MouseEventArgs e)
        {
            viTriVe = e.Location;
        }

        private void ChonMauBut_Click(object sender, System.EventArgs e)
        {
            temp = (PictureBox)sender;

            if (temp != oldValue)
            {
                //Xóa màu viền cũ
                if (oldValue != null)
                {
                    PaintEventArgs suKienXoavien = new PaintEventArgs(veVien, oldValue.ClientRectangle);
                    ControlPaint.DrawBorder(toVe.Graphics, oldValue.ClientRectangle, oldValue.BackColor, 5, ButtonBorderStyle.Solid, oldValue.BackColor, 5, ButtonBorderStyle.Solid, oldValue.BackColor, 5, ButtonBorderStyle.Solid, oldValue.BackColor, 5, ButtonBorderStyle.Solid);
                }

                veVien = temp.CreateGraphics();
                toVe = new PaintEventArgs(veVien, temp.ClientRectangle);
                if (temp == picGomTay)
                    ControlPaint.DrawBorder(toVe.Graphics, temp.ClientRectangle, Color.Red, 5, ButtonBorderStyle.Solid, Color.Red, 5, ButtonBorderStyle.Solid, Color.Red, 5, ButtonBorderStyle.Solid, Color.Red, 5, ButtonBorderStyle.Solid);
                else
                    ControlPaint.DrawBorder(toVe.Graphics, temp.ClientRectangle, Color.White, 5 ,ButtonBorderStyle.Solid, Color.White, 5, ButtonBorderStyle.Solid, Color.White, 5, ButtonBorderStyle.Solid, Color.White, 5, ButtonBorderStyle.Solid);
                mauBut = temp.BackColor;
                oldValue = temp;
            }
        }

        private void BangVeTreEm_ResizeEnd(object sender, System.EventArgs e)
        {
            khuVucVe.Size = khuVucVe.Size;
        }

        private void doDayTang_ValueChanged(object sender, System.EventArgs e)
        {
            doDay = int.Parse(doDayTang.Value.ToString());
        }

        private void khuVucVe_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void khuVucVe_MouseEnter(object sender, System.EventArgs e)
        {
            KiemTraVe();
        }

        private void picSave_Click(object sender, System.EventArgs e)
        {
            try
            {           
                //Tạo file ảnh
                int doDai = khuVucVe.Width;
                int doRong = khuVucVe.Height;
                Image luuHinh = new Bitmap(doDai, doRong);
                Graphics luuHinhGr = Graphics.FromImage(luuHinh);
                var khung = khuVucVe.RectangleToScreen(khuVucVe.ClientRectangle);
                luuHinhGr.CopyFromScreen(khung.Location, Point.Empty, khuVucVe.Size);

                //Lưu vào file
                SaveFileDialog luuFile = new SaveFileDialog();
                luuFile.FileName = "Không được đặt tên";
                luuFile.Filter = "JPEG Image (.jpg)|*.jpg|Bitmap Image (.bmp)|*.bmp|PNG Image (.png)|*.png";
                if (luuFile.ShowDialog() == DialogResult.OK)
                {
                    string diaChiHinh = Path.GetFullPath(luuFile.FileName);
                    luuHinh.Save(diaChiHinh);
                }    
            }
            catch (System.Exception)
            {

                MessageBox.Show("Lỗi không mong muốn. Vui lòng thực hiện lại thao tác.");
            }
        }

        private void picBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BangVeTreEm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                if (MessageBox.Show("Ôi. Thoát ra sẽ mất hết hình bạn nhé! Đồng ý thoát?", "Thoát khỏi bảng vẽ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
