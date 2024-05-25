using System;
using LoginSystem;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek Account untuk admin utama
        Account<string> mainAdminAccount = new Account<string>("adminadmin", "Admin123");
        Account<string> userAccount = null; // Objek akun user akan dibuat saat proses registrasi

        // Membuat objek LoginSystem dan UserRegistrationSystem
        LoginSystem<string> loginSystem = new LoginSystem<string>(mainAdminAccount, userAccount);
        UserRegistrationSystem<string> registrationSystem = new UserRegistrationSystem<string>();
        AdminRegistrationSystem<string> adminRegistrationSystem = new AdminRegistrationSystem<string>();

        bool exit = false;
        bool isAdminLoggedIn = false;
        Account<string> currentAdminAccount = mainAdminAccount; // Track the current admin account

        while (!exit)
        {
            if (loginSystem.IsLoggedIn())
            {
                if (isAdminLoggedIn)
                {
                    Console.WriteLine("=== Menu Admin ===");
                    Console.WriteLine("1. Registrasi Admin");
                    Console.WriteLine("2. Logout");
                    Console.WriteLine("3. Keluar");
                }
                else
                {
                    Console.WriteLine("=== Menu User ===");
                    Console.WriteLine("1. Logout");
                    Console.WriteLine("2. Keluar");
                }

                Console.Write("Pilihan Anda: ");
                string choice = Console.ReadLine();

                if (isAdminLoggedIn)
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("=== Registrasi Admin ===");
                            try
                            {
                                var newAdminAccount = adminRegistrationSystem.RegisterNewAdmin();
                                loginSystem.UpdateAdminAccount(newAdminAccount);
                                currentAdminAccount = newAdminAccount; // Update current admin account
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Registrasi gagal: {ex.Message}");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Logout berhasil.");
                            loginSystem.Logout();
                            isAdminLoggedIn = false;
                            break;
                        case "3":
                            Console.WriteLine("Keluar dari program. Sampai jumpa!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid. Silakan masukkan pilihan yang benar (1, 2, atau 3).");
                            break;
                    }
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Logout berhasil.");
                            loginSystem.Logout();
                            break;
                        case "2":
                            Console.WriteLine("Keluar dari program. Sampai jumpa!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid. Silakan masukkan pilihan yang benar (1 atau 2).");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Silakan pilih opsi:");
                Console.WriteLine("1. Registrasi User");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilihan Anda: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("=== Registrasi User ===");
                        try
                        {
                            userAccount = registrationSystem.RegisterNewUser();
                            loginSystem.SetUserAccount(userAccount);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Registrasi gagal: {ex.Message}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("=== Login ===");
                        loginSystem.SetAdminAccount(currentAdminAccount); // Set the current admin account for login
                        loginSystem.StartLogin();
                        isAdminLoggedIn = loginSystem.IsAdminLoggedIn();
                        break;
                    case "3":
                        Console.WriteLine("Keluar dari program. Sampai jumpa!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan masukkan pilihan yang benar (1, 2, atau 3).");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
