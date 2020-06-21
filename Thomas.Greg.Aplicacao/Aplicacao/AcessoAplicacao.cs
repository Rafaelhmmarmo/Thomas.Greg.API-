using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Thomas.Greg.Aplicacao.Interfaces.API;

namespace Thomas.Greg.Aplicacao.Aplicacao
{
    public class AcessoAplicacao : IAcessoAplicacao
    {
        public string GerarToken()
        {
            try
            {
                var tokeHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes("THOMASGREGTOKENJWT");
                var token = tokeHandler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = "Thomas.Greg",
                    Audience = "https://localhost",
                    Expires = DateTime.UtcNow.AddHours(12),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
                });

                var encodedToken = tokeHandler.WriteToken(token);

                return encodedToken;
            }
            catch (Exception x)
            {
                return x.Message;
            }
        }
    }
}
