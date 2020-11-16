using System;
using Operazioni;
namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, riultato = 0;
            string operazione;
            num1 = classoperazioni.PRIMONUMERO();
            num2 = classoperazioni.SECONDONUMERO();
            Console.WriteLine("inserisci la tua operazione");
            operazione = Console.ReadLine();
            switch (operazione)
            {
                case "Somma":
                case "+":

                    riultato = classoperazioni.SOMMA(num1, num2);
                    break;



                case "Sottrazione":
                case "-":

                    riultato = classoperazioni.SOTTRAZIONE(num1, num2);
                    break;



                case "Moltiplicazione":
                case "*":

                    riultato = classoperazioni.MOLTIPLICAZIONE(num1, num2);
                    break;



                case "Divisione":
                case "/":

                    riultato = classoperazioni.DIVISIONE(num1, num2);
                    break;
            }
            Console.WriteLine($"risultato è {riultato}");
        }
    }
}
