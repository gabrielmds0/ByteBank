using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ByteBank
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string welcome_text = "\r\n██████╗░██╗░░░██╗████████╗███████╗██████╗░░█████╗░███╗░░██╗██╗░░██╗\r\n██╔══██╗╚██╗░██╔╝╚══██╔══╝██╔════╝██╔══██╗██╔══██╗████╗░██║██║░██╔╝\r\n██████╦╝░╚████╔╝░░░░██║░░░█████╗░░██████╦╝███████║██╔██╗██║█████═╝░\r\n██╔══██╗░░╚██╔╝░░░░░██║░░░██╔══╝░░██╔══██╗██╔══██║██║╚████║██╔═██╗░\r\n██████╦╝░░░██║░░░░░░██║░░░███████╗██████╦╝██║░░██║██║░╚███║██║░╚██╗\r\n╚═════╝░░░░╚═╝░░░░░░╚═╝░░░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝";

            List<Conta> contas = new List<Conta>();
            Menu.Welcome();
            int choice;
            do
            {
                Menu.Display();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    //cadastro
                    case 1:
                        Console.Clear();
                        Console.WriteLine(welcome_text);
                        Funcoes.Cadastro(contas);
                        break;
                    //Deletar
                    case 2:
                        Console.Clear();
                        Console.WriteLine(welcome_text);
                        Funcoes.Deletar(contas);
                        break;
                    //Mostrar todos
                    case 3:
                        Console.Clear();
                        Console.WriteLine(welcome_text);
                        Funcoes.TodasContas(contas);
                        break;
                    //acessar contas e operações
                    case 4:
                        int choiceT;
                        do
                        {

                            Menu.DisplayT();
                            choiceT = Convert.ToInt32(Console.ReadLine());
                            switch (choiceT)
                            {
                                //Saque
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(welcome_text);
                                    Funcoes.Saque(contas);
                                    break;
                                //Deposito
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(welcome_text);
                                    Funcoes.Deposito(contas);
                                    break;
                                //Transferencia
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(welcome_text);
                                    Funcoes.Transferencia(contas);
                                    break;
                                //sair
                                case 4:
                                    break;


                            }

                        } while (choiceT != 4);
                        break;
                    //valor total do sistema
                    case 5:
                        Console.Clear();
                        Console.WriteLine(welcome_text);
                        Menu.Display();
                        Funcoes.ValorTotal(contas);
                        break;
                }





            } while (choice != 6);
        }
    }

}
