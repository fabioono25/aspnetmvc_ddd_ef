using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        //aplicando injecao de dependencia
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
