using DevBoost.dronedelivery.Domain;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DevBoost.DroneDelivery.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public void InformarNomeCliente(string nome)
        {
            this.Nome = nome;
        }
        //public void CriptografarSenha(string senha)
        //{
        //    this.Senha = MD5.Create(senha);
        //}
    }
}
