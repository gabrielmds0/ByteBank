using System;
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

            int choice;
            do
            {
                Display();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    //cadastro
                    case 1:
                        break;
                    //Deletar
                    case 2:
                        break;
                    //Mostrar todos
                    case 3:
                        break;
                    //acessar contas e operações
                    case 4:
                        break;
                    //valor total do sistema
                    case 5:
                        break;


                }





            } while (choice != 6);

        }
    }
    
    

}
