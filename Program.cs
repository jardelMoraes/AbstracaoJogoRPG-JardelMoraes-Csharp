using System;
using AbstracaoJogoRPG_JardelMoraes_Csharp.src.Entities;

namespace AbstracaoJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23,"Knigth");

            Mago jardel = new Mago("Arus", 23,"Knigth");
            
            Console.WriteLine(arus.Attack());
            
        }
    }   
}

