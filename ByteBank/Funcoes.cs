using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Dynamic;
using System.Linq;

namespace ByteBank
{
    public class Funcoes
    {
        //FUNCOES DE CONTA: CADASTRO, EXCLUSÃO E VISUALIZAÇÃO...
        public static int GetIndex(List<Conta> contas)
        {
            Console.Write("Informe o CPF da conta:\n");
            string infoConta = Console.ReadLine();

            int i = contas.FindIndex(client => client.Cpf == infoConta);

            return i;
        }
        public static void Info(List<Conta> contas, int i)
        {
            Console.WriteLine("Nome:" + contas[i].Nome);
            Console.WriteLine("Numero de Conta: " + contas[i].NumConta);
            Console.WriteLine("CPF: " + contas[i].Cpf);
            Console.WriteLine("Saldo: R$" + contas[i].Saldo.ToString("0.00"));
            Console.WriteLine(" ");


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
                Console.WriteLine("\nCliente cadastrado com sucesso\n");
            }
            else if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
                Console.WriteLine("\nEntrada Inválida! Tente novamente\n");
            else
                Console.WriteLine("\nCliente já Cadastrado! Confira os dados e tente novamente\n");
        }
        public static void Deletar(List<Conta> contas)
        {
            Login(contas);
            Console.WriteLine("\nPediremos que confirme seu CPF por favor\n");
            int k = GetIndex(contas);
            if (k >= 0 && k < contas.Count)
            {
                Info(contas, k);
                contas.RemoveAt(k);
                Console.WriteLine("\nConta deletada com sucesso\n");
            }
            else Console.WriteLine("\nConta não encontrada, por favor verifique os dados\n");


        }

        public static void TodasContas(List<Conta> contas)
        {
            Console.WriteLine("\nNumero de contas cadastradas: " + contas.Count + "\n");
            for (int j = 0; j < contas.Count; j++)
            {
                Info(contas, j);
            }
        }
        
        public static void ValorTotal(List<Conta> contas)
        {
            double valort = 0;
            for(int j = 0; j < contas.Count;j++)
            {
                valort = valort + contas[j].Saldo;
            }

            Console.WriteLine("\nValor total armazenado no sistema é de: R$" + valort.ToString("0.00") + "\n");
        }

        // FUNCOES OPERATIVAS DE CONTA
        public static int Login(List<Conta> contas)
        {
            int index = GetIndex(contas);
            if (index >= 0 && index < contas.Count)
            {
                Console.WriteLine("\nInsira sua senha:\n");
                string passTemp = Console.ReadLine();
                if (contas[index].Senha == passTemp)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Senha invalida\n");
                    return 0;
                }
            }
            else Console.WriteLine("Conta não encontrada\n\n"); return 0;

        }

        public static void Saque(List<Conta> contas)
        {

            Login(contas);
            Console.WriteLine("\nPediremos que confirme seu CPF por favor\n");
            int k = GetIndex(contas);
            if (k >= 0 && k < contas.Count)
            {
                if (contas[k].Saldo > 0)
                {
                    Console.WriteLine("Valor a ser sacado:\n");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    if (contas[k].Saldo > valor) { valor = valor * -1; contas[k].SetSaldo(valor); }
                    else  Console.WriteLine("\nSaldo Insuficiente!\n");




                }
                else Console.WriteLine("\nSaldo Insuficiente!\n");



            }
            else Console.WriteLine("\nConta não encontrada! Por favor verifique os dados\n");

        }

        public static void Deposito(List<Conta> contas)
        {

            Login(contas);
            Console.WriteLine("\nPediremos que confirme seu CPF por favor\n");
            int k = GetIndex(contas);
            if (k >= 0 && k < contas.Count)
            {

                Console.WriteLine("Valor a ser depositado:\n");
                double valor = Convert.ToDouble(Console.ReadLine());
                contas[k].SetSaldo(valor);




            }
            else Console.WriteLine("\nConta não encontrada! Por favor verifique os dados\n");

        }
        public static void Transferencia(List<Conta> contas)
        {
            double valor;
            Login(contas);

            Console.WriteLine("\nPediremos que confirme seu CPF antes da transferencia\n");
            int k = GetIndex(contas);
            if (k >= 0 && k < contas.Count)
            {
                if (contas[k].Saldo > 0)
                {
                    Console.WriteLine("Valor a ser transferido:\n");
                     valor = Convert.ToDouble(Console.ReadLine());
                    if (contas[k].Saldo > valor) {
                        valor = valor * -1; contas[k].SetSaldo(valor); Console.WriteLine("Valor transferido");
                        Console.WriteLine("\nConta que receberá a transferencia:\n");
                        k = GetIndex(contas);
                        if (k >= 0 && k < contas.Count)
                        {
                            valor = valor * -1;
                            contas[k].SetSaldo(valor);
                            Console.WriteLine("Valor transferido");

                        }
                        else Console.WriteLine("\nConta não encontrada! Por favor verifique os dados\n");

                    }
                    else Console.WriteLine("\nSaldo Insuficiente!\n");
                }
                else Console.WriteLine("\nSaldo Insuficiente!\n");
            }
            else Console.WriteLine("\nConta não encontrada! Por favor verifique os dados\n");
      
        }

    }
    }
    

