using System;
using Xunit;

namespace TestProjectLogin
{
    public class UnitTest1
    {
        [Fact]
        public void TestLoginSystem_Login()
        {
            // Arrange
            string adminUsername = "adminadmin";
            string adminPassword = "Admin123";
            string userUsername = "useruser";
            string userPassword = "User12345";
            var adminAccount = new Account<string>(adminUsername, adminPassword);
            var userAccount = new Account<string>(userUsername, userPassword);
            var loginSystem = new LoginSystem<string>(adminAccount, userAccount);

            // Act & Assert
            // Test admin login
            using (var consoleOutput = new ConsoleOutput())
            {
                consoleOutput.Start();
                ConsoleInput.SimulateInput(adminUsername);
                ConsoleInput.SimulateInput(adminPassword);
                loginSystem.StartLogin();
                Assert.Contains("Admin berhasil login.", consoleOutput.GetOutput());
            }

            // Test user login
            using (var consoleOutput = new ConsoleOutput())
            {
                consoleOutput.Start();
                ConsoleInput.SimulateInput(userUsername);
                ConsoleInput.SimulateInput(userPassword);
                loginSystem.StartLogin();
                Assert.Contains("User berhasil login.", consoleOutput.GetOutput());
            }

            // Test invalid username
            using (var consoleOutput = new ConsoleOutput())
            {
                consoleOutput.Start();
                ConsoleInput.SimulateInput("invalidusername");
                ConsoleInput.SimulateInput(userPassword);
                loginSystem.StartLogin();
                Assert.Contains("Username tidak valid.", consoleOutput.GetOutput());
            }

            // Test invalid password
            using (var consoleOutput = new ConsoleOutput())
            {
                consoleOutput.Start();
                ConsoleInput.SimulateInput(userUsername);
                ConsoleInput.SimulateInput("invalidpassword");
                loginSystem.StartLogin();
                Assert.Contains("Password salah. Silakan coba lagi.", consoleOutput.GetOutput());
            }
        }
    }

    // Helper class to capture console output
    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter stringWriter;
        private readonly System.IO.TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new System.IO.StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOutput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }

        public void Start()
        {
            stringWriter.GetStringBuilder().Clear();
        }
    }

    // Helper class to simulate console input
    public static class ConsoleInput
    {
        private static string[] inputBuffer;
        private static int currentIndex = -1;

        public static void SimulateInput(params string[] input)
        {
            inputBuffer = input;
            currentIndex = 0;
        }

        public static string ReadLine()
        {
            if (currentIndex >= 0 && currentIndex < inputBuffer.Length)
            {
                return inputBuffer[currentIndex++];
            }
            else
            {
                return null;
            }
        }
    }
}
