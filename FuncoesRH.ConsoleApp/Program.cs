using FuncoesRH.Domain;
using FuncoesRH.Domain.Entities;
using FuncoesRH.Domain.Specification;
using FuncoesRH.Repository;
using FuncoesRH.Repository.FuncaosRepository;
using System;

namespace FuncoesRH.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Iniciando...");
            
            // Repositorios
            IRepository<Funcionario> funcionarioRepository = new FuncionarioRepository();
            IRepository<Funcao> funcaoRepository = new FuncaoRepository();

            // Modelos
            Contato contato = new Contato();
            Funcionario funcionario = new Funcionario();
            Instituicao instituicao = new Instituicao();
            Vaga vaga = new Vaga();
            Funcao funcao = new Funcao();

            // preenche o Contato
            contato.Endereco = "Rua das Arvores, 88";
            contato.Telefone = "21 980003388";

            // preenche o Funcionario
            funcionario.Id = Guid.NewGuid();
            funcionario.Nome = "Marilia";
            funcionario.Contato = contato;

            // salva funcionario
            funcionarioRepository.Salvar(funcionario);

            // Usa o mesmo para adicionar contato da instituicao
            contato.Endereco = "Rua das Palmeiras, 90";
            contato.Telefone = "21 980008888";

            instituicao.Id = Guid.NewGuid();
            instituicao.Contato = contato;

            // preenche a Instituicao
            vaga.Id = Guid.NewGuid();
            vaga.Instituicao = instituicao;
            vaga.CargaHoraria = 8;

            // adiciona as horas para o funcionario
            funcionario.ContabilizarHoras(vaga.CargaHoraria);

            // Atribui a vaga ao funcionario
            funcao.Id = Guid.NewGuid();
            funcao.Vaga = vaga;
            funcao.Funcionario = funcionario;

            funcaoRepository.Salvar(funcao);

            // Teste
            var found = funcionarioRepository.Listar(funcionario.Id);
            var n = found.ObterCargaHoraria();
            System.Console.WriteLine(n);

            var func = funcaoRepository.Listar(funcao.Id);
            System.Console.WriteLine(func.Funcionario.Nome);


            var search = funcaoRepository.ListarPor(FuncaoSpecification.ListarPorFuncionario(funcionario));
            System.Console.WriteLine(search);
        }
    }
}
