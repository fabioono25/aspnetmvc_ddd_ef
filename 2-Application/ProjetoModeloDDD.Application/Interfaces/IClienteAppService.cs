using System;
using System.Collections.Generic;
using System.Text;
using ProjetoModeloDDD.Domain.Entities;


namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
