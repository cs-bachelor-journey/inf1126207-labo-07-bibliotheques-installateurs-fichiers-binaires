using PasswordLib;

class Program
{
    static void Main()
    {

        Console.WriteLine("🔐 Welcome to the Password Utility Tool!\n");

        // Generate a 16-character password with all options enabled
        string pwd = PasswordLib.PasswordLib.GeneratePassword(10, true, true, true);
        Console.WriteLine($"Generated: {pwd}");

        // Evaluate its strength
        string strength = PasswordLib.PasswordLib.EvaluateStrength(pwd);
        Console.WriteLine($"Strength: {strength}");

        Console.ReadKey();

    }
}