﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ProjetoCurriculum.Helpers
{
    public class JwtHelper : IJwtHelper
    {
        public string GenerateJWT(string name, string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescripitor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(ClaimTypes.Role, role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes("3e7881492942f2f6162c84f26de20a53")), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescripitor);
            return tokenHandler.WriteToken(token);
        }
    }
}
