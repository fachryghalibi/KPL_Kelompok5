using System;
using System.IO;
using System.Text.Json;
using System.Linq;

public class Account<T>
{
    public T Username { get; }
    public string Password { get; }
    public string Name { get; }
    public string Email { get; }

    public Account(T username, string password, string name, string email)
    {
        if (string.IsNullOrEmpty(username.ToString()))
            throw new ArgumentException("Username tidak boleh null atau kosong.", nameof(username));

        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password tidak boleh null atau kosong.", nameof(password));

        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Nama tidak boleh null atau kosong.", nameof(name));

        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email tidak boleh null atau kosong.", nameof(email));

        if (username.ToString().Length < 8 || username.ToString().Length > 12)
            throw new ArgumentException("Panjang username harus antara 8 dan 12 karakter.", nameof(username));

        if (!IsUniqueUsername(username))
            throw new ArgumentException("Username sudah digunakan.", nameof(username));

        if (!IsStrongPassword(password))
            throw new ArgumentException("Password harus memiliki setidaknya satu huruf besar, satu huruf kecil, satu angka, dan panjang antara 8 dan 12 karakter.", nameof(password));

        Username = username;
        Password = password;
        Name = name;
        Email = email;
    }

    private bool IsUniqueUsername(T username)
    {
        // Implementasi pengecekan unik
        return true;
    }

    private bool IsStrongPassword(string password)
    {
        return password.Length >= 8 && password.Length <= 12 &&
               password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
    }
}