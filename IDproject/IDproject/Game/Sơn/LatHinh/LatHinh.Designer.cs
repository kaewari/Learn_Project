
namespace ChuongTrinhHocTapChoBe.Game
{
    partial class LatHinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LatHinh));
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.pnHinh = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lbScore = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.lựaChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dễToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungBìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtNhạcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtTiếngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.âmLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTime = new System.Windows.Forms.Label();
            this.pnDiem = new System.Windows.Forms.Panel();
            this.btReplay = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnHinh.SuspendLayout();
            this.menu.SuspendLayout();
            this.pnDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Cyan;
            this.btStop.Location = new System.Drawing.Point(122, 12);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 47);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Cyan;
            this.btStart.Location = new System.Drawing.Point(20, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(92, 48);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pnHinh
            // 
            this.pnHinh.BackColor = System.Drawing.Color.Gold;
            this.pnHinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnHinh.BackgroundImage")));
            this.pnHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHinh.Controls.Add(this.progressBar2);
            this.pnHinh.Controls.Add(this.lbScore);
            this.pnHinh.Controls.Add(this.menu);
            this.pnHinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnHinh.ForeColor = System.Drawing.Color.Coral;
            this.pnHinh.Location = new System.Drawing.Point(1, 0);
            this.pnHinh.Name = "pnHinh";
            this.pnHinh.Size = new System.Drawing.Size(826, 703);
            this.pnHinh.TabIndex = 0;            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(296, 544);
            this.progressBar2.Maximum = 3;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(596, 29);
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Value = 3;
            // 
            // lbScore
            // 
            this.lbScore.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.Black;
            this.lbScore.Location = new System.Drawing.Point(718, 29);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(109, 43);
            this.lbScore.TabIndex = 1;
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(826, 29);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            this.menu.Visible = false;
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.tắtNhạcToolStripMenuItem,
            this.tắtTiếngToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.âmLượngToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.lựaChọnToolStripMenuItem.Text = "Lựa chọn";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dễToolStripMenuItem,
            this.trungBìnhToolStripMenuItem,
            this.khóToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.levelToolStripMenuItem.Text = "Cấp độ                        ";
            // 
            // dễToolStripMenuItem
            // 
            this.dễToolStripMenuItem.Name = "dễToolStripMenuItem";
            this.dễToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.dễToolStripMenuItem.Text = "Dễ";
            this.dễToolStripMenuItem.Click += new System.EventHandler(this.dễToolStripMenuItem_Click_1);
            // 
            // trungBìnhToolStripMenuItem
            // 
            this.trungBìnhToolStripMenuItem.Name = "trungBìnhToolStripMenuItem";
            this.trungBìnhToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.trungBìnhToolStripMenuItem.Text = "Trung bình";
            this.trungBìnhToolStripMenuItem.Click += new System.EventHandler(this.trungBìnhToolStripMenuItem_Click_1);
            // 
            // khóToolStripMenuItem
            // 
            this.khóToolStripMenuItem.Name = "khóToolStripMenuItem";
            this.khóToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.khóToolStripMenuItem.Text = "Khó";
            this.khóToolStripMenuItem.Click += new System.EventHandler(this.khóToolStripMenuItem_Click_1);
            // 
            // tắtNhạcToolStripMenuItem
            // 
            this.tắtNhạcToolStripMenuItem.Name = "tắtNhạcToolStripMenuItem";
            this.tắtNhạcToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.tắtNhạcToolStripMenuItem.Text = "Tắt nhạc";
            this.tắtNhạcToolStripMenuItem.Click += new System.EventHandler(this.tắtNhạcToolStripMenuItem_Click);
            // 
            // tắtTiếngToolStripMenuItem
            // 
            this.tắtTiếngToolStripMenuItem.Name = "tắtTiếngToolStripMenuItem";
            this.tắtTiếngToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.tắtTiếngToolStripMenuItem.Text = "Bật tiếng";
            this.tắtTiếngToolStripMenuItem.Click += new System.EventHandler(this.tắtTiếngToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // âmLượngToolStripMenuItem
            // 
            this.âmLượngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tăngToolStripMenuItem,
            this.giảmToolStripMenuItem});
            this.âmLượngToolStripMenuItem.Name = "âmLượngToolStripMenuItem";
            this.âmLượngToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.âmLượngToolStripMenuItem.Text = "Âm lượng";
            // 
            // tăngToolStripMenuItem
            // 
            this.tăngToolStripMenuItem.Name = "tăngToolStripMenuItem";
            this.tăngToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.tăngToolStripMenuItem.Text = "Tăng";
            this.tăngToolStripMenuItem.Click += new System.EventHandler(this.tăngToolStripMenuItem_Click);
            // 
            // giảmToolStripMenuItem
            // 
            this.giảmToolStripMenuItem.Name = "giảmToolStripMenuItem";
            this.giảmToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.giảmToolStripMenuItem.Text = "Giảm";
            this.giảmToolStripMenuItem.Click += new System.EventHandler(this.giảmToolStripMenuItem_Click);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.FloralWhite;
            this.lbTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(20, 97);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(194, 51);
            this.lbTime.TabIndex = 0;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDiem
            // 
            this.pnDiem.BackColor = System.Drawing.Color.Cornsilk;
            this.pnDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDiem.Controls.Add(this.btReplay);
            this.pnDiem.Controls.Add(this.btExit);
            this.pnDiem.Controls.Add(this.lbTime);
            this.pnDiem.Controls.Add(this.btStop);
            this.pnDiem.Controls.Add(this.progressBar1);
            this.pnDiem.Controls.Add(this.btStart);
            this.pnDiem.Location = new System.Drawing.Point(821, 282);
            this.pnDiem.Name = "pnDiem";
            this.pnDiem.Size = new System.Drawing.Size(361, 421);
            this.pnDiem.TabIndex = 0;
            // 
            // btReplay
            // 
            this.btReplay.BackColor = System.Drawing.Color.Cyan;
            this.btReplay.Location = new System.Drawing.Point(220, 12);
            this.btReplay.Name = "btReplay";
            this.btReplay.Size = new System.Drawing.Size(104, 47);
            this.btReplay.TabIndex = 2;
            this.btReplay.Text = "Replay";
            this.btReplay.UseVisualStyleBackColor = false;
            this.btReplay.Click += new System.EventHandler(this.btReplay_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Coral;
            this.btExit.Location = new System.Drawing.Point(122, 166);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(92, 49);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.BurlyWood;
            this.progressBar1.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressBar1.Location = new System.Drawing.Point(20, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 29);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LatHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pnDiem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnHinh);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menu;
            this.Name = "LatHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LatHinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LatHinh_FormClosing);
            this.Load += new System.EventHandler(this.LatHinh_Load);
            this.pnHinh.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHinh;
        private System.Windows.Forms.Panel pnDiem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btReplay;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dễToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trungBìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtNhạcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtTiếngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem âmLượngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảmToolStripMenuItem;
    }
}