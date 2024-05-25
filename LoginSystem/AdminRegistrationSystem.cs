using System;

namespace LoginSystem
{
    public class AdminRegistrationSystem<T>
    {
        private enum State
        {
            EnteringUsername,
            EnteringPassword,
            Completed
        }

        private State currentState = State.EnteringUsername;
        private Account<T> adminAccount;

        public AdminRegistrationSystem()
        {
        }

        public Account<T> RegisterNewAdmin()
        {
            T username = default(T);
            string password = null;

            while (true)
            {
                try
                {
                    switch (currentState)
                    {
                        case State.EnteringUsername:
                            Console.WriteLine("Masukkan username admin:");
                            username = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                            currentState = State.EnteringPassword;
                            break;

                        case State.EnteringPassword:
                            Console.WriteLine("Masukkan password admin:");
                            password = Console.ReadLine();
                            currentState = State.Completed;
                            break;

                        case State.Completed:
                            adminAccount = new Account<T>(username, password);
                            Console.WriteLine("Akun admin berhasil didaftarkan.");
                            return adminAccount;

                        default:
                            throw new InvalidOperationException("Status tidak valid.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Registrasi gagal: {ex.Message}");
                    currentState = State.EnteringUsername;
                }
            }
        }
    }
}
