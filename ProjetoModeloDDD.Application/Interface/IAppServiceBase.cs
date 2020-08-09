using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class //tratar ele como se fosse uma classe
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
