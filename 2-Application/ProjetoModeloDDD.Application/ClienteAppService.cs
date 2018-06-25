using System;
using System.Collections.Generic;
using System.Text;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
                : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
