using DevBoost.DroneDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<IList<Cliente>> GetAll();
        Task<Cliente> GetById(int id);
        Task<Cliente> GetByUserName(string name);
        Task<bool> Insert(Cliente cliente);
        Task<Cliente> GetByUserNamePass(string username, string password);
    }
}
