
namespace ChuongTrinhHocTapChoBe.Game.DuaXeHocTiengAnh
{
    partial class DuaXe_CauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuaXe_CauHoi));
            this.btnDapAn1 = new System.Windows.Forms.Button();
            this.btnDapAn2 = new System.Windows.Forms.Button();
            this.btnDapAn3 = new System.Windows.Forms.Button();
            this.btnDapAn4 = new System.Windows.Forms.Button();
            this.pnCauHoi = new System.Windows.Forms.Panel();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.thanhQuaTrinh = new System.Windows.Forms.ProgressBar();
            this.thoiGianCho = new System.Windows.Forms.Timer(this.components);
            this.pnCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDapAn1
            // 
            this.btnDapAn1.Location = new System.Drawing.Point(26, 289);
            this.btnDapAn1.Name = "btnDapAn1";
            this.btnDapAn1.Size = new System.Drawing.Size(349, 74);
            this.btnDapAn1.TabIndex = 1;
            this.btnDapAn1.Tag = "dapAn";
            this.btnDapAn1.Text = "Đáp Án";
            this.btnDapAn1.UseVisualStyleBackColor = true;
            this.btnDapAn1.Click += new System.EventHandler(this.ChonDapAn);
            // 
            // btnDapAn2
            // 
            this.btnDapAn2.Location = new System.Drawing.Point(387, 289);
            this.btnDapAn2.Name = "btnDapAn2";
            this.btnDapAn2.Size = new System.Drawing.Size(349, 74);
            this.btnDapAn2.TabIndex = 1;
            this.btnDapAn2.Tag = "dapAn";
            this.btnDapAn2.Text = "Đáp Án";
            this.btnDapAn2.UseVisualStyleBackColor = true;
            this.btnDapAn2.Click += new System.EventHandler(this.ChonDapAn);
            // 
            // btnDapAn3
            // 
            this.btnDapAn3.Location = new System.Drawing.Point(26, 369);
            this.btnDapAn3.Name = "btnDapAn3";
            this.btnDapAn3.Size = new System.Drawing.Size(349, 74);
            this.btnDapAn3.TabIndex = 1;
            this.btnDapAn3.Tag = "dapAn";
            this.btnDapAn3.Text = "Đáp Án";
            this.btnDapAn3.UseVisualStyleBackColor = true;
            this.btnDapAn3.Click += new System.EventHandler(this.ChonDapAn);
            // 
            // btnDapAn4
            // 
            this.btnDapAn4.Location = new System.Drawing.Point(387, 369);
            this.btnDapAn4.Name = "btnDapAn4";
            this.btnDapAn4.Size = new System.Drawing.Size(349, 74);
            this.btnDapAn4.TabIndex = 1;
            this.btnDapAn4.Tag = "dapAn";
            this.btnDapAn4.Text = "Đáp Án";
            this.btnDapAn4.UseVisualStyleBackColor = true;
            this.btnDapAn4.Click += new System.EventHandler(this.ChonDapAn);
            // 
            // pnCauHoi
            // 
            this.pnCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCauHoi.Controls.Add(this.lbCauHoi);
            this.pnCauHoi.Location = new System.Drawing.Point(17, 13);
            this.pnCauHoi.Name = "pnCauHoi";
            this.pnCauHoi.Size = new System.Drawing.Size(728, 259);
            this.pnCauHoi.TabIndex = 2;
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCauHoi.Location = new System.Drawing.Point(51, 53);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(626, 148);
            this.lbCauHoi.TabIndex = 0;
            this.lbCauHoi.Text = "Câu hỏi sẽ xuất hiện ở đây";
            this.lbCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thanhQuaTrinh
            // 
            this.thanhQuaTrinh.Location = new System.Drawing.Point(-2, -6);
            this.thanhQuaTrinh.Name = "thanhQuaTrinh";
            this.thanhQuaTrinh.Size = new System.Drawing.Size(765, 13);
            this.thanhQuaTrinh.TabIndex = 3;
            // 
            // thoiGianCho
            // 
            this.thoiGianCho.Enabled = true;
            this.thoiGianCho.Tick += new System.EventHandler(this.thoiGianCho_Tick);
            // 
            // DuaXe_CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 454);
            this.Controls.Add(this.thanhQuaTrinh);
            this.Controls.Add(this.pnCauHoi);
            this.Controls.Add(this.btnDapAn4);
            this.Controls.Add(this.btnDapAn3);
            this.Controls.Add(this.btnDapAn2);
            this.Controls.Add(this.btnDapAn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DuaXe_CauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả lời câu hỏi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DuaXe_CauHoi_FormClosing);
            this.Load += new System.EventHandler(this.DuaXe_CauHoi_Load);
            this.pnCauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDapAn1;
        private System.Windows.Forms.Button btnDapAn2;
        private System.Windows.Forms.Button btnDapAn3;
        private System.Windows.Forms.Button btnDapAn4;
        private System.Windows.Forms.Panel pnCauHoi;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.ProgressBar thanhQuaTrinh;
        private System.Windows.Forms.Timer thoiGianCho;
    }
}