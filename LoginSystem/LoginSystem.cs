public class LoginSystem<T>
{
    private enum State
    {
        NotLoggedIn,
        EnteringUsername,
        EnteringPassword,
        LoggedIn
    }

    private State currentState = State.NotLoggedIn;
    private Account<T> adminAccount;
    private Account<T> userAccount;
    private string currentUsername;
    private bool isAdminLoggedIn = false;

    public LoginSystem(Account<T> admin, Account<T> user)
    {
        adminAccount = admin;
        userAccount = user;
    }

    public void SetUserAccount(Account<T> user)
    {
        userAccount = user;
    }

    public void SetAdminAccount(Account<T> admin)
    {
        adminAccount = admin;
    }

    public void UpdateAdminAccount(Account<T> newAdmin)
    {
        adminAccount = newAdmin;
    }

    public void StartLogin()
    {
        while (true)
        {
            try
            {
                switch (currentState)
                {
                    case State.NotLoggedIn:
                        Console.WriteLine("Silakan masukkan username:");
                        currentState = State.EnteringUsername;
                        break;

                    case State.EnteringUsername:
                        string inputUsername = Console.ReadLine();
                        currentUsername = inputUsername;
                        Console.WriteLine("Silakan masukkan password:");
                        currentState = State.EnteringPassword;
                        break;

                    case State.EnteringPassword:
                        string inputPassword = Console.ReadLine();

                        if (string.IsNullOrEmpty(inputPassword))
                        {
                            throw new ArgumentException("Password tidak boleh kosong.");
                        }

                        if (currentUsername.Equals(adminAccount.Username.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            if (inputPassword == adminAccount.Password)
                            {
                                Console.WriteLine("Admin berhasil login.");
                                currentState = State.LoggedIn;
                                isAdminLoggedIn = true;
                            }
                            else
                            {
                                throw new ArgumentException("Password salah.");
                            }
                        }
                        else if (userAccount != null && currentUsername.Equals(userAccount.Username.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            if (inputPassword == userAccount.Password)
                            {
                                Console.WriteLine("User berhasil login.");
                                currentState = State.LoggedIn;
                                isAdminLoggedIn = false;
                            }
                            else
                            {
                                throw new ArgumentException("Password salah.");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Username tidak valid.");
                        }
                        break;

                    case State.LoggedIn:
                        Console.WriteLine("Anda sudah masuk.");
                        return;

                    default:
                        throw new InvalidOperationException("Status tidak valid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login gagal: {ex.Message}");
                currentState = State.NotLoggedIn;
            }
        }
    }

    public void Logout()
    {
        currentState = State.NotLoggedIn;
        isAdminLoggedIn = false;
    }

    public bool IsLoggedIn()
    {
        return currentState == State.LoggedIn;
    }

    public bool IsAdminLoggedIn()
    {
        return isAdminLoggedIn;
    }
}