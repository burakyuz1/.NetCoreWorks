using JsonWebTokenAuth.Abstract;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JsonWebTokenAuth.Concrete
{

    public class JWTAuthenticationManager : IJWTAuthenticationService
    {
        private readonly string key = "this is my long string key value!";
        public JWTAuthenticationManager(string key)
        {
            this.key = key;
        }
        private readonly IDictionary<string, string> users = new Dictionary<string, string>()
        {
            {"user1","pwd1" },
            {"user2","pwd2" },
            {"user3","pwd3" }
        };
        public string Authenticate(string userName, string password)
        {
            //Bir kullanıcı var mı diye kontrol edilir.
            if (!users.Any(a => a.Key == userName && a.Value == password)) return null;

            //Token handler nesnesi
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);

            var tokenDescriptor = new SecurityTokenDescriptor() //Token'ı açıklayacak parametre bu
            {
                Subject = new ClaimsIdentity(new Claim[]{ //Ana konu.
                    new Claim(ClaimTypes.Name,userName) //Kimin adına oluşturulacak?

                }),
                Expires = DateTime.UtcNow.AddHours(1), //1 saat boyunca hayatta kalsın.
                SigningCredentials = new SigningCredentials( //tokenKey ve şifrelenecek algoritma şekli belirlenir.
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor); //verilen ayara göre yeni bir token oluştur.

            return tokenHandler.WriteToken(token);
        }
    }
}
