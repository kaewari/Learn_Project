
namespace ChuongTrinhHocTapChoBe.Game
{
    partial class GameLatHinh
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
            this.lbHuongDan = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.lbGioiThieu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHuongDan
            // 
            this.lbHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHuongDan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHuongDan.ForeColor = System.Drawing.Color.Black;
            this.lbHuongDan.Location = new System.Drawing.Point(12, 9);
            this.lbHuongDan.Name = "lbHuongDan";
            this.lbHuongDan.Size = new System.Drawing.Size(958, 343);
            this.lbHuongDan.TabIndex = 1;
            this.lbHuongDan.Text = "label1";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(438, 364);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(113, 48);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "button1";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.Location = new System.Drawing.Point(451, 237);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(83, 42);
            this.btTiepTuc.TabIndex = 3;
            this.btTiepTuc.Text = "button1";
            this.btTiepTuc.UseVisualStyleBackColor = true;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click);
            // 
            // lbGioiThieu
            // 
            this.lbGioiThieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGioiThieu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGioiThieu.Location = new System.Drawing.Point(12, 9);
            this.lbGioiThieu.Name = "lbGioiThieu";
            this.lbGioiThieu.Size = new System.Drawing.Size(958, 211);
            this.lbGioiThieu.TabIndex = 2;
            this.lbGioiThieu.Text = "label1";
            // 
            // GameLatHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btTiepTuc);
            this.Controls.Add(this.lbGioiThieu);
            this.Controls.Add(this.lbHuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameLatHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHuongDan;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btTiepTuc;
        private System.Windows.Forms.Label lbGioiThieu;
    }
}