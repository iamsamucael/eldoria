using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eldoria.Models
{
    public class Choices
    {
        private void Next()
        {
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n↪ Pressione ENTER para continuar.\n");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
        public void Introduction()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Após horas navegando em seu barco, atravessando o extenso mar de Eldoria," +
            "você chegou em seu destino...");

            Next();

            Console.WriteLine("Você se encontra em uma ilha conhecida pelo seus mistérios e histórias," +
            "chamada de Ilha dos Lamentos Perdidos.");

            Next();

            Console.WriteLine("Existem histórias sobre essa ilha que são contadas há séculos," +
            "dizem que essa ilha é um verdadeiro mistério.");

            Next();

            Console.WriteLine("Dizem que muitos já vieram para essa ilha para desvendar seus mistérios...");

            Next();

            Console.WriteLine("Porém... nunca mais foram vistos.");

            Next();

            Console.WriteLine("Mas encontramos um verdadeiro Aventureiro, não é mesmo?");

            Next();

            Console.WriteLine("Estou confiante que você irá conseguir desvendar todos os mistérios dessa ilha.");
            Console.WriteLine("E ainda voltar vivo para contar para todos sobre suas aventuras aqui e se tornar uma Lenda...\n");

            Thread.Sleep(2000);
            Console.WriteLine("Então vamos começar essa longa jornada, está preparado caro Aventureiro?");

            Next();

            Console.WriteLine("Você está na praia onde parou com seu barco, então você observa tudo que tem ao seu redor...");

            Next();

            PrimaryChoice();
        }

        private void PrimaryChoice()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("» Ao NORTE você vê montanhas, " +
            "em uma das montanhas você vê um grande buraco nela que se parece com uma caverna.\n");

            Console.WriteLine("» Ao LESTE você vê um pequeno acampamento, " +
            "ainda tem sinal de fumaça vindo de lá.\n");

            Console.WriteLine("» Ao OESTE você vê uma grande floresta, " +
            "aparentemente existe uma trilha que leva para dentro da floresta.\n");

            Console.WriteLine("» Ao SUL você vê um extenso mar, onde parece não ter fim e seu barco encalhado na areia.\n");

            Console.WriteLine("Digite uma direção: ");
            string option = Console.ReadLine();
        }
    }
}