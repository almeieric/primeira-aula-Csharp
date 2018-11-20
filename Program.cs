using System;
using System.Collections;


namespace ConsoleApp2
{
    class Program
    {
        static void ExemploCollection()
        {
            Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);


            string[] crentes = new string[] { "Jose", "Carla", "Roberta" };


            ArrayList lista = new ArrayList();
            lista.Add(crentes[1]);
            lista.Add(crentes[2]);
            lista.Add(crentes[3]);
            Console.WriteLine("A lista possui {0} elementos", lista.Count);
            Console.WriteLine("Existe o elemento2? {0}\n", lista.Contains(2));




            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + "\t");


            Console.WriteLine("A fila possui {0} elementos", fila.Count);


            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);

            while (pilha.Count > 0)
                Console.WriteLine(pilha.Pop());
            
            

            while (fila.Count > 0)
                Console.WriteLine(fila.Dequeue());
           // int elemento = (int)fila.Dequeue();

            //Console.WriteLine("O primeiro Elemento : " + o);
            Console.WriteLine("A fila possui {0} elementos", fila.Count);
        }
        static void Main(string[] args)
        {

            ExemploCollection();
            Console.ReadKey();
            /* bool sair = false;
             while (!sair)
             {

                 bool menu1 = false;
                 bool menu2 = false;
                 Console.WriteLine("Ola temos um test de menu\n aperte 1 para primeiro menu\n aperte 2 para segundo menu");

                 var test = Console.ReadKey();
                 if (menu1 = test.KeyChar == '1')
                     Console.WriteLine("\nOi eu sou o primeiro menu");
                 else if (menu2 = test.KeyChar == '2')
                     Console.WriteLine("\nOi eu sou o segundo menu menu");


                 Console.WriteLine("\nDeseja Finalizar?");
                 var finalizar = Console.ReadKey();
                 sair = finalizar.KeyChar == 'S' || finalizar.KeyChar == 's';
                 Console.WriteLine();


             } 
*/

        }
    }
}
