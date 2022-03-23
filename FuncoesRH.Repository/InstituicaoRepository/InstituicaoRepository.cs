using FuncoesRH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FuncoesRH.Repository.InstituicaoRepository
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        public void Editar(Instituicao obj)
        {
            throw new NotImplementedException();
        }

        public Instituicao Listar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Instituicao objeto)
        {
            throw new NotImplementedException();
        }

        public List<Instituicao> ListarPor(Expression<Func<Instituicao, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
