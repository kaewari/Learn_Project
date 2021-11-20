
namespace ChuongTrinhHocTapChoBe.Game
{
    partial class HuongDan
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
            this.lbHuongDan = new System.Windows.Forms.Label();
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Moccasin;
            this.btStart.Location = new System.Drawing.Point(533, 403);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(113, 48);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "button1";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbHuongDan
            // 
            this.lbHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHuongDan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHuongDan.ForeColor = System.Drawing.Color.Black;
            this.lbHuongDan.Location = new System.Drawing.Point(26, 4);
            this.lbHuongDan.Name = "lbHuongDan";
            this.lbHuongDan.Size = new System.Drawing.Size(958, 396);
            this.lbHuongDan.TabIndex = 5;
            this.lbHuongDan.Text = "label1";
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.BackColor = System.Drawing.Color.Moccasin;
            this.btTiepTuc.Location = new System.Drawing.Point(420, 403);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(97, 48);
            this.btTiepTuc.TabIndex = 10;
            this.btTiepTuc.Text = "Tiếp tục";
            this.btTiepTuc.UseVisualStyleBackColor = false;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click);
            // 
            // HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 463);
            this.Controls.Add(this.btTiepTuc);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbHuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbHuongDan;
        private System.Windows.Forms.Button btTiepTuc;
    }
}