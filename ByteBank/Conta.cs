using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ByteBank
{
    public class Conta
    {
        private string nome { get; set; }
        private string CPF {get; set; }
        private double saldo { get; set; }
        private string senha { get; set; }
        private string numConta { get; set; }

        [JsonConstructor]
        public Conta(string nome, string CPF, double saldo,string senha, string numconta) : this(name, CPF, senha)
        {
            this.saldo = saldo;
            this.numConta = numconta;
        }

        public Conta(string nome, string cPF, double saldo, string senha, string numconta)
        {
            this.nome = nome;
            CPF = cPF;
            this.saldo = saldo;
            this.senha = senha;
            this.numConta = numconta;
        }
    }
}