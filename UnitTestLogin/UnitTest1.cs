using System;
using System.IO;
using LoginSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting; // Using for .NET Framework unit testing

public class LoginSystemTests
{
    [TestMethod]
    public void LoginSystem_StartLogin_SuccessfulAdminLogin()
    {
        // Arrange
        var admin = new Account<string>("adminadmin", "Admin123");
        var user = new Account<string>("useruser", "User12345");
        var loginSystem = new LoginSystem<string>(admin, user);

        // Act
        var capturedOutput = new StringWriter();
        Console.SetOut(capturedOutput);
        loginSystem.StartLogin();

        // Assert
        var output = capturedOutput.ToString().Trim();
        Assert.IsTrue(output.Contains("Silakan masukkan username:"));
        Assert.IsTrue(output.Contains("Silakan masukkan password:"));
        Assert.IsTrue(output.Contains("Admin berhasil login."));
    }

    [TestMethod]
    public void LoginSystem_StartLogin_SuccessfulUserLogin()
    {
        // Arrange
        var admin = new Account<string>("adminadmin", "Admin123");
        var user = new Account<string>("useruser", "User12345");
        var loginSystem = new LoginSystem<string>(admin, user);

        // Act
        var capturedOutput = new StringWriter();
        Console.SetOut(capturedOutput);
        Console.WriteLine("useruser"); // Simulate user input
        Console.WriteLine("User12345");
        loginSystem.StartLogin();

        // Assert
        var output = capturedOutput.ToString().Trim();
        Assert.IsTrue(output.Contains("Silakan masukkan username:"));
        Assert.IsTrue(output.Contains("Silakan masukkan password:"));
        Assert.IsTrue(output.Contains("User berhasil login."));
    }

    [TestMethod]
    public void LoginSystem_StartLogin_InvalidUsername()
    {
        // Arrange
        var admin = new Account<string>("adminadmin", "Admin123");
        var user = new Account<string>("useruser", "User12345");
        var loginSystem = new LoginSystem<string>(admin, user);

        // Act
        var capturedOutput = new StringWriter();
        Console.SetOut(capturedOutput);
        Console.WriteLine("invaliduser"); // Invalid username
        Console.WriteLine("Admin123");
        loginSystem.StartLogin();

        // Assert
        var output = capturedOutput.ToString().Trim();
        Assert.IsTrue(output.Contains("Silakan masukkan username:"));
        Assert.IsTrue(output.Contains("Silakan masukkan password:"));
        Assert.IsTrue(output.Contains("Username tidak valid."));
    }

    [TestMethod]
    public void LoginSystem_StartLogin_IncorrectPassword()
    {
        // Arrange
        var admin = new Account<string>("adminadmin", "Admin123");
        var user = new Account<string>("useruser", "User12345");
        var loginSystem = new LoginSystem<string>(admin, user);

        // Act
        var capturedOutput = new StringWriter();
        Console.SetOut(capturedOutput);
        Console.WriteLine("adminadmin");
        Console.WriteLine("IncorrectPassword"); // Incorrect password
        loginSystem.StartLogin();

        // Assert
        var output = capturedOutput.ToString().Trim();
        Assert.IsTrue(output.Contains("Silakan masukkan username:"));
        Assert.IsTrue(output.Contains("Silakan masukkan password:"));
        Assert.IsTrue(output.Contains("Password salah. Silakan coba lagi."));
    }
}
