using System;

namespace NotificationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationLibrary.NotificationManager notificationManager = new NotificationLibrary.NotificationManager();

            // Menambahkan beberapa pemberitahuan
            DateTime reminderTime1 = DateTime.Now.AddDays(1).Date.AddHours(9); // Janji temu besok pukul 09:00
            notificationManager.AddNotification("Jangan lupa janji temu besok!", "Pasien A", reminderTime1);

            DateTime reminderTime2 = DateTime.Now.AddMinutes(30); // Rapat staf dimulai dalam 30 menit
            notificationManager.AddNotification("Rapat staf dimulai dalam 30 menit.", "Staf Klinik", reminderTime2);

            // Mengirim pemberitahuan yang sudah waktunya
            notificationManager.SendNotifications();
        }
    }
}
