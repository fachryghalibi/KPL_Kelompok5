using System;
using System.Linq;

namespace KPL_Kelompok5
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthConsultationScheduler scheduler = new HealthConsultationScheduler();

            // Meminta pengguna untuk memilih hari
            Console.WriteLine("Masukkan hari (Monday, Tuesday, Wednesday, Thursday, Friday):");
            string inputDay = Console.ReadLine();

            // Parsing input string menjadi enum DayOfWeek
            if (Enum.TryParse(inputDay, true, out DayOfWeek selectedDay))
            {
                // Mendapatkan jadwal konsultasi untuk hari yang dipilih
                var scheduleList = scheduler.GetConsultationSchedule(selectedDay);

                // Mencetak jadwal konsultasi
                Console.WriteLine($"Consultation schedule for {selectedDay}:");
                if (scheduleList.Count > 0)
                {
                    foreach (var schedule in scheduleList)
                    {
                        Console.WriteLine(schedule);
                    }

                    // Meminta pengguna untuk memilih jam dari jadwal konsultasi yang tersedia
                    Console.WriteLine("Pilih jam konsultasi (misal: 09:00):");
                    string inputTime = Console.ReadLine().Trim(); 

                    // Memeriksa apakah jam yang dipilih tersedia di jadwal konsultasi
                    bool isTimeAvailable = IsTimeAvailable(scheduleList, inputTime);

                    if (isTimeAvailable)
                    {
                        Console.WriteLine($"Konsultasi pada {selectedDay} pukul {inputTime} berhasil dijadwalkan.");
                    }
                    else
                    {
                        Console.WriteLine($"Jam {inputTime} tidak tersedia untuk konsultasi pada {selectedDay}.");
                    }
                }
                else
                {
                    Console.WriteLine("No consultation available");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid day.");
            }
        }

        // Method untuk memeriksa apakah waktu yang dimasukkan pengguna berada dalam rentang waktu yang tersedia dalam jadwal konsultasi
        static bool IsTimeAvailable(IEnumerable<string> scheduleList, string inputTime)
        {
            foreach (var timeRange in scheduleList)
            {
                // Memisahkan waktu mulai dan waktu selesai
                var timeParts = timeRange.Split('-');
                if (timeParts.Length == 2)
                {
                    string startTime = timeParts[0].Trim();
                    string endTime = timeParts[1].Trim();

                    // Membandingkan jam yang dimasukkan pengguna dengan rentang waktu yang tersedia
                    if (IsBetween(inputTime, startTime, endTime))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Method untuk memeriksa apakah waktu yang dimasukkan pengguna berada di antara waktu mulai dan waktu selesai
        static bool IsBetween(string inputTime, string startTime, string endTime)
        {
            // Parsing jam dan menit
            var inputParts = inputTime.Split(':');
            var startParts = startTime.Split(':');
            var endParts = endTime.Split(':');

            if (inputParts.Length == 2 && startParts.Length == 2 && endParts.Length == 2)
            {
                int inputHour, inputMinute, startHour, startMinute, endHour, endMinute;
                if (int.TryParse(inputParts[0], out inputHour) && int.TryParse(inputParts[1], out inputMinute) &&
                    int.TryParse(startParts[0], out startHour) && int.TryParse(startParts[1], out startMinute) &&
                    int.TryParse(endParts[0], out endHour) && int.TryParse(endParts[1], out endMinute))
                {
                    // Mengonversi waktu menjadi menit untuk mempermudah perbandingan
                    int inputTotalMinutes = inputHour * 60 + inputMinute;
                    int startTotalMinutes = startHour * 60 + startMinute;
                    int endTotalMinutes = endHour * 60 + endMinute;

                    // Memeriksa apakah waktu yang dimasukkan pengguna berada di antara waktu mulai dan waktu selesai
                    return inputTotalMinutes >= startTotalMinutes && inputTotalMinutes <= endTotalMinutes;
                }
            }
            return false;
        }
    }
}
