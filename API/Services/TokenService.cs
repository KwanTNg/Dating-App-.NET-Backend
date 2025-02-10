using System;
using System.Text;
using API.Entities;
using API.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace API.Services;

//the key stay on the server, use IConfiguration
public class TokenService : ITokenService
{
    private readonly IConfiguration _config;
    public TokenService(IConfiguration config) {
        _config = config;
    }
    public string CreateToken(AppUser user)
    {
        // use ?? to check if tokenkey is null, if null throw exception
        var tokenKey = _config["TokenKey"] ?? throw new Exception("Cannot access tokenKey from appsettings");
        //check if the token key is too short
        if (tokenKey.Length < 64) throw new Exception("Your tokenKey needs to be longer");
        //need to install extension, SymmetricSecurityKey is one key for both encrpt and decrpt
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

    }
}
