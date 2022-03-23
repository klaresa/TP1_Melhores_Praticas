using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FuncoesRH.Repository
{
    public interface IRepository<T>
    {
        void Salvar(T objeto);
        void Editar(T obj);
        void Remover(Guid id);
        T Listar(Guid id);

        List<T> ListarPor(Expression<Func<T, bool>> expression);
    }
}
