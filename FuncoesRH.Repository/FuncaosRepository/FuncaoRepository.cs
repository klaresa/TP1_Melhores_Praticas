using FuncoesRH.Domain.Entities;
using FuncoesRH.Repository.FuncaoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FuncoesRH.Repository.FuncaosRepository
{
    public class FuncaoRepository : IFuncaoRepository
    {
        private static List<Funcao> _funcao = new List<Funcao>();

        public void Editar(Funcao funcao)
        {
            try
            {
                var found = FuncaoRepository._funcao
                    .FirstOrDefault(func => func.Id == funcao.Id);
                FuncaoRepository._funcao.Remove(funcao);
                FuncaoRepository._funcao.Add(funcao);
            }
            catch
            {
                throw new Exception("Erro ao editar.");
            }
        }

        public Funcao Listar(Guid id)
        {
            try
            {
                return FuncaoRepository._funcao.FirstOrDefault(func => func.Id == id);
            }
            catch
            {
                throw new Exception("Erro encontrar funcao.");
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                var funcao = FuncaoRepository._funcao.FirstOrDefault(Func => Func.Id == id);
                FuncaoRepository._funcao.Remove(funcao);
            }
            catch
            {
                throw new Exception("Erro remover funcao.");
            }
        }

        public void Salvar(Funcao funcao)
        {
            try
            {
                FuncaoRepository._funcao.Add(funcao);
            }
            catch
            {
                throw new Exception("Erro adicionar funcao.");
            }
        }

        public List<Funcao> ListarPor(Expression<Func<Funcao, bool>> expression)
        {
            return FuncaoRepository._funcao.Where(expression.Compile()).ToList();
        }
    }
}
