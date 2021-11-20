
namespace ChuongTrinhHocTapChoBe
{
    partial class parentpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parentpass));
            this.lbMatMa = new System.Windows.Forms.Label();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.pass3 = new System.Windows.Forms.TextBox();
            this.pass4 = new System.Windows.Forms.TextBox();
            this.llbQuenMatMa = new System.Windows.Forms.LinkLabel();
            this.pnPass = new System.Windows.Forms.Panel();
            this.demThoiGianDong = new System.Windows.Forms.Timer(this.components);
            this.doiPassTick = new System.Windows.Forms.Timer(this.components);
            this.pnPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMatMa
            // 
            this.lbMatMa.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMatMa.ForeColor = System.Drawing.Color.White;
            this.lbMatMa.Location = new System.Drawing.Point(19, 38);
            this.lbMatMa.Name = "lbMatMa";
            this.lbMatMa.Size = new System.Drawing.Size(603, 57);
            this.lbMatMa.TabIndex = 0;
            this.lbMatMa.Text = "NHẬP MẬT MÃ";
            this.lbMatMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pass1
            // 
            this.pass1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass1.Location = new System.Drawing.Point(24, 5);
            this.pass1.MaxLength = 1;
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(88, 118);
            this.pass1.TabIndex = 1;
            this.pass1.Tag = "passChar";
            this.pass1.UseSystemPasswordChar = true;
            this.pass1.TextChanged += new System.EventHandler(this.pass4_TextChanged_1);
            // 
            // pass2
            // 
            this.pass2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass2.Location = new System.Drawing.Point(178, 5);
            this.pass2.MaxLength = 1;
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(88, 118);
            this.pass2.TabIndex = 1;
            this.pass2.Tag = "passChar";
            this.pass2.UseSystemPasswordChar = true;
            this.pass2.TextChanged += new System.EventHandler(this.pass4_TextChanged_1);
            // 
            // pass3
            // 
            this.pass3.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass3.Location = new System.Drawing.Point(328, 5);
            this.pass3.MaxLength = 1;
            this.pass3.Name = "pass3";
            this.pass3.Size = new System.Drawing.Size(88, 118);
            this.pass3.TabIndex = 1;
            this.pass3.Tag = "passChar";
            this.pass3.UseSystemPasswordChar = true;
            this.pass3.TextChanged += new System.EventHandler(this.pass4_TextChanged_1);
            // 
            // pass4
            // 
            this.pass4.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass4.Location = new System.Drawing.Point(480, 5);
            this.pass4.MaxLength = 1;
            this.pass4.Name = "pass4";
            this.pass4.Size = new System.Drawing.Size(88, 118);
            this.pass4.TabIndex = 1;
            this.pass4.Tag = "passChar";
            this.pass4.UseSystemPasswordChar = true;
            this.pass4.TextChanged += new System.EventHandler(this.pass4_TextChanged_1);
            // 
            // llbQuenMatMa
            // 
            this.llbQuenMatMa.AutoSize = true;
            this.llbQuenMatMa.Location = new System.Drawing.Point(523, 270);
            this.llbQuenMatMa.Name = "llbQuenMatMa";
            this.llbQuenMatMa.Size = new System.Drawing.Size(99, 20);
            this.llbQuenMatMa.TabIndex = 2;
            this.llbQuenMatMa.TabStop = true;
            this.llbQuenMatMa.Text = "Bạn đã quên?";
            this.llbQuenMatMa.Click += new System.EventHandler(this.llbQuenMatMa_Click);
            // 
            // pnPass
            // 
            this.pnPass.Controls.Add(this.pass3);
            this.pnPass.Controls.Add(this.pass1);
            this.pnPass.Controls.Add(this.pass4);
            this.pnPass.Controls.Add(this.pass2);
            this.pnPass.Location = new System.Drawing.Point(19, 116);
            this.pnPass.Name = "pnPass";
            this.pnPass.Size = new System.Drawing.Size(594, 126);
            this.pnPass.TabIndex = 3;
            // 
            // demThoiGianDong
            // 
            this.demThoiGianDong.Enabled = true;
            this.demThoiGianDong.Interval = 1000;
            this.demThoiGianDong.Tick += new System.EventHandler(this.demThoiGianDong_Tick);
            // 
            // doiPassTick
            // 
            this.doiPassTick.Enabled = true;
            this.doiPassTick.Interval = 1;
            this.doiPassTick.Tick += new System.EventHandler(this.doiPassTick_Tick);
            // 
            // parentpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 299);
            this.Controls.Add(this.pnPass);
            this.Controls.Add(this.llbQuenMatMa);
            this.Controls.Add(this.lbMatMa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "parentpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "***** Nhập mã bảo mật *****";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.parentpass_FormClosing);
            this.pnPass.ResumeLayout(false);
            this.pnPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMatMa;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.TextBox pass3;
        private System.Windows.Forms.TextBox pass4;
        private System.Windows.Forms.LinkLabel llbQuenMatMa;
        private System.Windows.Forms.Panel pnPass;
        private System.Windows.Forms.Timer demThoiGianDong;
        private System.Windows.Forms.Timer doiPassTick;
    }
}