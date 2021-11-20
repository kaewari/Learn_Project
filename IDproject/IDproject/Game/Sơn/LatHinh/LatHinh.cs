using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChuongTrinhHocTapChoBe.Class;
using System.IO;
using System.Runtime.InteropServices;

namespace ChuongTrinhHocTapChoBe.Game
{
    public partial class LatHinh : Form
    {
        
        public LatHinh()
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
        Random rd = new Random();
        ArrayList list = new ArrayList();//Lưu giá trị random hình ảnh
        ArrayList saveinf = new ArrayList();//Lưu dữ liệu của player
        ArrayList arrayName = new ArrayList();//Lưu tên vào danh sách
        List<int> arrayMaxScore = new List<int>();//Điểm cao nhất
        List<int> arrayTotalTime = new List<int>();//Tổng thời gian đã chơi
        Button[] btn1;//Ham tao mang cac button thao tac
        Button[] btn;//Ham tao mang cac button hinh
        int n;//Tong so button
        int flag = 1;//khi nguoi dung bam replay luu gia tri Yes = 1 va No = 0
        int loadData = 0;//Load du lieu khi form load len
        int countertime;//Dem nguoc thoi gian choi
        int dem = 0;//So button da bien mat
        int Score = 0;
        int flagOnOffmusic = 0;//Bat tat nhac
        int flagSound = 0;//Tắt nhạc
        int counter = 3;//Dem nguoc de vao game     
        int saveLocate;//Lưu vị trí 0 hoặc 1 để xác định lấy ảnh là chữ thường hay chữ in
        string playerName;
        string[] strAllLine = new string[100];
        string[] strCutName = new string[20];
        string[] strCutLine = new string[20];
        string[] strCutScore = new string[20];
        string[] strCutTime = new string[20];
        int flagKT = 0;//Chưa có thông tin trong file Rank.txt
        string RankModeEasy = Application.StartupPath + "\\Data\\LatHinh\\RankModeEasy.txt";//Dễ
        string RanhModeNormal = Application.StartupPath + "\\Data\\LatHinh\\RankModeNormal.txt";//Trung bình
        string RankModeDifficult = Application.StartupPath + "\\Data\\LatHinh\\RankModeDifficult.txt";//Khó
        string RankMode;//Chế độ chơi
        bool flagPlayed = false;
        #endregion

        #region Tạo button
        public void init()
        {           
            music.Name = "LH.wav";          
            btn1 = new Button[] { btStart, btStop, btReplay, btExit};//5 button thao tac
            pnHinh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\Duck.jpg");
            pnHinh.Size = new Size(1200, 750);
            lbScore.Text = Score.ToString();
            lbScore.ForeColor = Color.Black;
            for (int i = 0; i < btn1.Length; i++)
            {
                btn1[i].Font = new Font("Arial", 10);
                btn1[i].Size = new Size(90, 45);
            }
            menu.ForeColor = Color.Red;               
        }
        #endregion

