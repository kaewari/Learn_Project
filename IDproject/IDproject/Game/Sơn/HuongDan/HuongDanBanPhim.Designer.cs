
namespace ChuongTrinhHocTapChoBe.Game.Sơn.HuongDan
{
    partial class HuongDanBanPhim
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
            this.btHet = new System.Windows.Forms.Button();
            this.lbHuongDan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btHet
            // 
            this.btHet.BackColor = System.Drawing.Color.Moccasin;
            this.btHet.Location = new System.Drawing.Point(451, 408);
            this.btHet.Name = "btHet";
            this.btHet.Size = new System.Drawing.Size(97, 48);
            this.btHet.TabIndex = 16;
            this.btHet.Text = "Hết";
            this.btHet.UseVisualStyleBackColor = false;
            this.btHet.Click += new System.EventHandler(this.btTiepTuc_Click);
            // 
            // lbHuongDan
            // 
            this.lbHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHuongDan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHuongDan.ForeColor = System.Drawing.Color.Black;
            this.lbHuongDan.Location = new System.Drawing.Point(24, 9);
            this.lbHuongDan.Name = "lbHuongDan";
            this.lbHuongDan.Size = new System.Drawing.Size(958, 396);
            this.lbHuongDan.TabIndex = 14;
            this.lbHuongDan.Text = "label1";
            // 
            // HuongDanBanPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 463);
            this.Controls.Add(this.btHet);
            this.Controls.Add(this.lbHuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HuongDanBanPhim";
            this.Text = "HuongDanBanPhim";
            this.Load += new System.EventHandler(this.HuongDanBanPhim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHet;
        private System.Windows.Forms.Label lbHuongDan;
    }
}