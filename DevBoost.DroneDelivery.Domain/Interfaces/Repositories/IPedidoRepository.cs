﻿using DevBoost.dronedelivery.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository
    {
        Task<IList<Pedido>> GetAll();
        Task<IList<Pedido>> GetPedidosEmAberto();
        Task<IList<Pedido>> GetPedidosEmTransito();
        Task<Pedido> GetById(Guid id);
        Task<Pedido> GetById(int id);
        Task<bool> Insert(Pedido pedido);
        Task<Pedido> Update(Pedido pedido);
        Task<bool> Delete(Pedido pedido);
    }
}
