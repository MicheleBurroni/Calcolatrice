using System;
using Operazioni;
namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = classoperazioni.Numero();
            double n2 = classoperazioni.Numero();
            double? risultato = classoperazioni.Operazioni(n1, n2);
            Console.WriteLine($"{risultato}");
        }
    }
}