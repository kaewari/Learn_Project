using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace ChuongTrinhHocTapChoBe.Game.HungTaoHocToan
{
    public partial class HungTao_TrangChu : Form
    {
        public HungTao_TrangChu()
        {
            InitializeComponent();
            HuongDanTroChoi();
        }
        HungTao doiTuong;
        string path;
        ListView bangXepHang;
        PictureBox nutBack;
        string[] nguoiChoi;
        int[] diemSo;
        Panel huongDan = new Panel(); ///Panel hướng dẫn
        public static bool amThanh { get; set; }
        SoundPlayer khoiDong;
        private void KhoiTaoChuongTrinh()
        {
            //Đọc dữ liệu nhất quán
            if (amThanh)
            {
                picMusic.Image = Properties.Resources.musicON;

            }
            else
            {
                picMusic.Image = Properties.Resources.musicOFF;
            }
            //Đưa path về gốc
            path = Application.StartupPath;
            for (int dem = 0; dem < 4; dem++)
            {
                path = Directory.GetParent(path).ToString();
            }
            khoiDong = new SoundPlayer();
            khoiDong.SoundLocation = path + @"\Game\HungTaoHocToan\audio\bg-wel.wav";
            if (amThanh)
                khoiDong.PlayLooping();
            KiemTra.Stop();
        }
        private void picPlay_Click(object sender, EventArgs e)
        {
            HungTao.amThanh = amThanh;
            doiTuong = new HungTao();
            KiemTra.Start();
            doiTuong.ShowDialog();
            doiTuong.BringToFront();
            HungTao.formDong = false;
            //this.Hide();
        }

        private void KiemTra_Tick(object sender, EventArgs e)
        {
            if (HungTao.formDong)
            {
                amThanh = HungTao.amThanh;
                KhoiTaoChuongTrinh();
                //this.Show();
            }
        }

        private void DoiChoChoNhau(ref string ten1, ref int diem1, ref string ten2, ref int diem2)
        {
            string tempStr;
            int tempDiem;
            //lưu dữ liệu tạm thời
            tempStr = ten1;
            tempDiem = diem1;
            //đổi dữ liệu
            ten1 = ten2;
            diem1 = diem2;
            ten2 = tempStr;
            diem2 = tempDiem;
        }
        private void SapXepBangXepHang(string[] ten, int[] diemSo)
        {
            for (int i = 0; i < ten.Length - 1; i++)
            {
                for (int j = i + 1; j < ten.Length; j++)
                {
                    if (diemSo[i] == diemSo[j])
                    {
                        if (String.Compare(ten[i], ten[j]) < 0)
                        {
                            DoiChoChoNhau(ref ten[i], ref diemSo[i], ref ten[j], ref diemSo[j]);
                        }
                    }
                    else if (diemSo[i] < diemSo[j])
                    {
                        DoiChoChoNhau(ref ten[i], ref diemSo[i], ref ten[j], ref diemSo[j]);
                    }
                }
            }
        }
        private void optionBox_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Hide();
                KiemTra.Stop();
            }
            int soDong = 0;
            bangXepHang = new ListView();
            bangXepHang.View = View.Details;
            bangXepHang.GridLines = true;
            bangXepHang.FullRowSelect = true;
            bangXepHang.Scrollable = true;
            bangXepHang.BorderStyle = BorderStyle.FixedSingle;
            bangXepHang.Size = new Size(2 * ClientSize.Width / 3, 2 * ClientSize.Width / 3);
            ColumnHeader cotTen, cotDiem, cotTop;
            cotTop = new ColumnHeader();
            cotTop.Text = "Hạng";
            cotTen = new ColumnHeader();
            cotTen.Text = "Tên người chơi";
            cotDiem = new ColumnHeader();
            cotDiem.Text = "Điểm số";
            cotTop.Width = (int)(bangXepHang.Width * 0.07);
            cotTen.Width = (int)(bangXepHang.Width * 0.47);
            cotDiem.Width = (int)(bangXepHang.Width * 0.21);
            cotTop.TextAlign = cotTen.TextAlign = cotDiem.TextAlign = HorizontalAlignment.Center;
            bangXepHang.Columns.AddRange(new ColumnHeader[] { cotTop, cotTen, cotDiem });
            bangXepHang.Location = new Point(ClientSize.Width / 4, ClientSize.Height / 4);
            bangXepHang.Size = new Size(ClientSize.Width / 2, ClientSize.Height / 2);
            try
            {
                using (FileStream fstream = new FileStream(path + @"\Game\HungTaoHocToan\player.txt", FileMode.Open))
                {
                    StreamReader docFile = new StreamReader(fstream);
                    while (!docFile.EndOfStream)
                    {
                        docFile.ReadLine();
                        soDong++;
                    }
                }
                using (FileStream fstream = new FileStream(path + @"\Game\HungTaoHocToan\player.txt", FileMode.Open))
                {
                    StreamReader docFile = new StreamReader(fstream);
                    int i = 0;
                    if (soDong <= 0)
                    {
                        goto XuatBang;
                    }
                    nguoiChoi = new string[soDong];
                    diemSo = new int[soDong];
                    while (!docFile.EndOfStream)
                    {
                        string temp = docFile.ReadLine();
                        string[] tempStr = temp.Split(" ");
                        diemSo[i] = int.Parse(tempStr[tempStr.Length - 1]);
                        int demToiHet = tempStr.Length - 2;
                        int demLen = 0;
                        nguoiChoi[i] = "";
                        while (demLen <= demToiHet)
                        {
                            nguoiChoi[i] += tempStr[demLen];
                            if (demToiHet > demLen++)
                            {
                                nguoiChoi[i] += " ";
                            }
                        }
                        i++;
                    }
                }
            }
            catch (IOException) { }
            SapXepBangXepHang(nguoiChoi, diemSo);
            XuatBang:
            for (int n = 0; n < soDong; n++)
            {
                ListViewItem soThuTu = new ListViewItem();
                soThuTu.Text = (n + 1).ToString();
                ListViewItem.ListViewSubItem soDiemNguoiChoi, tenNguoiChoi;
                tenNguoiChoi = new ListViewItem.ListViewSubItem();
                soDiemNguoiChoi = new ListViewItem.ListViewSubItem();
                tenNguoiChoi.Text = nguoiChoi[n];
                soDiemNguoiChoi.Text = diemSo[n].ToString();
                soThuTu.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { tenNguoiChoi, soDiemNguoiChoi });
                bangXepHang.Items.Add(soThuTu);
            }
            //Nút Back
            nutBack = new PictureBox();
            nutBack.Size = new Size(110, 110);
            nutBack.Location = new Point((ClientSize.Width / 5) * 2 + (((ClientSize.Width / 5) - 110) / 2), ClientSize.Height - 110 - 25);
            //nutBack.Location = new Point(420, 950);
            nutBack.Image = Properties.Resources.back;
            nutBack.BackColor = Color.Transparent;
            nutBack.SizeMode = PictureBoxSizeMode.StretchImage;
            //Thêm
            this.Controls.Add(bangXepHang);
            this.Controls.Add(nutBack);
            nutBack.Click += nutBack_Click;
        }

        private void picMusic_Click(object sender, EventArgs e)
        {
            if (amThanh)
            {
                khoiDong.Stop();
                picMusic.Image.Dispose();
                picMusic.Image = Properties.Resources.musicOFF;
                amThanh = false;
            }
            else
            {
                picMusic.Image.Dispose();
                picMusic.Image = Properties.Resources.musicON;
                khoiDong.PlayLooping();
                amThanh = true;
            }
        }

        private void nutBack_Click(object sender, EventArgs e)
        {
            nutBack.Dispose();
            bangXepHang.Dispose();
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Show();
            }
            KhoiTaoChuongTrinh();
        }

        private void HungTao_TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Main.nhacNen = amThanh;
                if (khoiDong != null)
                    khoiDong.Stop();
            }
            catch (NullReferenceException)
            {

            }
        }
        private void HuongDanTroChoi()
        {
            //Ẩn hết ctrol
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
                ctrl.Hide();
            }
            //Đưa hướng dẫn vào
            huongDan = new Panel();
            huongDan.BackColor = Color.Transparent;
            huongDan.Location = new Point(10, 10);
            huongDan.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 20);
            this.Controls.Add(huongDan);
            Button nutOK = new Button();
            nutOK.Text = "OK";
            nutOK.AutoSize = true;
            nutOK.Width = 3 * huongDan.Width / 7;
            nutOK.Location = new Point(2 * huongDan.Width / 7, huongDan.Bottom - 50);
            nutOK.Click += NutOK_Click;
            huongDan.Controls.Add(nutOK);
            nutOK.BringToFront();
            Label noiDung = new Label();
            noiDung.Size = new Size(huongDan.Width - 50, huongDan.Height - 100);
            noiDung.Location = new Point(huongDan.Left + 25, huongDan.Top + 25);
            noiDung.Font = new Font("Arial", 15);
            noiDung.ForeColor = Color.White;
            ///Nội dung hướng dẫn
            noiDung.Text = "                            HƯỚNG DẪN TRÒ CHƠI HỨNG TÁO HỌC TOÁN             \n" +
                "Người chơi sẽ cần phải hứng tất cả những trái táo có màu đỏ rơi xuống. Nếu bị trượt không hứng được các quả táo đỏ, người chơi sẽ bị hệ thống ghi nhận số" +
                " lần bị trượt. Với những vật phẩm rơi khác, người chơi có thể không cần hứng chúng.\n" +
                "Quả bom sẽ nổ và trừ điểm khi người chơi vô tình va chạm hoặc hứng chúng. Nếu người chơi có thể trả lời đúng được những câu hỏi hiện lên, người chơi sẽ" +
                "không bị trừ điểm cho dù là hứng phải bom.\n" +
                "Táo \"Apple\" sẽ được cộng điểm khi quý khách trả lời đúng được câu hỏi hiện lên, ngược lại nếu không trả lời đúng, người chơi sẽ không được cộng điểm.\n" +
                "Quy tắc của trò chơi khi câu hỏi hiện lên, cho dù sai hay đúng, bạn vẫn phải có đáp án đúng để tiếp tục phần hứng táo của mình. Khi người chơi trả lời" +
                "đúng, hộp thoại sẽ được tắt tự động, khi người chơi trả lời sai, hệ thống sẽ báo sai và bắt buộc người chơi phải chọn lại đáp án đúng để có thể tiếp tục.\n" +
                "Quá 20 lần bị rơi táo đỏ, người chơi sẽ thua cuộc và hệ thống sẽ yêu cầu người chơi nhập tên để có thể lưu lại kết quả và xếp hạng.\n" +
                "Mặc định, nếu không nhập tên, hệ thống sẽ ghi nhận kết quả là  \"Người chơi ẩn danh.\"\n" +
                "Người chơi có thể thao tác với âm thanh bằng cách click nút hình cái loa để bật/tắt âm thanh theo ý muốn.\n" +
                "Để truy cập vào trang chủ, người chơi cần nhấn nút OK tại đây để có thể bắt đầu chơi.";
            ///Kết thúc nội dung hướng dẫn
            huongDan.Controls.Add(noiDung);
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            KetThucHuongDan();
        }

        private void KetThucHuongDan()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = true;
                ctrl.Show();
            }
            huongDan.Enabled = false;
            huongDan.Hide();
            huongDan.Dispose();

            amThanh = Main.nhacNen;
            KhoiTaoChuongTrinh();
        }
    }
}
