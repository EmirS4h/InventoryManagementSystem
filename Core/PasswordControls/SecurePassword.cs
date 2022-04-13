using System;
using System.Text;
using System.Security.Cryptography;

namespace Core.PasswordControls
{
    public class SecurePassword
    {
        public string HashPassword(string pass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return Convert.ToBase64String(data);
            }
        }
        public bool CheckIfPasswordsMatch(string password,string hashedPassword)
        {
            if (HashPassword(password).Equals(hashedPassword))
                return true;
            else
                return false;
        }
    }
}
