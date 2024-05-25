using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace KPL_Kelompok5
{
    public class HealthConsultationScheduler
    {
        // Struktur data untuk tabel jadwal konsultasi kesehatan
        private Dictionary<DayOfWeek, List<string>> consultationSchedule = new Dictionary<DayOfWeek, List<string>>();

        // Konstruktor untuk menginisialisasi tabel jadwal konsultasi
        public HealthConsultationScheduler()
        {
            InitializeConsultationSchedule();
        }

        // Method untuk menginisialisasi tabel jadwal konsultasi dengan hari dan waktu konsultasi
        private void InitializeConsultationSchedule()
        {
            // Tabel ini mencantumkan hari dan waktu konsultasi untuk setiap hari dalam seminggu
            // Anda dapat menyesuaikan jadwal konsultasi sesuai kebutuhan

            // Senin
            consultationSchedule.Add(DayOfWeek.Monday, new List<string> {
                "09:00 - 11:00",
                "14:00 - 16:00",
                // Tambahkan jadwal konsultasi 
            });

            // Selasa
            consultationSchedule.Add(DayOfWeek.Tuesday, new List<string> {
                "09:00 - 11:00",
                "14:00 - 16:00",
                // Tambahkan jadwal konsultasi 
            });

            // Rabu
            consultationSchedule.Add(DayOfWeek.Wednesday, new List<string> {
                "09:00 - 11:00",
                "14:00 - 16:00",
                // Tambahkan jadwal konsultasi 
            });

            // Kamis
            consultationSchedule.Add(DayOfWeek.Thursday, new List<string> {
                "09:00 - 11:00",
                "14:00 - 16:00",
                // Tambahkan jadwal konsultasi 
            });

            // Jumat
            consultationSchedule.Add(DayOfWeek.Friday, new List<string> {
                "09:00 - 11:00",
                "14:00 - 16:00",
                // Tambahkan jadwal konsultasi 
            });
        }

        // Method untuk mendapatkan jadwal konsultasi kesehatan berdasarkan hari
        public List<string> GetConsultationSchedule(DayOfWeek day)
        {
            Contract.Requires(Enum.IsDefined(typeof(DayOfWeek), day));
            Contract.Ensures(Contract.Result<List<string>>() != null);
            // Mengambil jadwal konsultasi dari tabel berdasarkan hari yang diberikan
            if (consultationSchedule.ContainsKey(day))
            {
                return consultationSchedule[day];
            }
            else
            {
                return new List<string> { "No consultation available" }; // Jika hari tidak ditemukan dalam tabel
            }
        }
    }
}
