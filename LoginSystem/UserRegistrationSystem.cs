namespace LoginSystem
{
    public class UserRegistrationSystem<T>
    {
        private enum State
        {
            EnteringUsername,
            EnteringPassword,
            EnteringName,
            EnteringEmail,
            Completed
        }

        private State currentState = State.EnteringUsername;

        public UserRegistrationSystem()
        {
        }

        public Account<T> RegisterNewUser()
        {
            T username = default(T);
            string password = null;
            string name = null;
            string email = null;

            while (true)
            {
                try
                {
                    switch (currentState)
                    {
                        case State.EnteringUsername:
                            Console.WriteLine("Masukkan username:");
                            username = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                            currentState = State.EnteringPassword;
                            break;

                        case State.EnteringPassword:
                            Console.WriteLine("Masukkan password:");
                            password = Console.ReadLine();
                            currentState = State.EnteringName;
                            break;

                        case State.EnteringName:
                            Console.WriteLine("Masukkan nama:");
                            name = Console.ReadLine();
                            currentState = State.EnteringEmail;
                            break;

                        case State.EnteringEmail:
                            Console.WriteLine("Masukkan email:");
                            email = Console.ReadLine();
                            currentState = State.Completed;
                            break;

                        case State.Completed:
                            Account<T> userAccount = new Account<T>(username, password, name, email);
                            Console.WriteLine("Akun user berhasil didaftarkan.");
                            return userAccount;

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