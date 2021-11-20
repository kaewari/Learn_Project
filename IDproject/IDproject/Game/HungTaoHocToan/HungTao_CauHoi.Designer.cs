
namespace ChuongTrinhHocTapChoBe.Game
{
    partial class HungTao_CauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HungTao_CauHoi));
            this.thanhQuaTrinh = new System.Windows.Forms.ProgressBar();
            this.grB = new System.Windows.Forms.GroupBox();
            this.dapAn2 = new System.Windows.Forms.Button();
            this.dapAn1 = new System.Windows.Forms.Button();
            this.lbGhiKQ = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbPhepTinh = new System.Windows.Forms.Label();
            this.lbSo1 = new System.Windows.Forms.Label();
            this.thoiGianTroi = new System.Windows.Forms.Timer(this.components);
            this.grB.SuspendLayout();
            this.SuspendLayout();
            // 
            // thanhQuaTrinh
            // 
            this.thanhQuaTrinh.Location = new System.Drawing.Point(154, 9);
            this.thanhQuaTrinh.Name = "thanhQuaTrinh";
            this.thanhQuaTrinh.Size = new System.Drawing.Size(299, 29);
            this.thanhQuaTrinh.TabIndex = 7;
            // 
            // grB
            // 
            this.grB.Controls.Add(this.dapAn2);
            this.grB.Controls.Add(this.dapAn1);
            this.grB.Controls.Add(this.lbGhiKQ);
            this.grB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grB.Location = new System.Drawing.Point(12, 200);
            this.grB.Name = "grB";
            this.grB.Size = new System.Drawing.Size(600, 142);
            this.grB.TabIndex = 6;
            this.grB.TabStop = false;
            this.grB.Text = "Chọn đáp án";
            // 
            // dapAn2
            // 
            this.dapAn2.Location = new System.Drawing.Point(349, 36);
            this.dapAn2.Name = "dapAn2";
            this.dapAn2.Size = new System.Drawing.Size(211, 68);
            this.dapAn2.TabIndex = 2;
            this.dapAn2.Text = "dapAn2";
            this.dapAn2.UseVisualStyleBackColor = true;
            this.dapAn2.Click += new System.EventHandler(this.dapAn_Click);
            // 
            // dapAn1
            // 
            this.dapAn1.Location = new System.Drawing.Point(38, 36);
            this.dapAn1.Name = "dapAn1";
            this.dapAn1.Size = new System.Drawing.Size(211, 68);
            this.dapAn1.TabIndex = 2;
            this.dapAn1.Text = "dapAn1";
            this.dapAn1.UseVisualStyleBackColor = true;
            this.dapAn1.Click += new System.EventHandler(this.dapAn_Click);
            // 
            // lbGhiKQ
            // 
            this.lbGhiKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGhiKQ.ForeColor = System.Drawing.Color.Red;
            this.lbGhiKQ.Location = new System.Drawing.Point(222, 108);
            this.lbGhiKQ.Name = "lbGhiKQ";
            this.lbGhiKQ.Size = new System.Drawing.Size(136, 31);
            this.lbGhiKQ.TabIndex = 1;
            this.lbGhiKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            this.lbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSo2.ForeColor = System.Drawing.Color.Red;
            this.lbSo2.Location = new System.Drawing.Point(402, 58);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(136, 129);
            this.lbSo2.TabIndex = 3;
            this.lbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPhepTinh
            // 
            this.lbPhepTinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPhepTinh.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhepTinh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPhepTinh.Location = new System.Drawing.Point(234, 58);
            this.lbPhepTinh.Name = "lbPhepTinh";
            this.lbPhepTinh.Size = new System.Drawing.Size(136, 129);
            this.lbPhepTinh.TabIndex = 4;
            this.lbPhepTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo1
            // 
            this.lbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSo1.ForeColor = System.Drawing.Color.Red;
            this.lbSo1.Location = new System.Drawing.Point(62, 58);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(136, 129);
            this.lbSo1.TabIndex = 5;
            this.lbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thoiGianTroi
            // 
            this.thoiGianTroi.Enabled = true;
            this.thoiGianTroi.Tick += new System.EventHandler(this.thoiGianTroi_Tick);
            // 
            // HungTao_CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 350);
            this.Controls.Add(this.thanhQuaTrinh);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbPhepTinh);
            this.Controls.Add(this.lbSo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HungTao_CauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả lời câu hỏi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HungTao_CauHoi_FormClosed);
            this.Load += new System.EventHandler(this.HungTao_CauHoi_Load);
            this.grB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar thanhQuaTrinh;
        private System.Windows.Forms.GroupBox grB;
        private System.Windows.Forms.Button dapAn2;
        private System.Windows.Forms.Button dapAn1;
        private System.Windows.Forms.Label lbGhiKQ;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbPhepTinh;
        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Timer thoiGianTroi;
    }
}