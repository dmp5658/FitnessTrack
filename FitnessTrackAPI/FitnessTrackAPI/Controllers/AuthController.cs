using FitnessTrackAPI.Data;
using FitnessTrackAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;


namespace FitnessTrackAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    [RoutePrefix("auth")]
    public class AuthController : ApiController
    {
        [Route("login")]
        [HttpPost]
        public IHttpActionResult Login([FromBody]User user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
                return BadRequest("Enter your username and password");
            try
            {
                using (var context = new AppDbContext())
                {
                    var exists = context.Users.Any(n => n.UserName == user.UserName);

                    if (exists)
                    {
                        var passone = context.Users.Where(p => p.UserName == user.UserName).SingleOrDefault();
                        if (BCrypt.Net.BCrypt.Verify(user.Password, passone.Password))
                        {
                            user.UserId = passone.UserId;
                            return Ok(CreateToken(user));
                        }
                    }

                    return BadRequest("Wrong credentials");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [Route("register")]
        [HttpPost]
        public IHttpActionResult Register([FromBody]User user)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var exists = context.Users.Any(n => n.UserName == user.UserName);
                    if (exists) return BadRequest("User already exists");
                    user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                    context.Users.Add(user);

                    context.SaveChanges();

                    var passone = context.Users.Where(p => p.UserName == user.UserName).SingleOrDefault();
                    user.UserId = passone.UserId;

                    return Ok(CreateToken(user));
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        private JwtPackage CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Email, user.UserName)
            });

            const string secretKey = "your secret key goes here";
            var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(secretKey));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = (JwtSecurityToken)tokenHandler.CreateJwtSecurityToken(
                subject: claims,
                signingCredentials: signingCredentials);

            var tokenString = tokenHandler.WriteToken(token);

            return new JwtPackage()
            {
                UserName = user.UserName,
                Token = tokenString,
                UserID = user.UserId
            };
        }



    }
}

public class JwtPackage
{
    public string Token { get; set; }
    public string UserName { get; set; }
    public int UserID { get; set; }
}
