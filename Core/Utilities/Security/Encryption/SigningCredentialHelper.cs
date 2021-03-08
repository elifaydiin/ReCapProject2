using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialHelper 
    {
        public static SigningCredentials CreateSigningCredantials(SecurityKey securityKey)//hangi anahtar hangi algoritma kullanılacak o belirleniyor
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
