using System;
using System.Text;
using System.Security.Cryptography;

namespace Core.PasswordControls
{
    public static class SecurePassword
    {
        public static string HashPassword2(string pass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return Convert.ToBase64String(data);
            }
        }
        public static bool CheckIfPasswordsMatch(string password, string hashedPassword)
        {
            if (HashPassword(password).Equals(hashedPassword))
                return true;
            else
                return false;
        }
        public static string HashPassword(string pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] arr = Encoding.UTF8.GetBytes(pass);
                byte[] data = sha256.ComputeHash(arr);
                return Convert.ToBase64String(data);
            }
        }
    }
}
