using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Dynamic;

namespace ByteBank
{
    public class Funcoes
    {
        public static int GetIndex(List<Conta> contas)
        {
            Console.Write("Informe CPF do cliente requisitado: ");
            string infoConta = Console.ReadLine();

            int i = contas.FindIndex(client => client.Cpf == infoConta);

            return i;
        }
        public static void Info(List<Conta> contas, int i)
        {
            Console.WriteLine("Nome:" + contas[i].Nome);
            Console.WriteLine("Numero de Conta: " + contas[i].NumConta);
            Console.WriteLine("CPF: " + contas[i].Cpf);
            Console.WriteLine("Saldo: R$" + contas[i].Saldo);


        }
        public static void Cadastro(List<Conta> contas)
        {
            string nome, CPF, numConta, senha;
            bool exist;
            Console.Write("Insira nome do novo cliente: ");
            nome = Console.ReadLine();
            Console.Write("Insira cpf do novo cliente: ");
            CPF = Console.ReadLine();
            Console.Write("Insira senha do novo cliente: ");
            senha = Console.ReadLine();

            exist = contas.Exists(conta => conta.Cpf == CPF);

            if (!string.IsNullOrEmpty(nome) && !exist && !string.IsNullOrEmpty(senha))
            {
                contas.Add(new Conta(nome, CPF, senha));
                Info(contas, contas.Count - 1);
                Console.WriteLine("Cliente Cadastrado com Sucesso!");
            }
            else if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
                Console.WriteLine("Entrada Inválida! Operação Não Realizada!");
            else
                Console.WriteLine("Cliente já Cadastrado! Operação Não Realizada!");
        }
        public static void Deletar(List<Conta> contas)
        {
            int k = GetIndex(contas);
            Info(contas,k) ; 
            contas.RemoveAt(k);
            Console.WriteLine("Conta deletada com sucesso");

        }
    }
}