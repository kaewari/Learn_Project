
namespace ChuongTrinhHocTapChoBe.Game
{
    partial class GameChonHinh
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
            this.btStart = new System.Windows.Forms.Button();
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.lbGioiThieu = new System.Windows.Forms.Label();
            this.lbHuongDan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(441, 385);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(112, 56);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "button1";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click_1);
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.Location = new System.Drawing.Point(452, 275);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(80, 45);
            this.btTiepTuc.TabIndex = 7;
            this.btTiepTuc.Text = "button1";
            this.btTiepTuc.UseVisualStyleBackColor = true;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click_1);
            // 
            // lbGioiThieu
            // 
            this.lbGioiThieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGioiThieu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGioiThieu.Location = new System.Drawing.Point(39, 56);
            this.lbGioiThieu.Name = "lbGioiThieu";
            this.lbGioiThieu.Size = new System.Drawing.Size(907, 196);
            this.lbGioiThieu.TabIndex = 6;
            this.lbGioiThieu.Text = "label1";
            // 
            // lbHuongDan
            // 
            this.lbHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHuongDan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHuongDan.Location = new System.Drawing.Point(39, 56);
            this.lbHuongDan.Name = "lbHuongDan";
            this.lbHuongDan.Size = new System.Drawing.Size(907, 308);
            this.lbHuongDan.TabIndex = 5;
            this.lbHuongDan.Text = "label1";
            // 
            // GameChonHinh
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
            this.Name = "GameChonHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameChonHinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.GameChonHinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btTiepTuc;
        private System.Windows.Forms.Label lbGioiThieu;
        private System.Windows.Forms.Label lbHuongDan;
    }
}