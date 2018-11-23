using System;

namespace prova04_sistCaixaAlta
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            Console.WriteLine("Informe o Nome Completo:");
            Nome = Console.ReadLine();
            Nome = Nome.ToUpper();

            Console.WriteLine(Nome);
        }
    }
}
