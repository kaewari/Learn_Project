
namespace ChuongTrinhHocTapChoBe.Game.HungTaoHocToan
{
    partial class HungTao_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HungTao_TrangChu));
            this.picName = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picMusic = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.KiemTra = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // picName
            // 
            this.picName.BackColor = System.Drawing.Color.Transparent;
            this.picName.Image = ((System.Drawing.Image)(resources.GetObject("picName.Image")));
            this.picName.Location = new System.Drawing.Point(12, 86);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(686, 371);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picName.TabIndex = 0;
            this.picName.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(828, 387);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(183, 174);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 0;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picMusic
            // 
            this.picMusic.BackColor = System.Drawing.Color.Transparent;
            this.picMusic.Location = new System.Drawing.Point(1010, 623);
            this.picMusic.Name = "picMusic";
            this.picMusic.Size = new System.Drawing.Size(46, 46);
            this.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMusic.TabIndex = 0;
            this.picMusic.TabStop = false;
            this.picMusic.Click += new System.EventHandler(this.picMusic_Click);
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.Transparent;
            this.picTop.Image = ((System.Drawing.Image)(resources.GetObject("picTop.Image")));
            this.picTop.Location = new System.Drawing.Point(958, 623);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(46, 46);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTop.TabIndex = 0;
            this.picTop.TabStop = false;
            this.picTop.Click += new System.EventHandler(this.optionBox_Click);
            // 
            // KiemTra
            // 
            this.KiemTra.Tick += new System.EventHandler(this.KiemTra_Tick);
            // 
            // HungTao_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picMusic);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HungTao_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò chơi Hứng Táo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HungTao_TrangChu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picMusic;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Timer KiemTra;
    }
}