namespace PasswordLib
{
    public class PasswordLib
    {
        private const string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string DigitChars = "0123456789";
        private const string SpecialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

        /// <summary>
        /// fonction to generate a password base on the user input
        /// </summary>
        /// <param name="length"></param>
        /// <param name="useUpper"></param>
        /// <param name="useDigits"></param>
        /// <param name="useSpecial"></param>
        /// <returns>password</returns>
        public static string GeneratePassword(int length, bool useUpper, bool useDigits, bool useSpecial)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Password length must be greater than 0");
            }

            string allowedChars = LowerCaseChars;

            if (useUpper)
            {
                allowedChars += UpperCaseChars;
            }

            if (useDigits)
            {
                allowedChars += DigitChars;
            }

            if (useSpecial)
            {
                allowedChars += SpecialChars;
            }

            Random random = new Random();

            string password = "";

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(allowedChars.Length);
                password += allowedChars[index];
            }

            return password;
        }


        /// <summary>
        /// function to evaluate the password strength
        /// </summary>
        /// <param name="password"></param>
        /// <returns>string</returns>
        public static string EvaluateStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "very weak";
            }

            int score = 0;

            // 1. Length checks
            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (password.Length >= 16) score++;

            // 2. Complexity Checks
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) score ++;

            // 3. Determine strength label
            switch (score)
            {
                case 0:
                case 1:
                    return "Very Weak";
                case 2:
                case 3:
                    return "Weak";
                case 4:
                case 5:
                    return "Medium";
                case 6:
                    return "Strong";
                case 7:
                case 8:
                case 9:
                case 10:
                    return "Very Strong";
                default:
                    return "Very Very Strong";
            }
        }
    }
}
