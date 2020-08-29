using DevBoost.DroneDelivery.Domain.Entities;
using DevBoost.DroneDelivery.Domain.Interfaces.Repositories;
using DevBoost.DroneDelivery.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DCDroneDelivery _context;

        public ClienteRepository(DCDroneDelivery context)
        {
            _context = context;
        }

        public async Task<IList<Cliente>> GetAll()
        {
            return await _context.Cliente
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Cliente> GetById(int id)
        {
            return await _context.Cliente
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cliente> GetByUserName(string name)
        {
            return await _context.Cliente
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Nome == name);
        }

        public async Task<Cliente> GetByUserNamePass(string name, string pass)
        {
            return await _context.Cliente
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Nome == name && c.Senha == pass);
        }

        public async Task<bool> Insert(Cliente cliente)
        {            
            _context.Add(cliente);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
