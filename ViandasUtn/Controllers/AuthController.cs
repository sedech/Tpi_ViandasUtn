﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ViandasUtn.Models;
using ViandasUtn.Repositories;

namespace ViandasUtn.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUsuarioRepository _userRepository;

        public AuthController(IConfiguration config, IUsuarioRepository userRepository)
        {
            _config = config; //Hacemos la inyección para poder usar el appsettings.json
            this._userRepository = userRepository;


        }

        [HttpPost("login")] //Vamos a usar un POST ya que debemos enviar los datos para hacer el login
        public ActionResult<string> Login(AuthenticationRequestBody authenticationRequestBody) //Enviamos como parámetro la clase que creamos arriba
        {
            //Paso 1: Validamos las credenciales
            var user = _userRepository.ValidateUser(authenticationRequestBody); //Lo primero que hacemos es llamar a una función que valide los parámetros que enviamos.

            if (user is null) //Si el la función de arriba no devuelve nada es porque los datos son incorrectos, por lo que devolvemos un Unauthorized (un status code 401).
                return Unauthorized();

            //Paso 2: Crear el token
            var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"])); //Traemos la SecretKey del Json. agregar antes: using Microsoft.IdentityModel.Tokens;

            var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

            //Los claims son datos en clave->valor que nos permite guardar data del usuario.
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString())); //"sub" es una key estándar que significa unique user identifier, es decir, si mandamos el id del usuario por convención lo hacemos con la key "sub".
            claimsForToken.Add(new Claim("given_name", user.Name)); //Lo mismo para given_name y family_name, son las convenciones para nombre y apellido. Ustedes pueden usar lo que quieran, pero si alguien que no conoce la app
            claimsForToken.Add(new Claim("family_name", user.LastName)); //quiere usar la API por lo general lo que espera es que se estén usando estas keys.

            var jwtSecurityToken = new JwtSecurityToken( //agregar using System.IdentityModel.Tokens.Jwt; Acá es donde se crea el token con toda la data que le pasamos antes.
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              credentials);

            var tokenToReturn = new JwtSecurityTokenHandler() //Pasamos el token a string
                .WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }
    }
}