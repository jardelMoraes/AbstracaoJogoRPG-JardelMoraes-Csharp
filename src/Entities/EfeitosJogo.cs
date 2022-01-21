using System;

namespace AbstracaoJogoRPG_JardelMoraes_Csharp.src.Entities
{
    public class EfeitosJogo
    {
        public string Carregando()
        {
            bool i  = true;
            while(i)
            {
                Console.Clear();
                System.Console.WriteLine("Carregando.");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Console.WriteLine("Carregando..");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Console.WriteLine("Carregando...");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Console.WriteLine("Carregando..");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Console.WriteLine("Carregando.");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Console.WriteLine("Carregando..");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Console.WriteLine("Carregando...");
                System.Threading.Thread.Sleep(500);
                i = false;
            
            }
            return "Vamos lá!";
        }

        public string BoasVindas()
        {
            System.Console.WriteLine("Seja bem vindo ao RPG-c# da DIO, o criador desta versão foi Jardel Moraes.");
            System.Console.WriteLine();
            System.Threading.Thread.Sleep(6000);
            System.Console.WriteLine("A base de conhecimento para a criação foi exposta na metoria de Orientação a Objeto com o Felipe Aguiar, da DIO!");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("Você encontrará facilmente o linkedin dele e o github com o '/henriquebenjamim...' nos dominios respectivos.");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Threading.Thread.Sleep(7000);
            Console.Clear();
            return "Iniciando o seu jogo...";
        }
    }
}