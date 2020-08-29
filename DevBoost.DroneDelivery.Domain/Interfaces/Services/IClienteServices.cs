﻿using DevBoost.DroneDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Domain.Interfaces.Services
{
    public interface IClienteServices
    {
        Task<IList<Cliente>> GetAll();
        Task<bool> Insert(Cliente cliente);
    }
}
