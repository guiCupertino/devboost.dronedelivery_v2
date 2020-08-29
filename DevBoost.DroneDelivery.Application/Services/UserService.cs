using DevBoost.DroneDelivery.Domain.Entities;
using DevBoost.DroneDelivery.Domain.Interfaces.Repositories;
using DevBoost.DroneDelivery.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DevBoost.DroneDelivery.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly IClienteRepository _clienteRepositoty;

        public UserService(IHttpContextAccessor accessor,
            IClienteRepository clienteRepositoty)
        {
            _accessor = accessor;
            _clienteRepositoty = clienteRepositoty;
        }

        public User Authenticate(string username, string password)
        {
            var user = _clienteRepositoty.GetByUserNamePass(username, password).Result;

            if(user != null)
                return new User(user.Id, user.Usuario, user.Senha, user.Role);

            if (!_clienteRepositoty.GetAll().Result.Any())
                return new User(1, "Mirosmar", "123", "ADMIN");

            return null;
        }

        public List<User> GetAll()
        {
            var listaUsuarios = new List<User>();
            var usuarios = _clienteRepositoty.GetAll().Result;

            foreach (var usuario in usuarios)
            {
                listaUsuarios.Add(new User(usuario.Id, usuario.Usuario, usuario.Senha, usuario.Role));
            }

            return listaUsuarios;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }


    }
}
