using OCP;
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Remuneravel remuneravel = new Estagio();
            
            Console.WriteLine(FolhaDePagamento.Calcular(remuneravel));
        }

      
    }
}
