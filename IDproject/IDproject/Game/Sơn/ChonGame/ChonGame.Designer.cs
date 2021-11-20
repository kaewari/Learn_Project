
namespace ChuongTrinhHocTapChoBe.Game
{
    partial class ChonGame
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
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.lbHuongDan = new System.Windows.Forms.Label();
            this.lbChuoi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.checkLatHinh = new System.Windows.Forms.RadioButton();
            this.checkChonHinh = new System.Windows.Forms.RadioButton();
            this.checkBangVe = new System.Windows.Forms.RadioButton();
            this.checkDuaXe = new System.Windows.Forms.RadioButton();
            this.checkHungTao = new System.Windows.Forms.RadioButton();
            this.checkSoThu = new System.Windows.Forms.RadioButton();
            this.checkEchNhay = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.BackColor = System.Drawing.Color.Transparent;
            this.btTiepTuc.ForeColor = System.Drawing.Color.Black;
            this.btTiepTuc.Location = new System.Drawing.Point(301, 483);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(69, 29);
            this.btTiepTuc.TabIndex = 11;
            this.btTiepTuc.Text = "button1";
            this.btTiepTuc.UseVisualStyleBackColor = false;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click);
            // 
            // lbHuongDan
            // 
            this.lbHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHuongDan.Location = new System.Drawing.Point(61, 47);
            this.lbHuongDan.Name = "lbHuongDan";
            this.lbHuongDan.Size = new System.Drawing.Size(543, 61);
            this.lbHuongDan.TabIndex = 9;
            this.lbHuongDan.Text = "label1";
            // 
            // lbChuoi
            // 
            this.lbChuoi.BackColor = System.Drawing.Color.Transparent;
            this.lbChuoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbChuoi.ForeColor = System.Drawing.Color.Yellow;
            this.lbChuoi.Location = new System.Drawing.Point(0, 515);
            this.lbChuoi.Name = "lbChuoi";
            this.lbChuoi.Size = new System.Drawing.Size(676, 25);
            this.lbChuoi.TabIndex = 15;
            this.lbChuoi.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(197, 152);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(407, 27);
            this.txtPlayerName.TabIndex = 16;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lbPlayerName.Location = new System.Drawing.Point(40, 146);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(151, 33);
            this.lbPlayerName.TabIndex = 17;
            this.lbPlayerName.Text = "Tên người chơi:";
            // 
            // checkLatHinh
            // 
            this.checkLatHinh.AutoSize = true;
            this.checkLatHinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkLatHinh.Location = new System.Drawing.Point(40, 213);
            this.checkLatHinh.Name = "checkLatHinh";
            this.checkLatHinh.Size = new System.Drawing.Size(149, 32);
            this.checkLatHinh.TabIndex = 18;
            this.checkLatHinh.TabStop = true;
            this.checkLatHinh.Text = "radioButton1";
            this.checkLatHinh.UseVisualStyleBackColor = true;
            this.checkLatHinh.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // checkChonHinh
            // 
            this.checkChonHinh.AutoSize = true;
            this.checkChonHinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkChonHinh.Location = new System.Drawing.Point(40, 251);
            this.checkChonHinh.Name = "checkChonHinh";
            this.checkChonHinh.Size = new System.Drawing.Size(149, 32);
            this.checkChonHinh.TabIndex = 18;
            this.checkChonHinh.TabStop = true;
            this.checkChonHinh.Text = "radioButton1";
            this.checkChonHinh.UseVisualStyleBackColor = true;
            this.checkChonHinh.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // checkBangVe
            // 
            this.checkBangVe.AutoSize = true;
            this.checkBangVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBangVe.Location = new System.Drawing.Point(40, 289);
            this.checkBangVe.Name = "checkBangVe";
            this.checkBangVe.Size = new System.Drawing.Size(149, 32);
            this.checkBangVe.TabIndex = 18;
            this.checkBangVe.TabStop = true;
            this.checkBangVe.Text = "radioButton1";
            this.checkBangVe.UseVisualStyleBackColor = true;
            this.checkBangVe.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // checkDuaXe
            // 
            this.checkDuaXe.AutoSize = true;
            this.checkDuaXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDuaXe.Location = new System.Drawing.Point(40, 327);
            this.checkDuaXe.Name = "checkDuaXe";
            this.checkDuaXe.Size = new System.Drawing.Size(149, 32);
            this.checkDuaXe.TabIndex = 18;
            this.checkDuaXe.TabStop = true;
            this.checkDuaXe.Text = "radioButton1";
            this.checkDuaXe.UseVisualStyleBackColor = true;
            this.checkDuaXe.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // checkHungTao
            // 
            this.checkHungTao.AutoSize = true;
            this.checkHungTao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkHungTao.Location = new System.Drawing.Point(40, 403);
            this.checkHungTao.Name = "checkHungTao";
            this.checkHungTao.Size = new System.Drawing.Size(149, 32);
            this.checkHungTao.TabIndex = 18;
            this.checkHungTao.TabStop = true;
            this.checkHungTao.Text = "radioButton1";
            this.checkHungTao.UseVisualStyleBackColor = true;
            this.checkHungTao.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // checkSoThu
            // 
            this.checkSoThu.AutoSize = true;
            this.checkSoThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkSoThu.Location = new System.Drawing.Point(40, 441);
            this.checkSoThu.Name = "checkSoThu";
            this.checkSoThu.Size = new System.Drawing.Size(149, 32);
            this.checkSoThu.TabIndex = 18;
            this.checkSoThu.TabStop = true;
            this.checkSoThu.Text = "radioButton1";
            this.checkSoThu.UseVisualStyleBackColor = true;
            this.checkSoThu.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // checkEchNhay
            // 
            this.checkEchNhay.AutoSize = true;
            this.checkEchNhay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEchNhay.Location = new System.Drawing.Point(40, 365);
            this.checkEchNhay.Name = "checkEchNhay";
            this.checkEchNhay.Size = new System.Drawing.Size(149, 32);
            this.checkEchNhay.TabIndex = 18;
            this.checkEchNhay.TabStop = true;
            this.checkEchNhay.Text = "radioButton1";
            this.checkEchNhay.UseVisualStyleBackColor = true;
            this.checkEchNhay.CheckedChanged += new System.EventHandler(this.checkLatHinh_CheckedChanged);
            // 
            // ChonGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 567);
            this.Controls.Add(this.checkEchNhay);
            this.Controls.Add(this.checkSoThu);
            this.Controls.Add(this.checkHungTao);
            this.Controls.Add(this.checkDuaXe);
            this.Controls.Add(this.checkBangVe);
            this.Controls.Add(this.checkChonHinh);
            this.Controls.Add(this.checkLatHinh);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbChuoi);
            this.Controls.Add(this.btTiepTuc);
            this.Controls.Add(this.lbHuongDan);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "ChonGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.ChonGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btTiepTuc;
        private System.Windows.Forms.Label lbHuongDan;
        private System.Windows.Forms.Label lbChuoi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.RadioButton checkLatHinh;
        private System.Windows.Forms.RadioButton checkChonHinh;
        private System.Windows.Forms.RadioButton checkBangVe;
        private System.Windows.Forms.RadioButton checkDuaXe;
        private System.Windows.Forms.RadioButton checkHungTao;
        private System.Windows.Forms.RadioButton checkSoThu;
        private System.Windows.Forms.RadioButton checkEchNhay;
    }
}