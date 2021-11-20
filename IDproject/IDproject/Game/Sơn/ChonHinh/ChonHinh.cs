using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using ChuongTrinhHocTapChoBe.Class;
using ChuongTrinhHocTapChoBe.Game.Sơn.HuongDan;
using System.Runtime.InteropServices;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class ChonHinh : Form
    {
        public ChonHinh()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        #region Biến toàn cục
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        Music music = new Music();
        Sound sound = new Sound();
        Random rd = new Random();//Ham khoi tao gia tri ngau nhien
        Button[] btn;//Ham tao mang cac button hinh 
        Button[] btn1;//Ham tao mang cac button thao tac
        ArrayList saveinf = new ArrayList();//Lưu dữ liệu của player
        ArrayList arrayName = new ArrayList();//Lưu tên vào danh sách
        List<int> arrayMaxScore = new List<int>();//Điểm cao nhất
        List<int> arrayTotalTime = new List<int>();//Tổng thời gian đã chơi
        List<int> So = new List<int>();//Tao ds So de luu thu tu cua tung hinh
        ArrayList arrayList = new ArrayList();// Tao ds arrayList de luu tat ca cac hinh trong thu muc "icon thu"
        List<int> List = new List<int>();//Tao ds List de luu tru thu tu cac hinh da random (Cac button co the bi trung hinh)
        List<int> LocationOfImage = new List<int>();//Tao ds LocationOfImage de luu tru cac hinh cua 4 button 
        ArrayList CloneArrayList = new ArrayList();//Tao ds CloneArrayList de luu tru lai tat ca hinh cua arrayList
        List<int> distinct;//Tao ds de loai bo cac so bi trung trong list
        int SavePicture;//Luu so sau khi random
        int rd2;//Random hinh de hien thi cho lbChu
        string[] allLine = new string[20];//Dung de doc tat ca cac dong
        string[] Str1 = new string[20];//Dung de doc du lieu sau khi cat
        int SaveDA;//Luu dap an de kiem tra
        int Score = 0;//Diem khi choi
        int countertime = 100;//Thoi gian hoan thanh
        int somanchoi = 0;
        int flag;//khi nguoi dung bam replay luu gia tri yes = 1 va no = 0
        int flagOnOffmusic = 0;//Bat tat nhac
        int counter = 3;//Dem nguoc de vao game
        int flagSound = 0;
        int flagKT = 0;//Chưa có thông tin trong file Rank.txt
        string playerName;
        string[] strAllLine = new string[100];
        string[] strCutName = new string[20];
        string[] strCutLine = new string[20];
        string[] strCutScore = new string[20];
        string[] strCutTime = new string[20];
        string RankMode = Application.StartupPath + "\\Data\\ChonHinh\\Rank.txt";
        #endregion

        #region Khởi tạo
        private void init()
        {
            btn = new Button[] { btH1, btH2, btH3, btH4 };//$ button hinh
            btn1 = new Button[] { btStart, btStop, btReplay, btExit};//5 button thao tac
            music.Name = "CH.wav";

            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\Dog.jfif");
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Size = new Size(200, 150);
            }
            for (int i = 0; i < btn1.Length; i++)
            {
                btn1[i].Font = new Font("Arial", 10);
                btn1[i].Size = new Size(150, 45);
            }
            lbScore.Text = Score.ToString();
            lbScore.ForeColor = Color.Black;
            btStart.Text = "Bắt đầu";
            btStop.Text = "Dừng lại";
            btReplay.Text = "Chơi lại";
            btExit.Text = "Thoát";
            lbKT.Text = btH1.Text = btH2.Text = btH3.Text = btH4.Text = "";
        }
        #endregion

        #region Hàm thao tác button
        public void visible()
        {
            lbChu.Visible = true;
            lbScore.Visible = true;
            lbTime.Visible = true;
            lbKT.Visible = true;
            progressBar1.Visible = true;
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Visible = true;
            }
            for (int i = 0; i < btn1.Length; i++)
            {
                btn1[i].Visible = true;
            }
        }
        public void invisible()
        {
            lbChu.Visible = false;
            lbScore.Visible = false;
            lbTime.Visible = false;
            lbKT.Visible = false;
            progressBar1.Visible = false;
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Visible = false;
            }
            for (int i = 0; i < btn1.Length; i++)
            {
                btn1[i].Visible = false;
            }
        }
        public void btn_Off()
        {
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Enabled = false;
            }
        }
        public void btn_On()
        {
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Enabled = true;
            }
        }
        public void DoOffButton()
        {
            if (btStart.Enabled == false)
            {
                btStart.BackColor = Color.Gray;
                btStart.ForeColor = Color.White;
            }
            if (btStop.Enabled == false)
            {
                btStop.BackColor = Color.Gray;
                btStop.ForeColor = Color.White;
            }
            if (btReplay.Enabled == false)
            {
                btReplay.BackColor = Color.Gray;
                btReplay.ForeColor = Color.White;
            }
        }
        public void DoOnButton()
        {
            if (btStart.Enabled)
            {
                btStart.BackColor = Color.Cyan;
                btStart.ForeColor = Color.Black;
            }
            if (btStop.Enabled)
            {
                btStop.BackColor = Color.Cyan;
                btStop.ForeColor = Color.Black;
            }
            if (btReplay.Enabled)
            {
                btReplay.BackColor = Color.Cyan;
                btReplay.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Gán hình cho button
        private void XoaDanhSach()//Xóa tat ca gia tri trong list và arraylist  
        {
            arrayList.Clear();
            distinct.Clear();
            List.Clear();
            So.Clear();
            LocationOfImage.Clear();
            CloneArrayList.Clear();
        }
        private void XoaPhanTuTrung()
        {
            distinct = List.Distinct().ToList();
            distinct.Sort();
        }
        private void RanDomHinh()
        {
            for (int i = 0; i < btn.Length; i++)//Random va gan hinh trong ds arrayList cho button
            {
                SavePicture = rd.Next(1, arrayList.Count + 1);
                btn[i].BackgroundImage = (Image)arrayList[SavePicture - 1];
                List.Add(SavePicture);
            }
        }
        private void DuyetMang_ThayThe()
        {
            for (int i = 0; i < btn.Length - 1; i++)
            {
                for (int j = i + 1; j < btn.Length; j++)
                {
                    if (btn[i].BackgroundImage == btn[j].BackgroundImage)//Tim cac button bi trung hinh
                    {
                        int rd1 = rd.Next(0, arrayList.Count - 1);//Random 1 so bat ky (so nay la vi tri cua ds arrayList)
                        btn[j].BackgroundImage = null;//Cho button j la null
                        btn[j].BackgroundImage = (Image)arrayList[rd1];//Gan cho button j 1 cai image trong ds arrayList co vi tri la rd1
                        LocationOfImage.Add(So[rd1]);//Them 1 so nguyen la rd1 vao ds LocationOfImage
                        arrayList.RemoveAt(rd1);//Xoa phan tu co vi tri rd1 trong ds arrayList
                        So.RemoveAt(rd1);//Xoa phan tu co vi tri rd1 trong ds So
                    };
                }
            }
        }
        private void LuuHinh_ViTriHinh()
        {
            for (int i = 1; i <= 12; i++)//Luu tat ca hinh
            {
                arrayList.Add(Image.FromFile(Application.StartupPath + "\\pic\\icon thu\\icon (" + i + ").png"));
            }
            for (int i = 0; i < arrayList.Count; i++)//Luu thu tu tung hinh
            {
                So.Add(i + 1);
            }
            for (int i = 0; i < arrayList.Count; i++)//Luu lai tat ca hinh
            {
                CloneArrayList.Add(arrayList[i]);
            }
        }
        private void RanDomHinhKhongTrung()
        {
            LuuHinh_ViTriHinh();
            RanDomHinh();
            XoaPhanTuTrung();
            for (int i = distinct.Count - 1; i >= 0; i--)
            {
                int Xoa = distinct[i] - 1;
                LocationOfImage.Add(Xoa + 1);//Them thu tu cua cac hinh
                arrayList.RemoveAt(Xoa);// Xoa hinh tai vi tri Xoa
                So.RemoveAt(Xoa);//Xoa so thu tu tai vi tri xoa             
            }
            //Duyet mang de tim cac hinh giong nhau va random lai hinh khong trung cho cac button do
            DuyetMang_ThayThe();
            // Sap xep lai ds LocationOfImage
            LocationOfImage.Sort();
            //Hien thi Image theo thu tu cua button
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].BackgroundImage = null;
                btn[i].BackgroundImage = (Image)CloneArrayList[LocationOfImage[i] - 1];
                btn[i].Tag = LocationOfImage[i];
            }
            //Random vi tri hinh de chon lam dap an
            rd2 = LocationOfImage[rd.Next(0, LocationOfImage.Count - 1)];
            ReadFileImage();
        }
        #endregion

        #region Form
        private void ChooseWord_Load(object sender, EventArgs e)
        {
            init();
            sound.Off_Sound_1();
            sound.Off_Sound_2();
            SaveFileDialog s1 = new SaveFileDialog();
            s1.Filter = "INI File |*.ini";
            INI ini = new INI(Application.StartupPath + "\\Data\\LRN.ini");
            string section = "Bo tro choi cho tre em - Team19 OU";
            music.On_Music();
            playerName = ini.Read("username-1", section);
            StartPosition = FormStartPosition.CenterScreen;
            lbChu.TextAlign = ContentAlignment.MiddleCenter;
            menuStrip1.Visible = false;
            timer2.Enabled = true;
            btStop.Enabled = false;
            btReplay.Enabled = false;
            timer1.Stop();
            timer2.Start();
            invisible();
            btn_Off();
            DoOffButton();
            DoOnButton();
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                music.Off_Music();
            }
        }
        #endregion

        #region Thời gian
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            countertime--;
            lbTime.Text = countertime.ToString();
            progressBar1.Increment(-1);
            if (progressBar1.Value == 0)
            {
                for(int i = 0; i < btn.Length; i++)
                {
                    btn[i].BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\Dog.jfif");
                }
                timer1.Stop();
                btn_Off();
                lbTime.Text = 100.ToString();
                progressBar1.Value = 100;
                btStart.Enabled = false;
                btStop.Enabled = false;
                DoOffButton();
                if (Score < 100)
                {
                    MessageBox.Show("Trò chơi đã kết thúc! Hãy cố gắng hơn :((!\nĐiểm của bạn : " +
                lbScore.Text + "\nThời gian chơi: " +
                (progressBar1.Maximum - progressBar1.Value).ToString() +
                "\nSố màn đã chơi: " + somanchoi, "Chúc mừng");
                }
                else
                {
                    MessageBox.Show("Trò chơi đã kết thúc! Bạn đã làm rất tốt!\nĐiểm của bạn : " +
               lbScore.Text + "\nThời gian chơi: " +
               (progressBar1.Maximum - progressBar1.Value).ToString() +
               "\nSố màn đã chơi: " + somanchoi, "Chúc mừng");                  
                }
                Score = Score + (progressBar1.Maximum - progressBar1.Value);
                Read();
                Write(Score);
            }          
        }       
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            progressBar2.Maximum = 3;
            progressBar2.Increment(-1);
            if (counter == 0)
            {
                timer2.Stop();
                visible();
                menuStrip1.Visible = true;
                progressBar2.Visible = false;
            }
        }
        #endregion

        #region Click button
        private void btH1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (SaveDA == (int)btn.Tag)
            {
                if (flagOnOffmusic == 1)
                { 
                    if (flagSound == 1)
                        sound.correctSound();
                    else
                        sound.Off_Sound_1();      
                }
                lbKT.Text = "Đúng";
                Score = Score + 10;
                lbScore.Text = Score.ToString();
            }
            else
            {
                if (flagOnOffmusic == 1)
                {
                    if (flagSound == 1)
                        sound.wrongSound();
                    else
                        sound.Off_Sound_2();
                }
                lbKT.Text = "Sai";
                if (Score == 0)
                    Score = 0;
                else
                    Score = Score - 5;
                lbScore.Text = Score.ToString();
            }
            somanchoi++;
            XoaDanhSach();
            RanDomHinhKhongTrung();
        }
        private void Start()
        {
            visible();
            btn_On();
            timer1.Enabled = true;
            timer1.Start();
            btStart.Enabled = false;
            btStop.Enabled = true;
            btReplay.Enabled = true;
            lbTime.Text = countertime.ToString();
            DoOffButton();
            DoOnButton();
            RanDomHinhKhongTrung();
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void Replay()
        {
            if (MessageBox.Show("Bạn có muốn chơi lại không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }
            if (flag == 1)
            {
                invisible();
                btStart.Enabled = true;
                btStop.Enabled = false;
                DoOffButton();
                DoOnButton();
                if (btStop.Enabled == false)
                {
                    btStop.BackColor = Color.Gray;
                    btStop.ForeColor = Color.White;
                }
                Score = 0;
                lbScore.Text = Score.ToString();
                progressBar1.Maximum = 100;
                countertime = 100;
                progressBar1.Value = 100;
                timer1.Stop();
                lbTime.Text = countertime.ToString();
                btStart.Visible = true;

            }
        }
        private void btReplay_Click(object sender, EventArgs e)
        {
            Replay();
           
        }
        private void Stop()
        {
            timer1.Stop();
            for(int i = 0; i < btn.Length; i++)
                btn[i].BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\Dog.jfif");
            XoaDanhSach();
            lbChu.Text = null;
            lbKT.Text = null;
            btStart.Visible = true;
            btStart.Enabled = true;
            btStop.Enabled = false;
            DoOffButton();
            DoOnButton();
            btn_Off();
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private void Exit()
        {
            Application.Exit();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btMusic_Click(object sender, EventArgs e)
        {
            if (flagOnOffmusic == 0)
            {
                flagOnOffmusic = 1;
                music.Off_Music();
            }
            else
            {
                if (flagOnOffmusic == 1)
                {
                    flagOnOffmusic = 0;
                    music.On_Music();
                }
            }
        }
        #endregion

        #region Lựa chọn
        private void TurnOffSound()
        {
            if (bậtTiếngToolStripMenuItem.Text == "Tắt tiếng")
                bậtTiếngToolStripMenuItem.Text = "Bật tiếng";
            else
                bậtTiếngToolStripMenuItem.Text = "Tắt tiếng";
            if (flagSound == 1)
            {
                flagSound = 0;
                sound.Off_Sound_1();
                sound.Off_Sound_2();
            }
            else
            {
                flagSound = 1;
            }
        }
        private void bậtTiếngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnOffSound();
        }
        private void TurnOffMusic()
        {
            if (tắtNhạcToolStripMenuItem.Text == "Bật nhạc")
                tắtNhạcToolStripMenuItem.Text = "Tắt nhạc";
            else
                tắtNhạcToolStripMenuItem.Text = "Bật nhạc";
            if (flagOnOffmusic == 0)
            {
                flagOnOffmusic = 1;
                music.Off_Music();
            }
            else
            {
                if (flagOnOffmusic == 1)
                {
                    flagOnOffmusic = 0;
                    music.On_Music();
                }
            }
        }
        private void tắtNhạcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TurnOffMusic();
        }
        private void Guide()
        {
            HuongDanCH huongDanCH = new HuongDanCH();          
            huongDanCH.Show();
        }
        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guide();
        }
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
        private void giảmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giam();
        }
        #endregion

        #region Sự kiện bàn phím
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Start();
                    btStart.Focus();
                    return true;
                case Keys.Space:
                    Stop();
                    btStop.Focus();
                    return true;
                case Keys.F:
                    Replay();
                    btReplay.Focus();
                    return true;
                case Keys.Escape:
                    Exit();
                    btExit.Focus();
                    return true;               
                case Keys.F4:
                    TurnOffMusic();
                    return true;
                case Keys.F5:
                    TurnOffSound();
                    return true;
                case Keys.F6:
                    Guide();
                    return true;
                case Keys.F7:
                    Tang();
                    return true;
                case Keys.F8:
                    Giam();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion

        #region Đọc ghi file txt
        private void ReadFileImage()
        {
            string file = Application.StartupPath + ("\\Data\\ChonHinh\\Animals Name.txt");
            if (File.Exists(file))
            {              
                try
                {
                    allLine = File.ReadAllLines(file);
                    for (int i = 0; i < allLine.Length; i++)
                    {                       
                        Str1 = allLine[i].Split(':');//Cat thanh 2 chuoi
                        if (Int32.Parse(Str1[0]) == rd2)
                        {
                            SaveDA = Int32.Parse(Str1[0]);
                            lbChu.Text = Str1[1].ToString();
                            break;
                        }
                    }
                }
                catch (IOException)
                {
                    throw;
                }
            }
        }
        private void Read()
        {
            saveinf.Clear();
            arrayName.Clear();
            arrayMaxScore.Clear();
            arrayTotalTime.Clear();
            if (File.Exists(Application.StartupPath + RankMode))
            {
                try
                {
                    strAllLine = File.ReadAllLines(RankMode);//Doc tat ca dong
                    if (strAllLine != null)
                    {
                        flagKT = 1;//Đã có dữ liệu trong file txt
                        for (int i = 0; i < strAllLine.Length; i++)
                        {
                            if (strAllLine[i] != "")
                            {
                                strCutLine = strAllLine[i].Split(':');//Cat thanh 2 chuoi
                                strCutName = strCutLine[1].Split(' ');//Có khoảng trống trước tên nên cắt bỏ khoảng trống
                                arrayName.Add(strCutName[1]);//Thêm tên vào danh sách
                                i++;
                                strCutLine = strAllLine[i].Split(':');//Cat thanh 2 chuoi
                                strCutScore = strCutLine[1].Split(' ');
                                arrayMaxScore.Add(Int32.Parse(strCutScore[1]));
                                i++;
                                strCutLine = strAllLine[i].Split(':');//Cat thanh 2 chuoi
                                strCutTime = strCutLine[1].Split(' ');
                                arrayTotalTime.Add(Int32.Parse(strCutTime[1]));
                            }
                        }
                        int j = 0;
                        for (int i = 0; i < strAllLine.Length / 3; i++)
                        {
                            string a = strAllLine[j] + "\n" + strAllLine[j + 1] + "\n" + strAllLine[j + 2] + "\n";
                            saveinf.Add(a);
                            j += 3;
                        }
                    }
                }
                catch (IOException)
                {
                    throw;
                }
            }
        }
        private void Write(int KQ)
        {
            int demG = 0;//Kiểm tra xem có tên nào trùng với tên trong file txt không           
            try
            {
                if (flagKT == 0)
                {
                    using (StreamWriter streamWriter = new StreamWriter(RankMode))
                    {
                        streamWriter.Write("Tên người chơi: " + playerName + "\nĐiểm cao nhất: " +
                            KQ.ToString() + "\nThời gian chơi: " + (progressBar1.Maximum - countertime));
                        streamWriter.Write("\n");
                        streamWriter.Close();
                    }
                }
                else
                {
                    for (int i = 0; i < arrayName.Count; i++)
                    {
                        if (String.Compare(playerName, (string)arrayName[i], false) != 0)
                        {
                            demG++;
                        }
                        else
                        {
                            saveinf.RemoveAt(i);
                            if (arrayMaxScore[i] < KQ)
                                arrayMaxScore[i] = KQ;
                            arrayTotalTime[i] = arrayTotalTime[i] + (progressBar1.Maximum - countertime);
                            string a = "Tên người chơi: " + playerName + "\nĐiểm cao nhất: " +
                               arrayMaxScore[i] + "\nThời gian chơi: " + arrayTotalTime[i] + "\n";
                            saveinf.Add(a);
                            if (File.Exists(RankMode))
                            {
                                File.Delete(RankMode);
                            }
                            FileStream fileStream = new FileStream(RankMode, FileMode.Create);
                            fileStream.Close();
                            using (StreamWriter streamWriter = new StreamWriter(RankMode))
                            {
                                for (int j = 0; j < saveinf.Count; j++)
                                {
                                    streamWriter.Write(saveinf[j]);
                                }
                                streamWriter.Close();
                                break;
                            }
                        }
                    }
                    if (demG == arrayName.Count)
                    {
                        using (StreamWriter streamWriter = File.AppendText(RankMode))
                        {
                            string a = "Tên người chơi: " + playerName + "\nĐiểm cao nhất: " +
                                KQ.ToString() + "\nThời gian chơi: " + (progressBar1.Maximum - countertime) + "\n";
                            saveinf.Add(a);
                            streamWriter.Write(a);
                            streamWriter.Close();
                        }
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }
        #endregion       
    }
}
