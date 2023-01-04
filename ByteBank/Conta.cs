using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace ByteBank
{
    public class Conta
    {
        private string nome;
        private string CPF;
        private double saldo; 
        private string senha;
        private string numConta;

        [JsonConstructor]
        public Conta(string nome, string CPF, double saldo,string senha, string numConta) : this(nome, CPF, senha)
        {
            this.saldo = saldo;
            this.numConta = numConta;
        }

        public Conta(string nome, string CPF, string senha)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.senha = senha;
            int rnd = new Random().Next(1000, 9999);
            numConta = rnd.ToString("000-0");
            saldo = 0;
        }

        public string Nome { get => nome; }

        public string Cpf { get => CPF; }

        public string Senha { get => senha; }

        public double Saldo { get => saldo; }

        public string NumConta { get => numConta; }
    }

}