using System;
using System.Collections.Generic;

namespace NotificationLibrary
{
    public class NotificationManager
    {
        private List<Notification> notifications;

        public NotificationManager()
        {
            notifications = new List<Notification>();
        }

        public void AddNotification(string message, string recipient, DateTime time)
        {
            notifications.Add(new Notification { Message = message, Recipient = recipient, Time = time });
        }

        public void SendNotifications()
        {
            DateTime currentTime = DateTime.Now;
            foreach (var notification in notifications)
            {
                if (notification.Time <= currentTime)
                {
                    Console.WriteLine($"Sending notification to {notification.Recipient}: {notification.Message}");
                    // Di sini Anda bisa menambahkan kode untuk mengirimkan notifikasi sesuai dengan metode yang diinginkan
                }
            }
        }
    }

    public class Notification
    {
        public string Message { get; set; }
        public string Recipient { get; set; }
        public DateTime Time { get; set; }
    }
}
