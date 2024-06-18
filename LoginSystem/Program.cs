using LoginSystem;
using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        var mainAdminAccount = LoadAccountFromFile<string>("adminAccount.json");
        var userAccount = LoadAccountFromFile<string>("userAccount.json");

        if (mainAdminAccount == null)
        {
            Console.WriteLine("=== Registrasi Akun Admin ===");
            var initialAdminRegistrationSystem = new AdminRegistrationSystem<string>();
            mainAdminAccount = initialAdminRegistrationSystem.RegisterNewAdmin();
            SaveAccountToFile("adminAccount.json", mainAdminAccount);
        }

        var loginSystem = new LoginSystem<string>(mainAdminAccount, userAccount);
        var registrationSystem = new UserRegistrationSystem<string>();
        var adminRegistrationSystem = new AdminRegistrationSystem<string>();

        bool exit = false;
        bool isAdminLoggedIn = false;
        var currentAdminAccount = mainAdminAccount; // Track the current admin account

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
                                SaveAccountToFile("adminAccount.json", currentAdminAccount);
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
                            SaveAccountToFile("userAccount.json", userAccount);
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

    private static void SaveAccountToFile<T>(string filename, Account<T> account)
    {
        try
        {
            string json = JsonSerializer.Serialize(account);
            File.WriteAllText(filename, json);
            Console.WriteLine($"Akun berhasil disimpan ke {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Gagal menyimpan akun: {ex.Message}");
        }
    }

    private static Account<T> LoadAccountFromFile<T>(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                Account<T> account = JsonSerializer.Deserialize<Account<T>>(json);
                Console.WriteLine($"Akun berhasil dimuat dari {filename}");
                return account;
            }
            else
            {
                Console.WriteLine($"File {filename} tidak ditemukan.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Gagal memuat akun: {ex.Message}");
            return null;
        }
    }
}
