using System;

namespace Facil.Erp.Entidades.Pessoas
{
    public class Pessoa
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Fone { get; set; }
        public string? Rg { get; set; }
        public string? Cpf { get; set; }
        public string? Profissao { get; set; }
        public string? FoneTrabalho { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Municipio { get; set; }
        public string? Uf { get; set; }
        public string? Filiacao { get; set; }
        public string? EnderecoFiliacao { get; set; }
        public DateTime? DataNascimento { get; set; }


        public Pessoa(string nome)
        {
            Nome = nome;
        }

        protected Pessoa(int codigo, string nome, string? endereco, string? fone, string? rg, string? cpf, string? profissao, string? foneTrabalho, string? cep, string? bairro, string? municipio, string? uf, string? filiacao, string? enderecoFiliacao, DateTime? dataNascimento)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Fone = fone;
            Rg = rg;
            Cpf = cpf;
            Profissao = profissao;
            FoneTrabalho = foneTrabalho;
            Cep = cep;
            Bairro = bairro;
            Municipio = municipio;
            Uf = uf;
            Filiacao = filiacao;
            EnderecoFiliacao = enderecoFiliacao;
            DataNascimento = dataNascimento;
        }
    }
}
