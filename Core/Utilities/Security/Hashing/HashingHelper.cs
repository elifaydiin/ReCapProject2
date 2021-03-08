using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)//oluşturulan şifrenin hash oluşturur
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;//her kullanıcı için key değeri oluşturu
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)//sonradan girilen şifrenin veri kaynağındaki ilgili salta göre eşleşip eşleşmediği yerdir.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedtHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedtHash.Length; i++)
                {
                    if (computedtHash[i] != passwordHash[i])
                    {
                        return false;
                    }

                }
                return true;
            }

        }
    }
}
