using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuiLoginRegis
{
    public partial class HalamanAdmin : Form
    {
        public HalamanAdmin()
        {
            InitializeComponent();
            LoadBookingData();
        }

        private void BookingJadwalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBookingData()
        {
            string filePath = "D:\\Fachry\\Kuliah\\KPL_Kelompok5\\GuiLoginRegis\\json\\booking.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    List<Booking> bookings = JsonConvert.DeserializeObject<List<Booking>>(json);

                    // Bind data to DataGridView
                    BookingJadwalTable.DataSource = bookings;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File 'bookings.json' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
