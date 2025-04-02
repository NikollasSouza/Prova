using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            op = "0";
            Console.WriteLine("/---MENU---/\n\n Escolha uma opção:\n\n 1 - opção 1\n 2 - opção 2\n Q - Sair!");
            while (op.ToUpper() != "Q")
            {
                Console.WriteLine("Deseja continuar?");
                op = Console.ReadLine();

                if (op.Length < 2) // Verifica se a opção é válida
                {
                    switch (op.ToUpper()) // Usar ToUpper() para aceitar tanto "q" quanto "Q"
                    {
                        case "1":
                            Console.WriteLine("Você escolheu a opção 1");
                            break;
                        case "2":
                            Console.WriteLine("Você escolheu a opção 2");
                            break;
                        case "Q":
                            Console.WriteLine("Deseja continuar?");
                            break;
                        default:
                            Console.WriteLine("Você digitou uma opção inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida");
                }
            }
        }
    }
}
