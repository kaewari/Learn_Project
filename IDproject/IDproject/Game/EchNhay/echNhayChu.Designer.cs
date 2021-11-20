
namespace ChuongTrinhHocTapChoBe.Game.EchNhay
{
    partial class echNhayChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(echNhayChu));
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.picEch = new System.Windows.Forms.PictureBox();
            this.ckLoa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐIỂM:";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.BackColor = System.Drawing.Color.Transparent;
            this.lbDiem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDiem.ForeColor = System.Drawing.Color.Yellow;
            this.lbDiem.Location = new System.Drawing.Point(121, 30);
            this.lbDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(29, 35);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "0";
            // 
            // picEch
            // 
            this.picEch.BackColor = System.Drawing.Color.Transparent;
            this.picEch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEch.BackgroundImage")));
            this.picEch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEch.Location = new System.Drawing.Point(671, 18);
            this.picEch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picEch.Name = "picEch";
            this.picEch.Size = new System.Drawing.Size(123, 123);
            this.picEch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEch.TabIndex = 2;
            this.picEch.TabStop = false;
            // 
            // ckLoa
            // 
            this.ckLoa.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckLoa.BackColor = System.Drawing.Color.Transparent;
            this.ckLoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckLoa.BackgroundImage")));
            this.ckLoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckLoa.Location = new System.Drawing.Point(881, 38);
            this.ckLoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckLoa.Name = "ckLoa";
            this.ckLoa.Size = new System.Drawing.Size(55, 51);
            this.ckLoa.TabIndex = 5;
            this.ckLoa.UseVisualStyleBackColor = false;
            this.ckLoa.Click += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // echNhayChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 758);
            this.Controls.Add(this.ckLoa);
            this.Controls.Add(this.picEch);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "echNhayChu";
            this.Text = "ẾCH NHẢY BẢNG CHỮ CAI TIẾNG ANH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.echNhayChu_FormClosing);
            this.Load += new System.EventHandler(this.echNhayChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.PictureBox picEch;
        private System.Windows.Forms.CheckBox ckLoa;
    }
}