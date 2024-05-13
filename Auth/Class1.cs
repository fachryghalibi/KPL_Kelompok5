using System;

namespace Auth
{
    public class Authentication
    {
        private bool isLoggedIn;
        private string username;

        public Authentication()
        {
            // Secara default, pengguna belum login saat objek Authentication dibuat
            isLoggedIn = false;
            username = null;
        }

        public void SetLoginStatus(bool status, string username = null)
        {
            // Method ini digunakan untuk mengatur status login pengguna
            isLoggedIn = status;
            this.username = username;
        }

        public bool IsLoggedIn()
        {
            // Mengembalikan status apakah pengguna sudah login atau belum
            return isLoggedIn;
        }

        public string GetUsername()
        {
            // Mengembalikan username pengguna yang sedang login
            return username;
        }
    }
}
