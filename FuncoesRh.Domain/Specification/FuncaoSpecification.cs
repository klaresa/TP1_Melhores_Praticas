using FuncoesRH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FuncoesRH.Domain.Specification
{
    public class FuncaoSpecification
    {
        public static Expression<Func<Funcao, bool>> ListarPorFuncionario(Funcionario funcionario) =>
            func => func.Funcionario.Nome == funcionario.Nome;
    }
}
