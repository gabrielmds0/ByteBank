using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ByteBank {
    public class Menu
    {
        //MENSAGEM INICIAL E LOGO DA APLICAÇÃO
        public static void Welcome()
        {

            string welcome_text = "\r\n██████╗░██╗░░░██╗████████╗███████╗██████╗░░█████╗░███╗░░██╗██╗░░██╗\r\n██╔══██╗╚██╗░██╔╝╚══██╔══╝██╔════╝██╔══██╗██╔══██╗████╗░██║██║░██╔╝\r\n██████╦╝░╚████╔╝░░░░██║░░░█████╗░░██████╦╝███████║██╔██╗██║█████═╝░\r\n██╔══██╗░░╚██╔╝░░░░░██║░░░██╔══╝░░██╔══██╗██╔══██║██║╚████║██╔═██╗░\r\n██████╦╝░░░██║░░░░░░██║░░░███████╗██████╦╝██║░░██║██║░╚███║██║░╚██╗\r\n╚═════╝░░░░╚═╝░░░░░░╚═╝░░░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝";
            Console.WriteLine(welcome_text);
            Console.WriteLine("\r\n█▄▄ █▀▀ █▀▄▀█   █░█ █ █▄░█ █▀▄ █▀█\r\n█▄█ ██▄ █░▀░█   ▀▄▀ █ █░▀█ █▄▀ █▄█\n");


        }
        // MENUS DE INTERAÇÃO
        public static void Display()
        {
            Console.WriteLine("Seleciona sua operação:");
            Console.WriteLine("1. Cadastrar conta\n2. Deletar conta\n3. Mostrar todos os numeros de contas cadastradas\n"
                              + "4. Acessar conta e operações\n5. Valor total no sistema\n6. Sair\n");
        }
        public static void DisplayT()
        {
            Console.WriteLine("Seleciona sua operação:");
            Console.WriteLine("1. Saque\n2. Deposito\n3. Transferencia\n"
                              + "4. Retornar ao menu principal\n");
        }
        
    }
    
    

}
