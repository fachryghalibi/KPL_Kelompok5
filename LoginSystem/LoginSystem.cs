using System;

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

    public LoginSystem(Account<T> admin, Account<T> user)
    {
        adminAccount = admin;
        userAccount = user;
    }

    public void StartLogin()
    {
        while (true)
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

                    if (currentUsername.Equals(adminAccount.Username.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        if (inputPassword == adminAccount.Password)
                        {
                            Console.WriteLine("Admin berhasil login.");
                            currentState = State.LoggedIn;
                        }
                        else
                        {
                            Console.WriteLine("Password salah. Silakan coba lagi.");
                            currentState = State.NotLoggedIn;
                        }
                    }
                    else if (currentUsername.Equals(userAccount.Username.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        if (inputPassword == userAccount.Password)
                        {
                            Console.WriteLine("User berhasil login.");
                            currentState = State.LoggedIn;
                        }
                        else
                        {
                            Console.WriteLine("Password salah. Silakan coba lagi.");
                            currentState = State.NotLoggedIn;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Username tidak valid.");
                        currentState = State.NotLoggedIn;
                    }
                    break;

                case State.LoggedIn:
                    Console.WriteLine("Anda sudah masuk.");
                    return;
            }
        }
    }
}