using System;
using System.Collections.Generic;
using System.Text;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