        #region Form
        private void LatHinh_Load(object sender, EventArgs e)
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
            invisible();
            timer2.Enabled = true;
            timer2.Start();
            pictureBox1.Visible = false;
            pnDiem.Visible = false;
            lbScore.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
            btStop.Enabled = false;
            btReplay.Enabled = false;
            btStart.Enabled = false;
            DesignButtonOff();
            DesignButtonOn();
            BackColor = Color.DarkGray;
        }
        private void LatHinh_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Lật hình (2 hình khác nhau)
        public void RanDom()
        {
            int[] H0 = new int[26];//26 hình chữ thường
            int[] H1 = new int[26];//26 hình chữ hoa
            int[,] a = new int[26, 2];//Mảng 2 chiều  
            int rdvalue0;
            int rdvalue1;
            int rdvalue2;
            for (int i = 0; i < 26; i++)
            {
                H0[i] = i + 1;
                H1[i] = i + 1;
            }
            //Nửa số button đầu
            for (int i = 0; i < btn.Length / 2; i++)
            {
                rdvalue0 = rd.Next(0, 2);
                rdvalue1 = rd.Next(1, 26);
                if (rdvalue0 == 0)
                {
                    while (H0[rdvalue1 - 1] == 0)
                        rdvalue1 = rd.Next(1, 26);
                    btn[i].Click += btn_Click;
                    list.Add(rdvalue1);
                    btn[i].Tag = rdvalue1;
                }

                else
                {
                    while (H1[rdvalue1 - 1] == 0)
                        rdvalue1 = rd.Next(1, 26);
                    btn[i].Click += btn1_Click;
                    list.Add(rdvalue1);
                    btn[i].Tag = rdvalue1;
                }
                H0[rdvalue1 - 1] = 0;
                H1[rdvalue1 - 1] = 0;
                a[rdvalue1, rdvalue0] = 1;
            }
            //Nửa số button sau
            for (int i = btn.Length / 2; i < btn.Length; i++)
            {
                rdvalue2 = rd.Next(list.Count);
                for (int m = 0; m < 26; m++)
                {
                    for (int n = 0; n < 2; n++)
                    {
                        if ((int)list[rdvalue2] == m && a[m, n] == 1)
                        {
                            saveLocate = n;
                        }
                    }
                }
                if (saveLocate == 0)
                {
                    btn[i].Click += btn1_Click;
                    btn[i].Tag = list[rdvalue2];
                }
                else
                {
                    btn[i].Click += btn_Click;
                    btn[i].Tag = list[rdvalue2];
                }
                list.RemoveAt(rdvalue2);
                //if (list.Count == 0)
                //    break;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon alphabet\\" + bt.Tag.ToString() + ".jfif");
            bt.BackgroundImageLayout = ImageLayout.Stretch;
            bt.Enabled = false;
            check();
            Notify();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon alphabet U\\icon (" + bt.Tag.ToString() + ").png");
            bt.BackgroundImageLayout = ImageLayout.Stretch;
            bt.Enabled = false;
            check();
            Notify();
        }
        private void check()
        {
            for (int i = 0; i < btn.Length; i++)
            {
                for (int j = i + 1; j < btn.Length; j++)
                {
                    if (btn[i].Enabled == false && btn[j].Enabled == false)
                    {   //Nếu 2 button đều đã mở thì kiểm tra tiếp xem tag của 2 button có bằng nhau không, nếu bằng nhau thì xóa button.
                        if (btn[i].Tag.ToString() == btn[j].Tag.ToString())
                        {
                            if (flagOnOffmusic == 1)
                            {
                                if (flagSound == 1)
                                    sound.correctSound();
                                else
                                    sound.Off_Sound_1();
                            }
                            System.Threading.Thread.Sleep(700);
                            btn[i].Enabled = true;
                            btn[j].Enabled = true;
                            btn[i].Visible = false;
                            btn[j].Visible = false;
                            Score = Score + 10;
                            lbScore.Text = Score.ToString();
                            dem++;
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(700);
                            if (flagOnOffmusic == 1)
                            {
                                if (flagSound == 1)
                                    sound.wrongSound();
                                else
                                    sound.Off_Sound_2();
                            }
                            btn[i].Enabled = true;
                            btn[j].Enabled = true;
                            btn[i].Visible = true;
                            btn[j].Visible = true;
                            if (Score > 0)
                                Score = Score - 5;
                            lbScore.Text = Score.ToString();
                            btn[i].BackgroundImage = Image.FromFile(Application.StartupPath + "\\pic\\icon default\\pikachu-pokemon.png");
                            btn[j].BackgroundImage = Image.FromFile(Application.StartupPath + "\\pic\\icon default\\pikachu-pokemon.png");
                            btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                            btn[j].BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
            }
        }
        private void Notify()
        {
            int so1, so2, KQ;
            if (dem == btn.Length / 2)
            {
                dem = 0;
                so1 = Int32.Parse(lbScore.Text);
                so2 = countertime;
                KQ = so1 + so2;
                loadData = 1;
                timer1.Stop();
                btStart.Enabled = false;
                btStop.Enabled = false;
                DesignButtonOff();
                MessageBox.Show("Trò chơi đã kết thúc! Bạn đã làm rất tốt!\n" + "\nĐiểm của bạn : " +
                  KQ + "\nThời gian chơi còn lại: " +
                  countertime.ToString(), "Chúc mừng");
                Read();
                Write(KQ);
            }
        }
        #endregion

        #region Thao tác button
        private void visible()
        {
            lbScore.Visible = true;
            lbTime.Visible = true;
            progressBar1.Visible = true;
        }
        private void invisible()
        {

            lbTime.Visible = false;
            progressBar1.Visible = false;
        }
        private void DesignButtonOff()
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
        private void DesignButtonOn()
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

        #region Lật hình (2 hình giống nhau)
        //private void RanDom()
        //{
        //    //Nửa mảng button cho random các giá trị từ 0 tới 37      
        //    ArrayList list = new ArrayList();
        //    for (int i = 0; i < btn.Length / 2; i++)
        //    {
        //        int j = rd.Next(1, 26);
        //        btn[i].Tag = j;
        //        list.Add(j);//Lưu các giá trị đã random vào trong list.                           
        //    }
        //    for (int i = btn.Length / 2; i < btn.Length; i++)
        //    {
        //        int x = rd.Next(list.Count); // Lấy ngẫu nhiên 1 index trong list.
        //        btn[i].Tag = list[x];//random phần tử có index x trong list.              
        //        list.RemoveAt(x);//Xóa phần tử đã được random trong list.               
        //    }
        //}
        //private void btn_Click(object sender, EventArgs e)
        //{
        //    Button bt = sender as Button;
        //    bt.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon alphabet\\" + bt.Tag.ToString() + ".jfif");
        //    bt.BackgroundImageLayout = ImageLayout.Stretch;
        //    bt.Enabled = false;
        //    check();
        //    Notify();
        //}
        #endregion

        #region Click button
        private void Start()
        {
            if(flagPlayed == false)
                RanDom();
            loadData = 0;
            Score = 0;
            lbScore.Text = Score.ToString();
            pictureBox1.Visible = true;
            pnDiem.Visible = true;
            timer1.Enabled = true;
            timer1.Start();
            btStart.Enabled = false;
            btStop.Enabled = true;
            btReplay.Enabled = true;
            lbTime.Text = countertime.ToString();
            visible();
            DesignButtonOff();
            DesignButtonOn();
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Enabled = true;
            }
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            Start();    
        }
        private void Stop()
        {
            flagPlayed = true;
            timer1.Stop();
            btStart.Enabled = true;
            btStop.Enabled = false;
            DesignButtonOff();
            DesignButtonOn();
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Enabled = false;
            }
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
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
                flagPlayed = false;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                visible();
                btStart.Enabled = true;
                btStop.Enabled = false;
                DesignButtonOff();
                DesignButtonOn();
                Score = 0;
                lbScore.Text = Score.ToString();
                pnHinh.Visible = false;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Visible = false;
                }
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].BackgroundImage = Image.FromFile((Application.StartupPath + "\\pic\\icon default\\pikachu-pokemon.png"));
                }
                pnHinh.Visible = true;
                if (RankMode == RankModeEasy)
                {
                    de();
                }
                else
                {
                    if (RankMode == RanhModeNormal)
                    {
                        trungBinh();
                    }
                    else
                    {
                        kho();
                    }
                }
                progressBar1.Maximum = countertime;
                progressBar1.Value = countertime;
                timer1.Stop();
                lbTime.Text = countertime.ToString();
            }
        }
        private void btReplay_Click(object sender, EventArgs e)
        {
            Replay();           
        }
        private void Exit()
        {
            Close();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion
        
        #region Thời gian
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loadData == 0)
            {
                countertime--;
                lbTime.Text = countertime.ToString();
                progressBar1.Increment(-1);
                if (progressBar1.Value == 0)
                {
                    timer1.Stop();
                    lbTime.Text = countertime.ToString();
                    progressBar1.Value = countertime;
                    btStart.Enabled = false;
                    btStop.Enabled = false;
                    DesignButtonOff();
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            else
            {
                btStop.Enabled = false;
                DesignButtonOff();
                timer1.Stop();
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
                pnHinh.Size = new Size(827, 703);
                pictureBox1.Visible = true;
                pnDiem.Visible = true;
                progressBar2.Visible = false;
                menu.Visible = true;
                pnHinh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon default\\pokemon_nature.jpg");
            }
        }
        #endregion

        #region Độ khó
        private void kho()
        {
            flag = 0;
            timer1.Stop();
            countertime = 100;
            progressBar1.Maximum = countertime;
            progressBar1.Value = countertime;
            btStop.Enabled = false;
            btReplay.Enabled = false;
            btStart.Enabled = true;
            n = 42;
            btn = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(100, 100);
                btn[i].Text = "";
                btn[i].BackgroundImage = Image.FromFile
                    (Application.StartupPath + "\\pic\\icon default\\pikachu-pokemon.png");
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Location = new Point(45 + k * 105, j * 100 - 30);
                btn[i].Visible = true;
                btn[i].BackColor = Color.Coral;
                pnHinh.Controls.Add(btn[i]);
                k++;
                if (k == 7)
                {
                    k = 0; j++;
                }
            }
            DesignButtonOn();
            DesignButtonOff();
        }
        private void trungBinh()
        {
            flag = 0;
            timer1.Stop();
            countertime = 60;
            progressBar1.Maximum = countertime;
            progressBar1.Value = countertime;
            btStop.Enabled = false;
            btReplay.Enabled = false;
            btStart.Enabled = true;
            n = 30;
            btn = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(100, 100);
                btn[i].Text = "";
                btn[i].BackgroundImage = Image.FromFile
                    (Application.StartupPath + "\\pic\\icon default\\pikachu-pokemon.png");
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Location = new Point(100 + k * 105, 20 + j * 100);
                btn[i].Enabled = false;
                btn[i].Visible = true;
                btn[i].BackColor = Color.Coral;
                pnHinh.Controls.Add(btn[i]);
                k++;
                if (k == 6)
                {
                    k = 0; j++;
                }
            }
            DesignButtonOn();
            DesignButtonOff();
        }
        private void de()
        {         
            flag = 0;
            timer1.Stop();
            countertime = 30;
            progressBar1.Maximum = countertime;
            progressBar1.Value = countertime;
            btStop.Enabled = false;
            btReplay.Enabled = false;
            btStart.Enabled = true;
            n = 16;
            btn = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(100, 100);
                btn[i].Text = "";
                btn[i].BackgroundImage = Image.FromFile
                    (Application.StartupPath + "\\pic\\icon default\\pikachu-pokemon.png");
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Location = new Point(200 + k * 105, 90 + j * 100);
                btn[i].Enabled = false;
                btn[i].Visible = true;
                btn[i].BackColor = Color.Coral;
                pnHinh.Controls.Add(btn[i]);
                k++;
                if (k == 4)
                {
                    k = 0; j++;
                }
            }
            DesignButtonOn();
            DesignButtonOff();
        }
        private void dễToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnHinh.Visible = false;
            RankMode = RankModeEasy;
            if (flag == 0)
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Visible = false;
                }
            }
            list.Clear();
            dem = 0;
            de();
            pnHinh.Visible = true;
        }

        private void trungBìnhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnHinh.Visible = false;
            RankMode = RanhModeNormal;
            if (flag == 0)
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Visible = false;
                }
            }
            list.Clear();
            dem = 0;
            trungBinh();
            pnHinh.Visible = true;
        }

        private void khóToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnHinh.Visible = false;
            RankMode = RankModeDifficult;
            if (flag == 0)
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Visible = false;
                }
            }
            list.Clear();
            dem = 0;
            kho();
            pnHinh.Visible = true;

        }
        #endregion

        #region Đọc ghi file txt
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
                    using(StreamWriter streamWriter = new StreamWriter(RankMode))
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
                            if(arrayMaxScore[i] < KQ)
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

        #region Lựa chọn
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
        private void tắtNhạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnOffMusic();
        }
        private void TurnOffSound()
        {
            if (tắtTiếngToolStripMenuItem.Text == "Tắt tiếng")
                tắtTiếngToolStripMenuItem.Text = "Bật tiếng";
            else
                tắtTiếngToolStripMenuItem.Text = "Tắt tiếng";
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
        private void tắtTiếngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnOffSound();
        }
        private void Guide()
        {
            HuongDanLH frm = new HuongDanLH();
            frm.Show();
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
                case Keys.F1:
                    de();
                    return true;
                case Keys.F2:
                    trungBinh();
                    return true;
                case Keys.F3:
                    kho();
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
    }
}
