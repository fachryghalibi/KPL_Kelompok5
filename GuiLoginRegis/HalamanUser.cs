using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLoginRegis
{
    public partial class HalamanUser : Form
    {
        public HalamanUser()
        {
            InitializeComponent();
        }

        private void HalamanUser_Load(object sender, EventArgs e)
        {

        }

        private void KirimButton_Click(object sender, EventArgs e)
        {
            string nama = NamaBox.Text;
            string nim = HariBox.Text;
            string tanggal = TanggalBox.Text;
            string jam = JamBox.Text;

            BookingManager.AddBooking(nama, nim, tanggal, jam);

            MessageBox.Show("Booking added successfully!");
        }

        private void NamaBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void HariBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TanggalBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void JamBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
