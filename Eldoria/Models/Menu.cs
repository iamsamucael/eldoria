using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eldoria.Models
{
    public class Menu
    {
        public void Show()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nϞ ELDORIA Ϟ\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("[1] Iniciar Jogo");
            Console.WriteLine("[2] Créditos");
            Console.WriteLine("[0] Sair");
            Console.WriteLine("\n↪ Digite um número: ");
            int option = int.Parse(Console.ReadLine());
            
            switch (option) 
                {
                case 1: Start(); break;
                case 2: Credits(); break;
                case 0: Exit(); break;
                default: Console.WriteLine("\nOpção Inválida!"); Thread.Sleep(2000); 
                Show(); break;
                }

        }

        public void Exit() 
        {
            Console.Clear();
            Console.Out.WriteLine("↪ Fechando ELDORIA...");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void Credits() 
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nϞ ELDORIA - CRÉDITOS Ϟ\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Desenvolvedor: Samuel V. Araujo");
            Console.WriteLine("GitHub: https://github.com/iamsamucael");
            Console.WriteLine("Redes sociais: @iamsamucael\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("↪ Pressione ESC para voltar.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            Show();
        }

        public void Start()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Bem vindo ao mundo de ELDORIA...\n");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("O mundo onde existem criaturas bizarras, lugares misteriosos e muita IMAGINAÇÃO.");
        }
    }
}