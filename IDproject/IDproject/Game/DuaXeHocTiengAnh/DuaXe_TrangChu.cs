using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace ChuongTrinhHocTapChoBe.Game.DuaXeHocTiengAnh
{
    public partial class DuaXe_TrangChu : Form
    {
        public DuaXe_TrangChu()
        {
            InitializeComponent();
            HuongDanTroChoi();
        }

        Panel huongDan = new Panel(); ///Panel hướng dẫn
        public static bool amThanh { get; set; }
        string path;
        ListView bangXepHang;
        PictureBox nutBack;
        string[] nguoiChoi;
        int[] diemSo, diDuoc;
        SoundPlayer khoiDong;
        private void KhoiTaoChuongTrinh()
        {
            //Đọc dữ liệu nhất quán
            if (amThanh)
            {
                amThanhNen.Image = Properties.Resources.musicON;

            }
            else
            {
                amThanhNen.Image = Properties.Resources.musicOFF;
            }
            //Đưa path về gốc
            path = Application.StartupPath;
            for (int dem = 0; dem < 4; dem++)
            {
                path = Directory.GetParent(path).ToString();
            }
            khoiDong = new SoundPlayer();
            khoiDong.SoundLocation = path + @"\Game\DuaXeHocTiengAnh\sound\khoiDong.wav";
            if (amThanh)
                khoiDong.Play();
            KiemTra.Stop();
        }
        private void startGame_MouseHover(object sender, EventArgs e)
        {
            startGame.Image.Dispose();
            startGame.Image = Properties.Resources.start1;
        }

        private void startGame_MouseLeave(object sender, EventArgs e)
        {
            startGame.Image.Dispose();
            startGame.Image = Properties.Resources.start;
        }
        DuaXe doiTuong;
        private void startGame_Click(object sender, EventArgs e)
        {
            doiTuong = new DuaXe();
            doiTuong.ShowDialog();
            doiTuong.BringToFront();
            KiemTra.Start();
            //this.Hide();
        }

        private void KiemTra_Tick(object sender, EventArgs e)
        {
            if (DuaXe.daDong)
            {
                doiTuong.Dispose();
                //this.Show();
                KhoiTaoChuongTrinh();
                KiemTra.Stop();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (amThanh)
            {
                khoiDong.Stop();
                amThanhNen.Image.Dispose();
                amThanhNen.Image = Properties.Resources.musicOFF;
                amThanh = false;
            }
            else
            {
                amThanhNen.Image.Dispose();
                amThanhNen.Image = Properties.Resources.musicON;
                amThanh = true;
            }
        }

        private void optionBox_MouseHover(object sender, EventArgs e)
        {
            optionBox.Image.Dispose();
            optionBox.Image = Properties.Resources.menu2;
        }

        private void optionBox_MouseLeave(object sender, EventArgs e)
        {
            optionBox.Image.Dispose();
            optionBox.Image = Properties.Resources.menu1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (amThanh)
                khoiDong.Play();
        }
        private void DoiChoChoNhau(ref string ten1, ref int diem1, ref int duong1, ref string ten2, ref int diem2, ref int duong2)
        {
            string tempStr;
            int tempDiem;
            int tempDuong;
            //lưu dữ liệu tạm thời
            tempStr = ten1;
            tempDiem = diem1;
            tempDuong = duong1;
            //đổi dữ liệu
            ten1 = ten2;
            diem1 = diem2;
            duong1 = duong2;
            ten2 = tempStr;
            diem2 = tempDiem;
            duong2 = tempDuong;
        }
        private void SapXepBangXepHang(string[] ten, int[] diemSo, int[] diDuocQuangDuong)
        {
            for (int i = 0; i < ten.Length - 1; i++)
            {
                for (int j = i + 1; j < ten.Length; j++)
                {
                    if (diemSo[i] == diemSo[j])
                    {
                        if (diDuocQuangDuong[i] == diDuocQuangDuong[j])
                        {
                            if (String.Compare(ten[i], ten[j]) < 0)
                            {
                                DoiChoChoNhau(ref ten[i], ref diemSo[i], ref diDuocQuangDuong[i], ref ten[j], ref diemSo[j], ref diDuocQuangDuong[j]);
                            }
                        }
                        else if (diDuocQuangDuong[i] < diDuocQuangDuong[j])
                        {
                            DoiChoChoNhau(ref ten[i], ref diemSo[i], ref diDuocQuangDuong[i], ref ten[j], ref diemSo[j], ref diDuocQuangDuong[j]);
                        }    
                    }
                    else if (diemSo[i] < diemSo[j])
                    {
                        DoiChoChoNhau(ref ten[i], ref diemSo[i], ref diDuocQuangDuong[i], ref ten[j], ref diemSo[j], ref diDuocQuangDuong[j]);
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
            ColumnHeader cotTen, cotDiem, cotDuong, cotTop;
            cotTop = new ColumnHeader();
            cotTop.Text = "Hạng";
            cotTen = new ColumnHeader();
            cotTen.Text = "Tên người chơi";
            cotDiem = new ColumnHeader();
            cotDiem.Text = "Điểm số";
            cotDuong = new ColumnHeader();
            cotDuong.Text = "Đường đi";
            cotTop.Width = (int)(bangXepHang.Width * 0.07);
            cotTen.Width = (int)(bangXepHang.Width * 0.4);
            cotDiem.Width = (int)(bangXepHang.Width * 0.14);
            cotDuong.Width = (int)(bangXepHang.Width * 0.14);
            cotTop.TextAlign = cotTen.TextAlign = cotDiem.TextAlign = cotDuong.TextAlign = HorizontalAlignment.Center;
            bangXepHang.Columns.AddRange(new ColumnHeader[] { cotTop ,cotTen, cotDiem, cotDuong });
            bangXepHang.Location = new Point(ClientSize.Width / 4, ClientSize.Height / 4);
            bangXepHang.Size = new Size(ClientSize.Width / 2, ClientSize.Height / 2);
            try
            {
                using (FileStream fstream = new FileStream(path + @"\Game\DuaXeHocTiengAnh\player.txt", FileMode.Open))
                {
                    StreamReader docFile = new StreamReader(fstream);
                    while (!docFile.EndOfStream)
                    {
                        docFile.ReadLine();
                        soDong++;
                    }
                }
                using (FileStream fstream = new FileStream(path + @"\Game\DuaXeHocTiengAnh\player.txt", FileMode.Open))
                {
                    StreamReader docFile = new StreamReader(fstream);
                    int i = 0;
                    if (soDong <= 0)
                    {
                        goto XuatBang;
                    }
                    nguoiChoi = new string[soDong];
                    diemSo = new int[soDong];
                    diDuoc = new int[soDong];
                    while (!docFile.EndOfStream)
                    {
                        string temp = docFile.ReadLine();
                        string[] tempStr = temp.Split(" ");
                        diemSo[i] = int.Parse(tempStr[tempStr.Length - 2]);
                        diDuoc[i] = int.Parse(tempStr[tempStr.Length - 1]);
                        int demToiHet = tempStr.Length - 3;
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
            } catch(IOException) { }
            SapXepBangXepHang(nguoiChoi, diemSo, diDuoc);
            XuatBang:
            for (int n = 0; n < soDong; n++)
            {
                ListViewItem soThuTu = new ListViewItem();
                soThuTu.Text = (n + 1).ToString();
                ListViewItem.ListViewSubItem soDiemNguoiChoi, soQuangDuong, tenNguoiChoi;
                tenNguoiChoi = new ListViewItem.ListViewSubItem();
                soDiemNguoiChoi = new ListViewItem.ListViewSubItem();
                soQuangDuong = new ListViewItem.ListViewSubItem();
                tenNguoiChoi.Text = nguoiChoi[n];
                soDiemNguoiChoi.Text = diemSo[n].ToString();
                soQuangDuong.Text = diDuoc[n].ToString();
                soThuTu.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { tenNguoiChoi, soDiemNguoiChoi, soQuangDuong });
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
            this.Controls.Add(nutBack);
            nutBack.Click += nutBack_Click;
            //Thêm
            this.Controls.Add(bangXepHang);
        }

        private void DuaXe_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
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
            noiDung.Text = "                            HƯỚNG DẪN TRÒ CHƠI ĐUA XE HỌC TIẾNG ANH             \n\n" +
                "Người chơi sẽ cần phải vượt qua mười câu hỏi để có thể hoàn thành trò chơi. Các câu hỏi sẽ được xuất hiện mỗi khi xe của người chơi sắp va chạm với" +
                " xe đi ở chiều ngược lại.\n" +
                "Nếu người chơi trả lời đúng, xe của người chơi sẽ rẽ sang làn khác không có xe và xe vượt thành công.\n" +
                "Ngược lại xe của người chơi sẽ tông vào xe ngược chiều và bị mất điểm ở câu hỏi đó.\n" +
                "Mỗi khi người chơi hoàn thành một lượt chơi hoặc khi hệ thống bắt đầu tính điểm thì khi trò chơi kết thúc, hệ thống sẽ yêu cầu người chơi nhập" +
                "tên của mình để ghi vào danh sách người chơi thuộc top.\n" +
                "Kết quả được ghi nhận và xét trên quãng đường đi được và " +
                "Nếu người chơi nhập tên của mình, hệ thống sẽ lưu lại kết quả với điểm số mà người chơi đạt được. Nếu không nhập, hệ thống sẽ ghi nhận với nhân vật " +
                "là \"Người chơi ẩn danh\" \n" +
                "Người chơi cũng có thể xem bảng xếp hạng ở trang chủ của trò chơi, người chơi có thể dùng chuột để trượt xuống những vị trí thấp hơn trong bảng xếp hạng.\n" +
                "Trò chơi có hỗ trợ tắt âm lượng, người chơi có thể thao tác bằng cách dùng chuột click vào những biểu tượng hình chiếc loa ở những góc màn hình.\n" +
                "Để chơi trò chơi này, người chơi hãy nhấn OK để có thể truy cập được vào trang chủ.\n";
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
