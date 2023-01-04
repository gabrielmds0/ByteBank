using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ByteBank {
    public class Menu
    {
        public static void Welcome()
        {

            string welcome_text = "\r\n██████╗░██╗░░░██╗████████╗███████╗██████╗░░█████╗░███╗░░██╗██╗░░██╗\r\n██╔══██╗╚██╗░██╔╝╚══██╔══╝██╔════╝██╔══██╗██╔══██╗████╗░██║██║░██╔╝\r\n██████╦╝░╚████╔╝░░░░██║░░░█████╗░░██████╦╝███████║██╔██╗██║█████═╝░\r\n██╔══██╗░░╚██╔╝░░░░░██║░░░██╔══╝░░██╔══██╗██╔══██║██║╚████║██╔═██╗░\r\n██████╦╝░░░██║░░░░░░██║░░░███████╗██████╦╝██║░░██║██║░╚███║██║░╚██╗\r\n╚═════╝░░░░╚═╝░░░░░░╚═╝░░░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝";
            Console.WriteLine(welcome_text);

        }
        public static void Display()
        {
            Console.WriteLine("\r\n█▄▄ █▀▀ █▀▄▀█   █░█ █ █▄░█ █▀▄ █▀█\r\n█▄█ ██▄ █░▀░█   ▀▄▀ █ █░▀█ █▄▀ █▄█\n");
            Console.WriteLine("Seleciona sua operação:");
            Console.WriteLine("1. Cadastrar conta\n2. Deletar conta\n3. Mostrar todos os numeros de contas cadastradas\n"
                              + "4. Acessar conta\n5. Valor total no sistema\n6. Sair");
        }

        public static void Selection()
        {
            List<Conta> contas = new List<Conta>();

            int choice;
            do
            {
                Display();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    //cadastro
                    case 1:
                        Funcoes.Cadastro(contas);
                        break;
                    //Deletar
                    case 2:
                        Funcoes.Deletar(contas);
                        break;
                    //Mostrar todos
                    case 3:
                        break;
                    //acessar contas e operações
                    case 4:
                        int j = Funcoes.GetIndex(contas);
                        Funcoes.Info(contas, j);
                        break;
                    //valor total do sistema
                    case 5:
                        break;


                }





            } while (choice != 6);

        }
    }
    
    

}
