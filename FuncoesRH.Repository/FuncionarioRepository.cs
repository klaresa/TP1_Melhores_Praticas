using FuncoesRH.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FuncoesRH.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private static List<Funcionario> _funcionarios = new List<Funcionario>();

        public void Editar(Funcionario funcionario)
        {
            try
            {
                var funcionarios = FuncionarioRepository._funcionarios
                    .FirstOrDefault(func => func.Id == funcionario.Id);
                FuncionarioRepository._funcionarios.Remove(funcionario);
                FuncionarioRepository._funcionarios.Add(funcionario);
            }
            catch
            {
                throw new Exception("Erro ao editar.");
            }
        }

        public Funcionario Listar(Guid id)
        {
            try
            {
                return FuncionarioRepository._funcionarios.FirstOrDefault(Func => Func.Id == id);
            } catch
            {
                throw new Exception("Erro encontrar funcionario.");
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                var funcionario = FuncionarioRepository._funcionarios.FirstOrDefault(Func => Func.Id == id);
                FuncionarioRepository._funcionarios.Remove(funcionario);
            } catch
            {
                throw new Exception("Erro remover funcionario.");
            }
        }

        public void Salvar(Funcionario funcionario)
        {
            try
            {
                FuncionarioRepository._funcionarios.Add(funcionario);
            } catch
            {
                throw new Exception("Erro adicionar funcionario.");
            }
        }

        public List<Funcionario> ListarPor(Expression<Func<Funcionario, bool>> expression)
        {
            return FuncionarioRepository._funcionarios.Where(expression.Compile()).ToList();
        }
    }
}
