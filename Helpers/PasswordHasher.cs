using System.Security.Cryptography;
using System.Text;

namespace Helpers;

public class PasswordHasher
{
    public static string HashPassword(string password)
    {
        return Hash(password);
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        return Hash(password) == hashedPassword;
    }

    private static string Hash(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Convert the password string to byte array
            byte[] bytes = Encoding.UTF8.GetBytes(password);

            // Compute the hash
            byte[] hashBytes = sha256.ComputeHash(bytes);

            // Convert the byte array to a hexadecimal string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
