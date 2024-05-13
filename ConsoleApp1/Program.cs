using System;
using Auth;

class Program
{
    static void Main(string[] args)
    {
        Authentication auth = new Authentication();

        // Lakukan verifikasi login sebelum melakukan kegiatan dalam aplikasi
        if (!auth.IsLoggedIn())
        {
            // Jika pengguna belum login, tampilkan pesan bahwa pengguna harus login
            Console.WriteLine("Anda belum login. Silakan login untuk melanjutkan.");
            // Tambahkan logika untuk menampilkan halaman login jika diperlukan
            // ...
        }

        // Setelah login, lanjutkan dengan kegiatan dalam aplikasi
        if (auth.IsLoggedIn())
        {
            Console.WriteLine("Selamat datang, " + auth.GetUsername());
            // Lakukan kegiatan dalam aplikasi di sini
        }
        else
        {
            Console.WriteLine("Login gagal. Aplikasi tidak dapat melanjutkan.");
        }
    }
}
