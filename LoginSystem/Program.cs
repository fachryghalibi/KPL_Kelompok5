class Program
{
    static void Main(string[] args)
    {
        // Membuat akun admin dan user dengan kontrak yang aman
        Account<string> admin = new Account<string>("adminadmin", "Admin123");
        Account<string> user = new Account<string>("useruser", "User12345");

        // Membuat sistem login dengan kontrak yang aman
        LoginSystem<string> loginSystem = new LoginSystem<string>(admin, user);

        // Memulai proses login
        loginSystem.StartLogin();
    }
}
