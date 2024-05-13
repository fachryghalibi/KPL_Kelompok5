public class Account<T>
{
    public T Username { get; }
    public string Password { get; }

    public Account(T username, string password)
    {
        Username = username;
        Password = password;
    }
}
