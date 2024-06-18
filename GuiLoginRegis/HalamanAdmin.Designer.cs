namespace GuiLoginRegis
{
    partial class HalamanAdmin
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
            this.TambahAdminButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BookingJadwalTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookingJadwalTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TambahAdminButton
            // 
            this.TambahAdminButton.Location = new System.Drawing.Point(19, 390);
            this.TambahAdminButton.Name = "TambahAdminButton";
            this.TambahAdminButton.Size = new System.Drawing.Size(393, 23);
            this.TambahAdminButton.TabIndex = 19;
            this.TambahAdminButton.Text = "TAMBAH ADMIN";
            this.TambahAdminButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Berikut adalah booking jadwal yang dilakukan user:";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(337, 22);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 13;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SELAMAT DATANG DI APLIKASI TELKOM MEDIKA!";
            // 
            // BookingJadwalTable
            // 
            this.BookingJadwalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingJadwalTable.Location = new System.Drawing.Point(19, 114);
            this.BookingJadwalTable.Name = "BookingJadwalTable";
            this.BookingJadwalTable.Size = new System.Drawing.Size(393, 184);
            this.BookingJadwalTable.TabIndex = 20;
            // 
            // HalamanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.BookingJadwalTable);
            this.Controls.Add(this.TambahAdminButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Name = "HalamanAdmin";
            this.RightToLeftLayout = true;
            this.Text = "HalamanAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.BookingJadwalTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TambahAdminButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BookingJadwalTable;
    }
}