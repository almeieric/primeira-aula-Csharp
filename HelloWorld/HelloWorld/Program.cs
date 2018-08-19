using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine("O Console.ReadKey responde ao obtêm o próximo caractere pressionado pelo usuário.");
            Console.WriteLine("Já o Console.ReadLine ira ler uma linha inteira de inputs de caractere do usuario.");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
