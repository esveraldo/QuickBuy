using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Adicionar(TEntity entity);
        void Atualiza(TEntity entity);
        void Remover(TEntity entity);
    }
}
