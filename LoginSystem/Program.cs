class Program
{
    static void Main(string[] args)
    {
        // Membuat akun admin dan user
        Account<string> admin = new Account<string>("admin", "admin123");
        Account<string> user = new Account<string>("user", "user123");

        // Membuat sistem login
        LoginSystem<string> loginSystem = new LoginSystem<string>(admin, user);

        // Memulai proses login
        loginSystem.StartLogin();
    }
}
