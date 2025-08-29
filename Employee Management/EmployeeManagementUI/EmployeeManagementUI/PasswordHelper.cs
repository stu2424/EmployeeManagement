using System;
using System.Security.Cryptography;
using System.Text;

namespace EmployeeManagementUI
{
    public static class PasswordHelper
    {
        // Hash a password
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Verify a password against a hash
        public static bool VerifyPassword(string password, string hash)
        {
            string hashedInput = HashPassword(password);
            return string.Equals(hashedInput, hash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
