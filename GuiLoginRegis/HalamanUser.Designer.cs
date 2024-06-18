namespace GuiLoginRegis
{
    partial class HalamanUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KirimButton = new System.Windows.Forms.Button();
            this.NamaBox = new System.Windows.Forms.MaskedTextBox();
            this.HariBox = new System.Windows.Forms.MaskedTextBox();
            this.TanggalBox = new System.Windows.Forms.MaskedTextBox();
            this.JamBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELAMAT DATANG DI APLIKASI TELKOM MEDIKA!";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(344, 23);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Silahkan melakukan booking jadwal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jam";
            // 
            // KirimButton
            // 
            this.KirimButton.Location = new System.Drawing.Point(348, 407);
            this.KirimButton.Name = "KirimButton";
            this.KirimButton.Size = new System.Drawing.Size(75, 23);
            this.KirimButton.TabIndex = 7;
            this.KirimButton.Text = "KIRIM";
            this.KirimButton.UseVisualStyleBackColor = true;
            this.KirimButton.Click += new System.EventHandler(this.KirimButton_Click);
            // 
            // NamaBox
            // 
            this.NamaBox.Location = new System.Drawing.Point(26, 156);
            this.NamaBox.Name = "NamaBox";
            this.NamaBox.Size = new System.Drawing.Size(332, 20);
            this.NamaBox.TabIndex = 8;
            this.NamaBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NamaBox_MaskInputRejected);
            // 
            // HariBox
            // 
            this.HariBox.Location = new System.Drawing.Point(26, 215);
            this.HariBox.Name = "HariBox";
            this.HariBox.Size = new System.Drawing.Size(332, 20);
            this.HariBox.TabIndex = 9;
            this.HariBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.HariBox_MaskInputRejected);
            // 
            // TanggalBox
            // 
            this.TanggalBox.Location = new System.Drawing.Point(26, 267);
            this.TanggalBox.Name = "TanggalBox";
            this.TanggalBox.Size = new System.Drawing.Size(332, 20);
            this.TanggalBox.TabIndex = 10;
            this.TanggalBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TanggalBox_MaskInputRejected);
            // 
            // JamBox
            // 
            this.JamBox.Location = new System.Drawing.Point(26, 324);
            this.JamBox.Name = "JamBox";
            this.JamBox.Size = new System.Drawing.Size(332, 20);
            this.JamBox.TabIndex = 11;
            this.JamBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.JamBox_MaskInputRejected);
            // 
            // HalamanUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.JamBox);
            this.Controls.Add(this.TanggalBox);
            this.Controls.Add(this.HariBox);
            this.Controls.Add(this.NamaBox);
            this.Controls.Add(this.KirimButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Name = "HalamanUser";
            this.Text = "HalamanUser";
            this.Load += new System.EventHandler(this.HalamanUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button KirimButton;
        private System.Windows.Forms.MaskedTextBox NamaBox;
        private System.Windows.Forms.MaskedTextBox HariBox;
        private System.Windows.Forms.MaskedTextBox TanggalBox;
        private System.Windows.Forms.MaskedTextBox JamBox;
    }
}