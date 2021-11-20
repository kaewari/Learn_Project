using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhHocTapChoBe.Class;

namespace ChuongTrinhHocTapChoBe
{
    public partial class parentpass : Form
    {
        public bool moKhoa { get; set; }
        public bool doiPass {get; set;}
        string doiPass1;
        INI loadINI = new INI(Application.StartupPath + "\\Data\\LRN.ini");
        string section = "Bo tro choi cho tre em - Team19 OU";
        public parentpass()
        {
            doiPass = false;
            InitializeComponent();
            pass1.Select();
            thoiGian = 15;
            demThoiGianDong.Enabled = false;
            moKhoa = false;
            doiPass1 = null;
            INI loadINI = new INI(Application.StartupPath + "\\Data\\LRN.ini");
            string section = "Bo tro choi cho tre em - Team19 OU";
            if (loadINI.Read("lock", section) != "")
            {
                oldPass = loadINI.Read("lock", section);
            }
            else
            {
                oldPass = 0000.ToString();
            }
        }
        int thoiGian;
        Label oldValue;
        String oldPass;
        private void llbQuenMatMa_Click(object sender, EventArgs e)
        {
            this.Text = "Bạn đã chọn quên mật khẩu phụ huynh.";
            demThoiGianDong.Enabled = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
                ctrl.Hide();
            }
            demThoiGianDong.Start();
        }
        private void thongBaoResetPass()
        {
            if (oldValue != null)
            {
                oldValue.Dispose();
            }
            Label lienHe = new Label();
            lienHe.Font = new Font("Arial", 12);
            lienHe.AutoSize = false;
            lienHe.Size = new Size(this.ClientRectangle.Width / 2 + 15, this.ClientRectangle.Height / 2 + 15);
            lienHe.Location = new Point(((this.ClientRectangle.Width - lienHe.Width) / 2), ((this.ClientRectangle.Height - lienHe.Height) / 2));
            lienHe.ForeColor = Color.White;
            lienHe.TextAlign = ContentAlignment.MiddleCenter;
            lienHe.Text = String.Format("Bạn đã gửi yêu cầu đến chúng tôi. Chúng tôi sẽ xác nhận với quý khách sau ít phút nữa qua cuộc gọi.\n Chương trình sẽ đóng sau\n{0} giây nữa. \n #252623", thoiGian); //25263 lỗi quên password do người dùng
            this.Controls.Add(lienHe);
            oldValue = lienHe;
        } 
        private void NhayPassThuan(TextBox temp)
        {
            if (temp != pass4 && temp.Text != "")
            {
                if (temp == pass1)
                {
                    temp = pass2;
                }
                else if (temp == pass2)
                {
                    temp = pass3;
                }
                else if (temp == pass3)
                    temp = pass4;

                temp.Focus();
            }
        }
        private void pass4_TextChanged_1(object sender, EventArgs e)
        {
            if (!doiPass)
            {
                try
                {
                    int so = int.Parse(((TextBox)sender).Text);
                    if (so < 0 || so > 9)
                    {
                        ((TextBox)sender).Text = "";
                        throw new FormatException();
                    }
                    NhayPassThuan((TextBox)sender);
                    if (((TextBox)sender) == pass4)
                    {
                        if ((pass1.Text + pass2.Text + pass3.Text + pass4.Text) == oldPass)
                        {
                            if (MessageBox.Show("****Chào mừng bạn đã trở lại****") == DialogResult.OK)
                            {
                                moKhoa = true;
                                this.Close();
                            }

                        }
                        pass1.Select();
                        pass1.Text = pass2.Text = pass3.Text = pass4.Text = "";
                    }
                }
                catch (FormatException)
                {
                    ((TextBox)sender).Text = "";
                } 
            }
            else //khi đổi pass
            {
                try
                {
                    if (doiPass1 == null)
                        lbMatMa.Text = "NHẬP MẬT MÃ CŨ";
                    int so = int.Parse(((TextBox)sender).Text);
                    if (so < 0 || so > 9)
                    {
                        ((TextBox)sender).Text = "";
                        throw new FormatException();
                    }
                    NhayPassThuan((TextBox)sender);
                    if (((TextBox)sender) == pass4)
                    {
                        if ((pass1.Text + pass2.Text + pass3.Text + pass4.Text) == oldPass && doiPass1 == null)
                        {
                            lbMatMa.Text = "NHẬP MẬT MÃ MỚI";
                            doiPass1 = "";
                        }
                        else if (doiPass1 == "")
                        {
                            if ((pass1.Text + pass2.Text + pass3.Text + pass4.Text) == oldPass)
                            {
                                lbMatMa.Text = "MẬT MÃ CŨ. NHẬP KHÁC!!!!";
                            }
                            else
                            {
                                doiPass1 = pass1.Text + pass2.Text + pass3.Text + pass4.Text;
                                lbMatMa.Text = "NHẬP LẠI MẬT MÃ MỚI";
                            }
                        }
                        else if (doiPass1 != null && doiPass1 != "")
                        {
                            if ((pass1.Text + pass2.Text + pass3.Text + pass4.Text) == doiPass1)
                            {
                                MessageBox.Show("Đổi mật mã thành công.");
                                oldPass = doiPass1;
                                loadINI.DeleteKey("lock", section);
                                loadINI.Write("lock", doiPass1, section);
                                this.Close();
                            }
                            else
                            {
                                lbMatMa.Text = "KHÔNG TRÙNG KHỚP.";
                                Task.Delay(2000);
                                lbMatMa.Text = "NHẬP MẬT MÃ MỚI";
                                doiPass1 = "";
                            } 
                        }
                        pass1.Select();
                        pass1.Text = pass2.Text = pass3.Text = pass4.Text = "";
                    }
                }
                catch (FormatException)
                {
                    ((TextBox)sender).Text = "";
                }
            }
        }

        private void demThoiGianDong_Tick(object sender, EventArgs e)
        {
            thongBaoResetPass();
            thoiGian--;
            if(thoiGian < 0) {
                Environment.Exit(1);
            }
        }

        private void parentpass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!moKhoa && !doiPass)
            {
                Environment.Exit(1);
            }
            doiPass = false;
        }

        private void doiPassTick_Tick(object sender, EventArgs e)
        {
            if (doiPass)
            {
                lbMatMa.Text = "NHẬP MẬT MÃ CŨ";
                demThoiGianDong.Stop();
                doiPassTick.Stop();
            }
        }
    }
}
